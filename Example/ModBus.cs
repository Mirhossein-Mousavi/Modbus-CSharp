using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    class ModBus
    {
        SerialPort _Serial;
        private int _serial_time_out = 1000;

        public ModBus(SerialPort Ser)
        {
            _Serial = Ser;

            //_Serial.BaudRate = 115200;
            _Serial.StopBits = StopBits.One;
            _Serial.DataBits = 8;
            _Serial.Parity = Parity.None;

            //_Serial.DataReceived += _Serial_DataReceived;
        }


        public int ReadTimeOut
        {
            get { return _serial_time_out; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be positive.");

                _serial_time_out = value;
            }
        }

        UInt16 Checksum(List<byte> Buffer)
        {
            byte i, j;
            uint temp, temp2, flag;
            temp = 0xFFFF;
            for (i = 0; i < Buffer.Count; i++)
            {
                temp = temp ^ Buffer[i];
                for (j = 1; j <= 8; j++)
                {
                    flag = temp & 0x0001;
                    temp >>= 1;
                    if (flag != 0) temp ^= 0xA001;
                }
            }
            // Reverse byte order.
            temp2 = temp >> 8;
            temp = (temp << 8) | temp2;
            temp &= 0xFFFF;

            return (UInt16)temp;
        }

        private byte highByte(int w) { return (byte)((w) >> 8); }

        private byte lowByte(int w) { return (byte)((w) & 0xff); }

        private int CombineBytes(byte High, byte Low) { return (High << 8) | Low; }

        public bool Write_Request(byte SlaveId, int StartAddress, int[] Data)
        {
            List<byte> Ask_Data = new byte[] { SlaveId, 16, highByte(StartAddress), lowByte(StartAddress), highByte(Data.Length), lowByte(Data.Length), (byte)(Data.Length * 2) }.ToList();
            foreach (int i in Data) Ask_Data.AddRange(new byte[] { highByte(i), lowByte(i) });
            int crc = Checksum(Ask_Data);
            Ask_Data.AddRange(new byte[] { highByte(crc), lowByte(crc) });

            _Serial.Write(Ask_Data.ToArray(), 0, Ask_Data.Count);
            System.Threading.Thread.Sleep(50);
            byte[] buffer = new byte[8];
            try
            {
                _Serial.ReadTimeout = _serial_time_out;
                _Serial.Read(buffer, 0, 8);
                List<byte> CheckData = new byte[] { SlaveId, 16, highByte(StartAddress), lowByte(StartAddress), highByte(Data.Length), lowByte(Data.Length)}.ToList();
                crc = Checksum(CheckData);
                CheckData.AddRange(new byte[] { highByte(crc), lowByte(crc) });
                return buffer.SequenceEqual(CheckData.ToArray());
            }
            catch
            {
                return false;
            }
        }

        public List<int> Read_Request(byte SlaveId, int StartAddress, int Count)
        {
            List<byte> Ask_Data = new byte[] { SlaveId, 3, highByte(StartAddress), lowByte(StartAddress), highByte(Count), lowByte(Count) }.ToList();
            int crc = Checksum(Ask_Data);

            Ask_Data.AddRange(new byte[] { highByte(crc), lowByte(crc) });
            byte[] buffer = new byte[Count * 2 + 5];

            _Serial.Write(Ask_Data.ToArray(), 0, Ask_Data.Count);
            System.Threading.Thread.Sleep(50);
            _Serial.ReadTimeout = _serial_time_out;
            _Serial.Read(buffer, 0, Count * 2 + 5);

            byte[] Data_CRC = buffer.Where((source, index) => index >= buffer.Length - 2).ToArray();
            buffer = buffer.Where((source, index) => index < buffer.Length - 2).ToArray();
            //MessageBox.Show(string.Join(" ,", Data_CRC));

            int i = Checksum(buffer.ToList());
            if (highByte(i) == Data_CRC[0] && lowByte(i) == Data_CRC[1])           //checksum is correct
            {
                //MessageBox.Show(string.Join(" ,", buffer));
                List<int> Data = new List<int>();
                for (int j = 3; j < buffer.Length; j += 2) Data.Add(CombineBytes(buffer[j], buffer[j + 1]));
                return Data;
            }
            else return null;  //checksum is not correct.so data is not valid
        }
       

        enum Mode
        {
            Ideal = -1,
            Read = 0,
            Write = 1
        }
    }
}

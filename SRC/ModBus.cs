using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;

namespace Example
{
    class ModBus
    {
        SerialPort _Serial;
        public List<int> Income_Data = new List<int>();

        int BytesToRead;
        Mode _mode = Mode.Ideal;

        public ModBus(SerialPort Ser)
        {
            _Serial = Ser;

            _Serial.BaudRate = 115200;
            _Serial.StopBits = StopBits.One;
            _Serial.DataBits = 8;
            _Serial.Parity = Parity.None;

            _Serial.DataReceived += _Serial_DataReceived;
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

        public void Write_Request(byte SlaveId, int StartAddress, int[] Data)
        {

            //List<byte> Get_Ready = new List<byte>();

            byte[] Get_Ready = new byte[] { SlaveId, 16, highByte(StartAddress), lowByte(StartAddress), highByte(Data.Length), lowByte(Data.Length), (byte)(Data.Length * 2) };

            List<byte> Final_Data = Get_Ready.ToList();
            foreach (int i in Data)
            {
                Final_Data.Add(highByte(i));
                Final_Data.Add(lowByte(i));
            }

            int crc = Checksum(Final_Data);
            Final_Data.Add(highByte(crc));
            Final_Data.Add(lowByte(crc));

            _mode = Mode.Write;
            BytesToRead = 8;
            _Serial.Write(Final_Data.ToArray(), 0, Final_Data.Count);
            System.Threading.Thread.Sleep(100);
        }

        public void Read_Request(byte SlaveId,int StartAddress,int Count)
        {
            Income_Data.Clear();
            byte[] Get_Ready = new byte[] { SlaveId,3,highByte(StartAddress),lowByte(StartAddress), highByte(Count),lowByte(Count) };

            List<byte> Final_Data = Get_Ready.ToList();
            int crc = Checksum(Final_Data);

            Final_Data.Add(highByte(crc));
            Final_Data.Add(lowByte(crc));

            _mode = Mode.Read;
            BytesToRead = Count * 2 + 5;
            _Serial.Write(Final_Data.ToArray(), 0, Final_Data.Count);
            System.Threading.Thread.Sleep(100);
        }

        private void _Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            List<byte> Raw_Data = new List<byte>();

            Income_Data.Clear();           //commented
            for (int i = 0; i < BytesToRead; i++) Raw_Data.Add((byte)_Serial.ReadByte());


            for (int i = 3; i < Raw_Data.Count - 2 && Raw_Data[1] == 3; i += 2)
                Income_Data.Add(CombineBytes(Raw_Data[i], Raw_Data[i + 1]));
            
            
        }

        enum Mode
        {
            Ideal = -1,
            Read = 0,
            Write = 1
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Example
{
    public partial class Form1 : Form
    {
        SerialPort Serial = new SerialPort();
        ModBus modbus;

        public Form1()
        {
            InitializeComponent();
            SerialPorts.Items.AddRange(SerialPort.GetPortNames());
            if (SerialPort.GetPortNames().Length > 0) SerialPorts.SelectedIndex = 0;
        }

        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void SerialRefresh_Click(object sender, EventArgs e)
        {
            Serial.Close();
            SerialStatus.BackColor = Color.Empty;
            SerialPorts.Items.Clear();
            SerialPorts.Text = string.Empty;
            SerialPorts.Items.AddRange(SerialPort.GetPortNames());
            if (SerialPort.GetPortNames().Length > 0) SerialPorts.SelectedIndex = 0;
        }

        private void SerialConnect_Click(object sender, EventArgs e)
        {
            Serial.Close();
            SerialStatus.BackColor = Color.Empty;
            if (SerialPorts.Text == string.Empty) MessageBox.Show("no port available!", "Serialport Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (BaudrateTextbox.Text == string.Empty) MessageBox.Show("Please enter baudrate", "Serial Baudrate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Serial.BaudRate = Convert.ToInt32(BaudrateTextbox.Text);
                Serial.PortName = SerialPorts.Text;
                try
                {
                    Serial.Open();
                    modbus = new ModBus(Serial);
                    SerialStatus.BackColor = Color.DodgerBlue;
                }
                catch
                {
                    SerialRefresh_Click(sender, e);
                    SerialConnect_Click(sender, e);
                }

            }
        }

        private void ReadRegister_ButtonClick(object sender, EventArgs e)
        {
            if (!Serial.IsOpen) MessageBox.Show("Serial is not Connected.", "Serial Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (mod3configs.Controls.OfType<TextBox>().AsQueryable().Any(x => x.Text == string.Empty)) MessageBox.Show("Please fill all textboxs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (Convert.ToInt32(Slaveid3.Text) > 255) MessageBox.Show("SlaveID must be less than 255.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                List<int> Data = modbus.Read_Request(Convert.ToByte(Slaveid3.Text), Convert.ToInt32(startaddress3.Text), Convert.ToInt32(count3.Text));

                ReadRegisterList.Items.Clear();

                ReadRegisterList.Items.AddRange(Data.Select((x, n) => "Address :" + (n + Convert.ToByte(startaddress3.Text)).ToString() + "        Value : " + x.ToString()).ToArray());
            }
            //modbus.Write_Request(4, 0, new int[] { 1, 5, 5 });

            //var a = modbus.Read_Request(4, 0, 13);
            //MessageBox.Show(string.Join(" ,", a));
        }

        private void WriteRegisterSet_CLK(object sender, EventArgs e)
        {
            if (!Serial.IsOpen) MessageBox.Show("Serial is not Connected.", "Serial Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (mod16configs.Controls.OfType<TextBox>().AsQueryable().Any(x => x.Text == string.Empty)) MessageBox.Show("Please fill all textboxs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (Convert.ToInt32(Slaveid16.Text) > 255) MessageBox.Show("SlaveID must be less than 255.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                WriteRegisterPanel.Controls.Clear();
                byte slaveid = Convert.ToByte(Slaveid16.Text);
                int startAdd = Convert.ToInt32(startaddress16.Text);
                int count = Convert.ToInt32(count16.Text);

                WriteRegisterPanel.Hide();
                for (int i = 0; i < count; i++)
                {
                    Label label = new Label();
                    label.Text = (startAdd + i).ToString() + " :";
                    label.AutoSize = true;
                    WriteRegisterPanel.Controls.Add(label);
                    label.Location = new Point(10, i * 30 + 9);

                    TextBox textBox = new TextBox();
                    textBox.Width = 30;
                    textBox.Text = "0";
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.KeyPress += _KeyPress;
                    WriteRegisterPanel.Controls.Add(textBox);
                    textBox.Location = new Point(50, i * 30 + 5);
                }
                WriteRegisterButt.Visible = true;

                WriteRegisterPanel.Show();
            }
        }

        private void WriteRegisterButt_Click(object sender, EventArgs e)
        {
            byte slaveid = Convert.ToByte(Slaveid16.Text);
            int startAdd = Convert.ToInt32(startaddress16.Text);
            bool success= modbus.Write_Request(slaveid, startAdd, WriteRegisterPanel.Controls.OfType<TextBox>().Select(x => Convert.ToInt32(x.Text)).ToArray());
            MessageBox.Show(success ? "Writing register is Successfull :)" : "Writing register Failed :(");
        }
    }
}

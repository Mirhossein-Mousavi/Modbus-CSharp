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
                    SerialStatus.BackColor = Color.DodgerBlue;
                }
                catch
                {
                    SerialRefresh_Click(sender, e);
                    SerialConnect_Click(sender, e);
                }

            }
        }
    }
}

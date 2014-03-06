using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindTouch
{
    public partial class SerialSetting : Form
    {
        public SerialPort sp = null;
        public SerialSetting()
        {
            InitializeComponent();
        }

        public SerialSetting(SerialPort sp)
        {
            this.sp = sp;
            InitializeComponent();
        }

        private void SerialSetting_Load(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            if (portList.Length == 0)
            {
                MessageBox.Show("没有可用的COM端口！");
                this.Close();
                return;
            }
            for (int i = 0; i < portList.Length; i++)
            {
                string name = portList[i];
                combo_name.Items.Add(name);
            }
            combo_name.SelectedIndex = 0;
            combo_data.Text = sp.DataBits.ToString();
            combo_parity.Text = sp.Parity.ToString();
            combo_stop.Text = sp.StopBits.ToString();
            combo_baudrate.Text = sp.BaudRate.ToString();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Go_Click(object sender, EventArgs e)
        {
            sp.BaudRate = Int32.Parse(combo_baudrate.Text);
            sp.DataBits = Int32.Parse(combo_data.Text);
            sp.PortName = combo_name.Text;
            sp.StopBits = (StopBits)combo_stop.SelectedIndex;
            sp.Parity = (Parity)combo_parity.SelectedIndex;
            sp.Open();
            sp.NewLine = "\n";
            this.Close();
        }
    }
}

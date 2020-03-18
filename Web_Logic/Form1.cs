using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Web_Logic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Общ.инф.
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = PcGenInfo.GetComputerName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = PcGenInfo.GetAccountName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = PcGenInfo.GetKeyboardName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = PcGenInfo.GetKeyboardDescription();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = PcGenInfo.GetMACAddress();
        }

        //Процессор
        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = Processor.GetProcessorInformation();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label7.Text = Processor.GetProcessorDescription();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label8.Text = Processor.GetProcessorNumberOfCores();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label9.Text = Processor.GetCpuSpeedInGHz().ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label10.Text = Processor.GetProcessorCurrentClockSpeed();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label16.Text = Processor.GetProcessorThreadCount().ToString();
        }

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    label11.Text = OS.GetAccountOSName();
        //}
    }
}

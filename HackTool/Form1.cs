using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Hack_Tool
{
    public partial class Form1 : Form
    {
        protected int StartPort;
        protected int EndPort;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            StartPort = Convert.ToInt32(numStart.Value);
            EndPort = Convert.ToInt32(numEnd.Value);

            prgScanning.Value = 0;

            prgScanning.Maximum = EndPort - StartPort + 1;

            Cursor.Current = Cursors.WaitCursor;

            for (int CurrPort = StartPort; CurrPort <= EndPort; CurrPort++)
            {
                TcpClient TcpScan = new TcpClient();
                try
                {

                    TcpScan.Connect(txtIP.Text, CurrPort);

                    txtLog.AppendText("Port " + CurrPort + " open\r\n");
                }
                catch
                {


                    txtLog.AppendText("Port " + CurrPort + " closed\r\n");
                }

                prgScanning.PerformStep();
            }

            Cursor.Current = Cursors.Arrow;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

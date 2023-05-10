using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPClient
{
    public partial class Form1 : Form
    {
        UdpClient udpClient;
        System.Threading.Thread ThreadReceive;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCON_Click_1(object sender, EventArgs e)
        {
            try
            {
                string IPAddress = txtIP.Text;
                string UDPPortStr = txtPORT.Text;
                int UDPPortInt;
                bool parsed = Int32.TryParse(UDPPortStr, out UDPPortInt);
                udpClient = new UdpClient(UDPPortInt);
                udpClient.Connect(IPAddress, UDPPortInt);
                ThreadReceive = new System.Threading.Thread(ReceiveMessages);
                ThreadReceive.Start();
            }
            catch
            {
            }
        }

        public void ReceiveMessages()
        {
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
            string returnData = Encoding.ASCII.GetString(receiveBytes);
            this.Invoke(new MethodInvoker(delegate ()
            {
                string[] datas = returnData.Split('*');
                txtIN.Text = datas[0];
            }));
            NewInitialize();
        }
        public void NewInitialize()
        {
            ThreadReceive = new System.Threading.Thread(ReceiveMessages);
            ThreadReceive.Start();
        }
      
        private void btnDIS_Click_1(object sender, EventArgs e)
        {
            udpClient.Close();

        }

        private void btnSEND_Click_1(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(txtIP.Text, Convert.ToInt16(txtPORT.Text));
            Byte[] senddata = Encoding.ASCII.GetBytes(txtTO.Text);
            udpClient.Send(senddata, senddata.Length);
        }
    }
}

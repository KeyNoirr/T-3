using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3
{
    public partial class FrmClient : Form
    {
        Socket servers;
        EndPoint remote;
        public FrmClient()
        {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            servers = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            remote = (EndPoint)ipe;
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtYourS.Text = "Kéo";
            byte[] sendData = Encoding.ASCII.GetBytes("0");
            servers.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];
            servers.ReceiveFrom(receiveData, ref remote);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));

            if (recv == 0)
                txtYourR.Text = "Hòa";
            else if (recv == 1)
                txtYourR.Text = "Thua";
            else
                txtYourR.Text = "Thắng";
        }


        private void btnBua_Click(object sender, EventArgs e)
        {
            txtYourS.Text = "Búa";
            byte[] sendData = Encoding.ASCII.GetBytes("1");
            servers.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];
            servers.ReceiveFrom(receiveData, ref remote);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));

            if (recv == 0)
                txtYourR.Text = "Thắng";
            else if (recv == 1)
                txtYourR.Text = "Hòa";
            else
                txtYourR.Text = "Thua";
        }


        private void btnBao_Click(object sender, EventArgs e)
        {
            txtYourS.Text = "Bao";
            byte[] sendData = Encoding.ASCII.GetBytes("2");
            servers.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];
            servers.ReceiveFrom(receiveData, ref remote);
            int recv = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));

            if (recv == 0)
                txtYourR.Text = "Thua";
            else if (recv == 1)
                txtYourR.Text = "Thắng";
            else
                txtYourR.Text = "Hòa";
        }

        private void FrmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            servers.Close();
        }
    }
}

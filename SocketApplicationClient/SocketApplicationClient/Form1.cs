using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace SocketApplicationClient
{
    public partial class frmClient : Form
    {

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            Msg("Client started.");
            clientSocket.Connect("127.0.0.1", 6969);
            lblStatus.Text = "Client Socket Program - Connected to Server...";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(txtMessage.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            Msg(returndata);
            txtMessage.Text = "";
            txtMessage.Focus();
        }

        public void Msg(string msg)
        {
            txtServer.Text += txtServer.Text + Environment.NewLine + ">> " + msg;
        }
    }
}

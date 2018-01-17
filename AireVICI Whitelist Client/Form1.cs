using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace AireVICI_Whitelist_Client
{
    public partial class frmAireVICI_whitelistClient : Form
    {
        public frmAireVICI_whitelistClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPv4_Whitelist client = new IPv4_Whitelist(txtUsername.Text, txtPassword.Text, "162.244.66.94", 24737);

            //MessageBox.Show(client.GetProxy_IPv4());
            MessageBox.Show("GetIP: " + client.GetIPv4());
            //Process.Start("chrome.exe", "http://68.168.108.51/agc/vicidial.php?relogin=NO&VD_login=airespringjun&VD_campaign=3102017&phone_login=8189220958&phone_pass=P88sI55d&VD_pass=P88sI55d");
            //MySql.Data.MySqlClient.MySqlConnection db;

            //string connStr = "server=68.168.108.42;port=3306;Database=AireVICI;uid=whitelist;pwd=723FxZpoQqkL;";

            //try
            //{
            //    db = new MySql.Data.MySqlClient.MySqlConnection();
            //    db.ConnectionString = connStr;
            //    db.Open();

            //    if(db.State == ConnectionState.Open)
            //    {

            //    }

            //    db.Close();
            //}
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //sting cmd = "";
            //System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
            //clientSocket.Connect("68.168.108.42", 6336);

            //NetworkStream serverStream = clientSocket.GetStream();
            //cmd = "SendIP::" + txtUsername + "::" + txtPassword++;
            //byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
            //serverStream.Write(outStream, 0, outStream.Length);
            //serverStream.Flush();

            //byte[] inStream = new byte[10025];
            //serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            //string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            //msg(returndata);






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TimerWhitelist_Tick(object sender, EventArgs e)
        {
            // Here lies the magic
        }

        private void txtBrowser_Click(object sender, EventArgs e)
        {
            if(openFileDialog_browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBrowser.Text = openFileDialog_browser.FileName;
            }
        }

        private void txtSoftphone_Click(object sender, EventArgs e)
        {
            if(openFileDialog_softphone.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSoftphone.Text = openFileDialog_softphone.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace AireVICI_Whitelist_Client
{
    class IPv4_Whitelist
    {
        private string URI;
        private string server_ip;
        private Int32 port;
        private TcpClient Client;
        private string username;
        private string password;

        public IPv4_Whitelist(string username, string password, string server_ip = "127.0.0.1", Int32 port = 24737, string URI = "https://api.ipify.org")
        {
            this.server_ip = server_ip;
            this.port = port;
            this.URI = URI;
            this.username = username;
            this.password = password;
            
            Client = new TcpClient(this.server_ip, this.port);
            
        }

        public string GetIPv4()
        {
            string cmd = "GetIP::" + this.username + "::" + this.password + "::&&";
            //string cmd = "Airespring 2018";
            String responseData = String.Empty;

            if (this.Client.Connected)
            {
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(cmd);
                NetworkStream stream = this.Client.GetStream();
                stream.Write(data, 0, data.Length);

                data = new Byte[256];

                
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                

                stream.Close();
                //this.Client.Close();
            }
            else
            {
                responseData = "Error: Not Connected";
            }
            return responseData;
        }

        // seq format: port:type,port:type
        public void Knock(string seq)
        {
            return;
        }

        public string GetProxy_IPv4()
        {
            string s;

            using (WebClient client = new WebClient())
            {
                s = client.DownloadString(this.URI);
            }

            return s;
        }

        public Boolean IsConnected()
        {
            return this.Client.Connected;
        }

        public Boolean UpdateIPv4(string ipv4, string proxy_ipv4)
        {
            string cmd = "UpdateIP::" + this.username + "::" + this.password + "::" + ipv4 + "::" + proxy_ipv4 + "&&";
            return true;
        }
    }
}

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
        private IPAddress server_ip;
        private Int32 port;

        public IPv4_Whitelist(IPAddress server_ip, Int32 port = 6336, string URI = "https://api.ipify.org")
        {
            this.server_ip = server_ip;
            this.port = port;
            this.URI = URI;
        }

        public string GetIPv4()
        {
            return "0";
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
    }
}

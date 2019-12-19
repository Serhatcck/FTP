using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_END
{
    public class Client
    {
        TcpClient client;
        string ipAdresi;
        int port;
        Stream stream;
        IPEndPoint ep;
        public Client(string ipAdresi , int port)
        {
            ep = new IPEndPoint(IPAddress.Parse(ipAdresi), port);
            this.ipAdresi = ipAdresi;
            this.port = port;
            client = new TcpClient();
        }

        public void Connect()
        {
            client.Connect(ep);
            
        }
        
        public void GetStream()
        {
            stream = client.GetStream();
            
        }

        public void Write(byte[] fileArray,int ofset,int read,Button btn)
        {
            stream.Write(fileArray, ofset, read);
            btn.Enabled = true;
            
        }

        public void Close()
        {
            stream.Close();
            client.Close();
            stream.Dispose();
            client.Dispose();
        }
    }
}

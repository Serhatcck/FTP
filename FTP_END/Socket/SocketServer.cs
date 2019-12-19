using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_END.Socket
{
    public class SocketServer
    {
        int port;
        TcpListener listener = null ;
        TcpClient client;
        NetworkStream stream;
        ProgressBar progressBar;
        Label label;
        byte[] receivedBytes;
        byte[] infoArray;
        public int size = 2000;
        ListView listwiev;


        public string extention { get; set; }
        
        

        public SocketServer(int port,ProgressBar progressBar,ListView listView)
        {
            this.port = port;
            this.progressBar = progressBar;
            this.listwiev = listView;
        }

        public void Start(string info,Int32 size)  
        {
           
            listener = new TcpListener(System.Net.IPAddress.Any, port);
            listener.Start();
            this.client = listener.AcceptTcpClient();
            this.extention = info;
            this.size = size;
            
        }

        public void StartStream()
        {
            stream = client.GetStream();
            infoArray = Read();
            string array = Encoding.Default.GetString(infoArray, 0, infoArray.Length);
            string[] array_words = array.Split('*');


            if (array_words[0] == "Header")
            {
                this.size = Convert.ToInt32(array_words[1]);
                this.extention = array_words[2];
                

            }
            else
            {
                ListViewItem item1 = new ListViewItem(DateTime.Now.ToString(), 0);
                
                
                
                item1.SubItems.Add(extention);
                item1.SubItems.Add(size.ToString()+" byte");
                listwiev.Items.Add(item1);
                FileReadLog();
               
                
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"\\"+ extention;
                File.WriteAllBytes(path, infoArray);
            }
            
        }

        public byte[] Read()
        {
            
            byte[] receivedBytes = new byte[size];
            int numberOfBytesRead = 0;
            this.progressBar.Maximum =size;
            this.progressBar.Minimum = 0;
            progressBar.Value = 0;
            progressBar.Step = size;
            
            if (stream.CanRead)
            {
                
                do
                {
                  numberOfBytesRead = stream.Read(receivedBytes, 0, receivedBytes.Length);
                    progressBar.Value = numberOfBytesRead;
                }
                while (stream.DataAvailable);
                

                return receivedBytes;
            }
            else { MessageBox.Show("Okunamaz"); return null; }

        }
        
        
        public void Close()
        {
            listener.Stop();
            client.Close();
            stream.Close();
        }

        public void FileReadLog()
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\log.txt"; 
            
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            
            StreamWriter sw = new StreamWriter(fs);
            
            sw.WriteLine("Tarih:"+DateTime.Now.ToString()+"\tDosya:"+extention+"\tBoyut:"+size.ToString()+"\n");
            
            sw.Flush();
            
            sw.Close();
            fs.Close();
            
        }
    }
}

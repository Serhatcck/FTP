using FTP_END.Socket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_END
{
    public partial class Form2 : Form
    {
        
        string headerInfo= null;
        Int32 boyut= 1024;
        public static int port = Form1.port;
        SocketServer server;
        public Form2()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        
        public void fileServer()
        {
            
            try
            {


                server  = new SocketServer(port, progressBar1,listView1);

                server.Start(headerInfo, boyut);
                server.StartStream();
                if (server.extention != headerInfo)
                    headerInfo = server.extention;
                if (server.size != boyut)
                    boyut= server.size;
                server.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Baglantı Bekleniyor");
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            Thread th = new Thread(thh);
            th.Start();
        }
        public void thh()
        {
            while(true)
            {
                fileServer();
            }
            

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

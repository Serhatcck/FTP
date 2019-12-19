using FTP_END.FıleProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_END
{
    public partial class Form1 : Form
    {
        OpenFileDialog dlg;
        public static int port;    
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (IPAddress adres in Dns.GetHostAddresses(Dns.GetHostName()))
            { IpAdreslbl.Text = adres.ToString(); }
            Random random = new Random();
            port = random.Next(1000, 9000);
            portLbl.Text = port.ToString();

        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text;
            string password = userPasswordTxt.Text;

            if (userName == "1170505041" && password== "cicek")
            {
                grsPanel.Visible = false;
                IpPanel.Visible = true;
            }
            else if (userName == "1170505031" && password == "öztürk")
            {
                grsPanel.Visible = false;
                IpPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Tekrar Deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fileUploadProcessBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            selectFileBtn.Visible = true;
            
        }
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            dlg = new OpenFileDialog();
            dlg.ShowDialog();
            panel3.Visible = true;
            pathTxt.Text = dlg.FileName;
            UploadBtn.Enabled = false;
            connectBtn.Enabled = true;
        }

       

        private void fileDownloadProcessBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Form2 frm = new Form2();
            frm.ShowDialog();
            
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {   
            //Task ts = Task.Run(() => FileClientHeader());
            
            //ts.Wait();
            Thread info = new Thread(FileClientInfo);
            info.Start();
            connectBtn.Enabled = false;
        }

        public void FileClientHeader()
        {
            try
            {
                FileProcessCreater headerCreater = new FileProcessCreater();
                FileProcessInterface haederFileProcess = headerCreater.Secim(FileProcessCreater.SecimType.GetHeader, dlg.FileName);
                Client client = new Client(targetIpTxt.Text,int.Parse(targetPortTxt.Text));
                client.Connect();

                client.GetStream();
                
                client.Write(haederFileProcess.GetInfo(), 0, haederFileProcess.GetInfo().Length,UploadBtn);
                client.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FileClientInfo()
        {
            
            FileProcessCreater infoCreater = new FileProcessCreater();
            FileProcessInterface infoFileProcess = infoCreater.Secim(FileProcessCreater.SecimType.GetInfo, dlg.FileName);
            Client client2 = new Client(targetIpTxt.Text, int.Parse(targetPortTxt.Text));
            client2.Connect();

            client2.GetStream();

            client2.Write(infoFileProcess.GetInfo(), 0, infoFileProcess.GetInfo().Length, UploadBtn);
            client2.Close();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(FileClientHeader);
            th.Start();
        }
    }
}

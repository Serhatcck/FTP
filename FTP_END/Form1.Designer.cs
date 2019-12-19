namespace FTP_END
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IpAdreslbl = new System.Windows.Forms.Label();
            this.portLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userPasswordTxt = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.Namelbl = new System.Windows.Forms.Label();
            this.computerPic = new System.Windows.Forms.PictureBox();
            this.fileUploadProcessBtn = new System.Windows.Forms.Button();
            this.IpPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.targetIpTxt = new System.Windows.Forms.TextBox();
            this.targetPortTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileDownloadProcessBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.connectBtn = new System.Windows.Forms.Button();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.grsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.computerPic)).BeginInit();
            this.IpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İp Adresiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Portunuz:";
            // 
            // IpAdreslbl
            // 
            this.IpAdreslbl.AutoSize = true;
            this.IpAdreslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IpAdreslbl.Location = new System.Drawing.Point(122, 9);
            this.IpAdreslbl.Name = "IpAdreslbl";
            this.IpAdreslbl.Size = new System.Drawing.Size(81, 24);
            this.IpAdreslbl.TabIndex = 2;
            this.IpAdreslbl.Text = "IP Adres";
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portLbl.Location = new System.Drawing.Point(122, 56);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(43, 24);
            this.portLbl.TabIndex = 3;
            this.portLbl.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(5, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Şifre:";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameTxt.Location = new System.Drawing.Point(127, 3);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(162, 29);
            this.userNameTxt.TabIndex = 10;
            // 
            // userPasswordTxt
            // 
            this.userPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userPasswordTxt.Location = new System.Drawing.Point(127, 47);
            this.userPasswordTxt.Name = "userPasswordTxt";
            this.userPasswordTxt.PasswordChar = '*';
            this.userPasswordTxt.Size = new System.Drawing.Size(162, 29);
            this.userPasswordTxt.TabIndex = 11;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enterBtn.Location = new System.Drawing.Point(84, 106);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(124, 35);
            this.enterBtn.TabIndex = 12;
            this.enterBtn.Text = "Giriş";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Namelbl.Location = new System.Drawing.Point(486, 3);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(184, 93);
            this.Namelbl.TabIndex = 13;
            this.Namelbl.Text = "Kerim Öztürk\r\nSerhat Çiçek\r\nFTP Projesi\r\n";
            // 
            // computerPic
            // 
            this.computerPic.Image = ((System.Drawing.Image)(resources.GetObject("computerPic.Image")));
            this.computerPic.Location = new System.Drawing.Point(406, 118);
            this.computerPic.Name = "computerPic";
            this.computerPic.Size = new System.Drawing.Size(324, 144);
            this.computerPic.TabIndex = 14;
            this.computerPic.TabStop = false;
            // 
            // fileUploadProcessBtn
            // 
            this.fileUploadProcessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileUploadProcessBtn.Location = new System.Drawing.Point(16, 4);
            this.fileUploadProcessBtn.Name = "fileUploadProcessBtn";
            this.fileUploadProcessBtn.Size = new System.Drawing.Size(229, 35);
            this.fileUploadProcessBtn.TabIndex = 15;
            this.fileUploadProcessBtn.Text = "Dosya Gönderme İşlemi";
            this.fileUploadProcessBtn.UseVisualStyleBackColor = true;
            this.fileUploadProcessBtn.Click += new System.EventHandler(this.fileUploadProcessBtn_Click);
            // 
            // IpPanel
            // 
            this.IpPanel.Controls.Add(this.pictureBox2);
            this.IpPanel.Controls.Add(this.selectFileBtn);
            this.IpPanel.Controls.Add(this.panel1);
            this.IpPanel.Controls.Add(this.label1);
            this.IpPanel.Controls.Add(this.label2);
            this.IpPanel.Controls.Add(this.IpAdreslbl);
            this.IpPanel.Controls.Add(this.portLbl);
            this.IpPanel.Controls.Add(this.panel2);
            this.IpPanel.Location = new System.Drawing.Point(12, 19);
            this.IpPanel.Name = "IpPanel";
            this.IpPanel.Size = new System.Drawing.Size(680, 307);
            this.IpPanel.TabIndex = 16;
            this.IpPanel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(346, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 144);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectFileBtn.Location = new System.Drawing.Point(233, 268);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(159, 37);
            this.selectFileBtn.TabIndex = 22;
            this.selectFileBtn.Text = "Dosya Seç";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Visible = false;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.targetIpTxt);
            this.panel1.Controls.Add(this.targetPortTxt);
            this.panel1.Location = new System.Drawing.Point(9, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 100);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hedef IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hedef Port:";
            // 
            // targetIpTxt
            // 
            this.targetIpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.targetIpTxt.Location = new System.Drawing.Point(138, 13);
            this.targetIpTxt.Name = "targetIpTxt";
            this.targetIpTxt.Size = new System.Drawing.Size(145, 29);
            this.targetIpTxt.TabIndex = 10;
            // 
            // targetPortTxt
            // 
            this.targetPortTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.targetPortTxt.Location = new System.Drawing.Point(138, 61);
            this.targetPortTxt.Name = "targetPortTxt";
            this.targetPortTxt.Size = new System.Drawing.Size(145, 29);
            this.targetPortTxt.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fileDownloadProcessBtn);
            this.panel2.Controls.Add(this.fileUploadProcessBtn);
            this.panel2.Location = new System.Drawing.Point(84, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 41);
            this.panel2.TabIndex = 18;
            // 
            // fileDownloadProcessBtn
            // 
            this.fileDownloadProcessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileDownloadProcessBtn.Location = new System.Drawing.Point(259, 3);
            this.fileDownloadProcessBtn.Name = "fileDownloadProcessBtn";
            this.fileDownloadProcessBtn.Size = new System.Drawing.Size(229, 35);
            this.fileDownloadProcessBtn.TabIndex = 20;
            this.fileDownloadProcessBtn.Text = "Dosya Alma İşlemi";
            this.fileDownloadProcessBtn.UseVisualStyleBackColor = true;
            this.fileDownloadProcessBtn.Click += new System.EventHandler(this.fileDownloadProcessBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.connectBtn);
            this.panel3.Controls.Add(this.pathTxt);
            this.panel3.Controls.Add(this.UploadBtn);
            this.panel3.Location = new System.Drawing.Point(63, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 100);
            this.panel3.TabIndex = 18;
            this.panel3.Visible = false;
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connectBtn.Location = new System.Drawing.Point(424, 3);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(115, 45);
            this.connectBtn.TabIndex = 3;
            this.connectBtn.Text = "Baglan";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // pathTxt
            // 
            this.pathTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathTxt.Location = new System.Drawing.Point(19, 23);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.ReadOnly = true;
            this.pathTxt.Size = new System.Drawing.Size(385, 29);
            this.pathTxt.TabIndex = 2;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Enabled = false;
            this.UploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UploadBtn.Location = new System.Drawing.Point(424, 52);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(115, 45);
            this.UploadBtn.TabIndex = 1;
            this.UploadBtn.Text = "Gonder";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // grsPanel
            // 
            this.grsPanel.Controls.Add(this.label7);
            this.grsPanel.Controls.Add(this.label8);
            this.grsPanel.Controls.Add(this.computerPic);
            this.grsPanel.Controls.Add(this.userNameTxt);
            this.grsPanel.Controls.Add(this.Namelbl);
            this.grsPanel.Controls.Add(this.userPasswordTxt);
            this.grsPanel.Controls.Add(this.enterBtn);
            this.grsPanel.Location = new System.Drawing.Point(12, 21);
            this.grsPanel.Name = "grsPanel";
            this.grsPanel.Size = new System.Drawing.Size(776, 278);
            this.grsPanel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.IpPanel);
            this.Controls.Add(this.grsPanel);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Serhat Çiçek Kerim Öztürk FTP UYGULAMA     V 1.0  Stable Version";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerPic)).EndInit();
            this.IpPanel.ResumeLayout(false);
            this.IpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grsPanel.ResumeLayout(false);
            this.grsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IpAdreslbl;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox userPasswordTxt;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.PictureBox computerPic;
        private System.Windows.Forms.Button fileUploadProcessBtn;
        private System.Windows.Forms.Panel IpPanel;
        private System.Windows.Forms.Panel grsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox targetIpTxt;
        private System.Windows.Forms.TextBox targetPortTxt;
        private System.Windows.Forms.Button fileDownloadProcessBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button connectBtn;
    }
}


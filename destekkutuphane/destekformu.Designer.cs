namespace destekkutuphane
{
    partial class destekformu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(destekformu));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_konu = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_konu = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.lbl_kalan = new System.Windows.Forms.Label();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.pnl_reportgonder = new System.Windows.Forms.Panel();
            this.pnl_acilis = new System.Windows.Forms.Panel();
            this.btn_reportkontrol = new System.Windows.Forms.Button();
            this.btn_reportgonder = new System.Windows.Forms.Button();
            this.tmr_paneldegis = new System.Windows.Forms.Timer(this.components);
            this.btn_geri = new System.Windows.Forms.Button();
            this.pnl_reportkontrol = new System.Windows.Forms.Panel();
            this.lbl_reportidkntrl = new System.Windows.Forms.Label();
            this.txt_reportidkntrl = new System.Windows.Forms.TextBox();
            this.btn_reportkontrolkntrl = new System.Windows.Forms.Button();
            this.txt_mailkntrl = new System.Windows.Forms.TextBox();
            this.lbl_mailkntrl = new System.Windows.Forms.Label();
            this.lbl_adkntrl = new System.Windows.Forms.Label();
            this.txt_adkntrl = new System.Windows.Forms.TextBox();
            this.pnl_reportgonder.SuspendLayout();
            this.pnl_acilis.SuspendLayout();
            this.pnl_reportkontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(84, 12);
            this.txt_ad.MaxLength = 50;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(166, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(12, 15);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(20, 13);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(12, 41);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(25, 13);
            this.lbl_mail.TabIndex = 2;
            this.lbl_mail.Text = "mail";
            // 
            // lbl_konu
            // 
            this.lbl_konu.AutoSize = true;
            this.lbl_konu.Location = new System.Drawing.Point(12, 67);
            this.lbl_konu.Name = "lbl_konu";
            this.lbl_konu.Size = new System.Drawing.Size(31, 13);
            this.lbl_konu.TabIndex = 3;
            this.lbl_konu.Text = "konu";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(84, 38);
            this.txt_mail.MaxLength = 50;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(166, 20);
            this.txt_mail.TabIndex = 1;
            // 
            // txt_konu
            // 
            this.txt_konu.Location = new System.Drawing.Point(84, 64);
            this.txt_konu.MaxLength = 50;
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.Size = new System.Drawing.Size(166, 20);
            this.txt_konu.TabIndex = 2;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(12, 107);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(34, 13);
            this.lbl_message.TabIndex = 6;
            this.lbl_message.Text = "mesaj";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(12, 123);
            this.txt_message.MaxLength = 300;
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(238, 140);
            this.txt_message.TabIndex = 3;
            this.txt_message.TextChanged += new System.EventHandler(this.txt_message_TextChanged);
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(12, 269);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(238, 32);
            this.btn_gonder.TabIndex = 4;
            this.btn_gonder.Text = "gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // lbl_kalan
            // 
            this.lbl_kalan.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_kalan.Location = new System.Drawing.Point(150, 102);
            this.lbl_kalan.Name = "lbl_kalan";
            this.lbl_kalan.Size = new System.Drawing.Size(100, 18);
            this.lbl_kalan.TabIndex = 10;
            this.lbl_kalan.Text = "0/300";
            this.lbl_kalan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_copyright.Location = new System.Drawing.Point(100, 143);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(150, 17);
            this.lbl_copyright.TabIndex = 11;
            this.lbl_copyright.Text = "copy";
            this.lbl_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_reportgonder
            // 
            this.pnl_reportgonder.Controls.Add(this.txt_ad);
            this.pnl_reportgonder.Controls.Add(this.lbl_ad);
            this.pnl_reportgonder.Controls.Add(this.lbl_mail);
            this.pnl_reportgonder.Controls.Add(this.lbl_konu);
            this.pnl_reportgonder.Controls.Add(this.txt_mail);
            this.pnl_reportgonder.Controls.Add(this.txt_konu);
            this.pnl_reportgonder.Controls.Add(this.lbl_message);
            this.pnl_reportgonder.Controls.Add(this.txt_message);
            this.pnl_reportgonder.Controls.Add(this.btn_gonder);
            this.pnl_reportgonder.Controls.Add(this.lbl_kalan);
            this.pnl_reportgonder.Location = new System.Drawing.Point(0, 0);
            this.pnl_reportgonder.Name = "pnl_reportgonder";
            this.pnl_reportgonder.Size = new System.Drawing.Size(260, 145);
            this.pnl_reportgonder.TabIndex = 12;
            // 
            // pnl_acilis
            // 
            this.pnl_acilis.Controls.Add(this.btn_reportkontrol);
            this.pnl_acilis.Controls.Add(this.btn_reportgonder);
            this.pnl_acilis.Location = new System.Drawing.Point(0, 0);
            this.pnl_acilis.Name = "pnl_acilis";
            this.pnl_acilis.Size = new System.Drawing.Size(260, 145);
            this.pnl_acilis.TabIndex = 13;
            // 
            // btn_reportkontrol
            // 
            this.btn_reportkontrol.Location = new System.Drawing.Point(55, 72);
            this.btn_reportkontrol.Name = "btn_reportkontrol";
            this.btn_reportkontrol.Size = new System.Drawing.Size(150, 60);
            this.btn_reportkontrol.TabIndex = 1;
            this.btn_reportkontrol.TabStop = false;
            this.btn_reportkontrol.Text = "button1";
            this.btn_reportkontrol.UseVisualStyleBackColor = true;
            this.btn_reportkontrol.Click += new System.EventHandler(this.btn_reportkontrol_Click);
            // 
            // btn_reportgonder
            // 
            this.btn_reportgonder.Location = new System.Drawing.Point(55, 8);
            this.btn_reportgonder.Name = "btn_reportgonder";
            this.btn_reportgonder.Size = new System.Drawing.Size(150, 60);
            this.btn_reportgonder.TabIndex = 0;
            this.btn_reportgonder.TabStop = false;
            this.btn_reportgonder.Text = "button1";
            this.btn_reportgonder.UseVisualStyleBackColor = true;
            this.btn_reportgonder.Click += new System.EventHandler(this.btn_reportgonder_Click);
            // 
            // tmr_paneldegis
            // 
            this.tmr_paneldegis.Interval = 10;
            this.tmr_paneldegis.Tick += new System.EventHandler(this.tmr_paneldegis_Tick);
            // 
            // btn_geri
            // 
            this.btn_geri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_geri.Enabled = false;
            this.btn_geri.Location = new System.Drawing.Point(0, 143);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(40, 23);
            this.btn_geri.TabIndex = 5;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_reportkontrol
            // 
            this.pnl_reportkontrol.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_reportkontrol.Controls.Add(this.lbl_reportidkntrl);
            this.pnl_reportkontrol.Controls.Add(this.txt_reportidkntrl);
            this.pnl_reportkontrol.Controls.Add(this.btn_reportkontrolkntrl);
            this.pnl_reportkontrol.Controls.Add(this.txt_mailkntrl);
            this.pnl_reportkontrol.Controls.Add(this.lbl_mailkntrl);
            this.pnl_reportkontrol.Controls.Add(this.lbl_adkntrl);
            this.pnl_reportkontrol.Controls.Add(this.txt_adkntrl);
            this.pnl_reportkontrol.Location = new System.Drawing.Point(0, 0);
            this.pnl_reportkontrol.Name = "pnl_reportkontrol";
            this.pnl_reportkontrol.Size = new System.Drawing.Size(260, 142);
            this.pnl_reportkontrol.TabIndex = 2;
            // 
            // lbl_reportidkntrl
            // 
            this.lbl_reportidkntrl.AutoSize = true;
            this.lbl_reportidkntrl.Location = new System.Drawing.Point(12, 15);
            this.lbl_reportidkntrl.Name = "lbl_reportidkntrl";
            this.lbl_reportidkntrl.Size = new System.Drawing.Size(26, 13);
            this.lbl_reportidkntrl.TabIndex = 8;
            this.lbl_reportidkntrl.Text = "ticid";
            // 
            // txt_reportidkntrl
            // 
            this.txt_reportidkntrl.Location = new System.Drawing.Point(84, 12);
            this.txt_reportidkntrl.Name = "txt_reportidkntrl";
            this.txt_reportidkntrl.Size = new System.Drawing.Size(166, 20);
            this.txt_reportidkntrl.TabIndex = 1;
            // 
            // btn_reportkontrolkntrl
            // 
            this.btn_reportkontrolkntrl.Location = new System.Drawing.Point(12, 98);
            this.btn_reportkontrolkntrl.Name = "btn_reportkontrolkntrl";
            this.btn_reportkontrolkntrl.Size = new System.Drawing.Size(238, 36);
            this.btn_reportkontrolkntrl.TabIndex = 4;
            this.btn_reportkontrolkntrl.Text = "button1";
            this.btn_reportkontrolkntrl.UseVisualStyleBackColor = true;
            this.btn_reportkontrolkntrl.Click += new System.EventHandler(this.btn_reportkontrolkntrl_Click);
            // 
            // txt_mailkntrl
            // 
            this.txt_mailkntrl.Location = new System.Drawing.Point(84, 64);
            this.txt_mailkntrl.MaxLength = 50;
            this.txt_mailkntrl.Name = "txt_mailkntrl";
            this.txt_mailkntrl.Size = new System.Drawing.Size(166, 20);
            this.txt_mailkntrl.TabIndex = 3;
            // 
            // lbl_mailkntrl
            // 
            this.lbl_mailkntrl.AutoSize = true;
            this.lbl_mailkntrl.Location = new System.Drawing.Point(12, 67);
            this.lbl_mailkntrl.Name = "lbl_mailkntrl";
            this.lbl_mailkntrl.Size = new System.Drawing.Size(25, 13);
            this.lbl_mailkntrl.TabIndex = 3;
            this.lbl_mailkntrl.Text = "mail";
            // 
            // lbl_adkntrl
            // 
            this.lbl_adkntrl.AutoSize = true;
            this.lbl_adkntrl.Location = new System.Drawing.Point(12, 41);
            this.lbl_adkntrl.Name = "lbl_adkntrl";
            this.lbl_adkntrl.Size = new System.Drawing.Size(20, 13);
            this.lbl_adkntrl.TabIndex = 2;
            this.lbl_adkntrl.Text = "Ad";
            // 
            // txt_adkntrl
            // 
            this.txt_adkntrl.Location = new System.Drawing.Point(84, 38);
            this.txt_adkntrl.MaxLength = 50;
            this.txt_adkntrl.Name = "txt_adkntrl";
            this.txt_adkntrl.Size = new System.Drawing.Size(166, 20);
            this.txt_adkntrl.TabIndex = 2;
            // 
            // destekformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 164);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lbl_copyright);
            this.Controls.Add(this.pnl_acilis);
            this.Controls.Add(this.pnl_reportgonder);
            this.Controls.Add(this.pnl_reportkontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "destekformu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.destekformu_FormClosing);
            this.Load += new System.EventHandler(this.destekformu_Load);
            this.LocationChanged += new System.EventHandler(this.destekformu_LocationChanged);
            this.pnl_reportgonder.ResumeLayout(false);
            this.pnl_reportgonder.PerformLayout();
            this.pnl_acilis.ResumeLayout(false);
            this.pnl_reportkontrol.ResumeLayout(false);
            this.pnl_reportkontrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_konu;
        private System.Windows.Forms.TextBox txt_konu;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label lbl_kalan;
        private System.Windows.Forms.Label lbl_copyright;
        private System.Windows.Forms.Panel pnl_reportgonder;
        private System.Windows.Forms.Panel pnl_acilis;
        private System.Windows.Forms.Timer tmr_paneldegis;
        private System.Windows.Forms.Button btn_reportgonder;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_reportkontrol;
        private System.Windows.Forms.Panel pnl_reportkontrol;
        private System.Windows.Forms.TextBox txt_adkntrl;
        private System.Windows.Forms.Label lbl_adkntrl;
        private System.Windows.Forms.Label lbl_mailkntrl;
        private System.Windows.Forms.TextBox txt_mailkntrl;
        private System.Windows.Forms.TextBox txt_reportidkntrl;
        private System.Windows.Forms.Button btn_reportkontrolkntrl;
        private System.Windows.Forms.Label lbl_reportidkntrl;
        public System.Windows.Forms.TextBox txt_ad;
        public System.Windows.Forms.TextBox txt_mail;
    }
}
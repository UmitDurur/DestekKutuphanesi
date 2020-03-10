namespace destekkutuphane
{
    partial class raporsablon
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
            this.txt_reportid = new System.Windows.Forms.TextBox();
            this.lbl_reportid = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_konu = new System.Windows.Forms.Label();
            this.txt_konu = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.lbl_reportstatus = new System.Windows.Forms.Label();
            this.lbl_statussonuc = new System.Windows.Forms.Label();
            this.seperator = new System.Windows.Forms.Label();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_reportid
            // 
            this.txt_reportid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_reportid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_reportid.Enabled = false;
            this.txt_reportid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_reportid.Location = new System.Drawing.Point(101, 12);
            this.txt_reportid.Name = "txt_reportid";
            this.txt_reportid.Size = new System.Drawing.Size(166, 20);
            this.txt_reportid.TabIndex = 0;
            // 
            // lbl_reportid
            // 
            this.lbl_reportid.AutoSize = true;
            this.lbl_reportid.Location = new System.Drawing.Point(12, 15);
            this.lbl_reportid.Name = "lbl_reportid";
            this.lbl_reportid.Size = new System.Drawing.Size(42, 13);
            this.lbl_reportid.TabIndex = 1;
            this.lbl_reportid.Text = "reportid";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(12, 41);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(24, 13);
            this.lbl_ad.TabIndex = 3;
            this.lbl_ad.Text = "isim";
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_ad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_ad.Enabled = false;
            this.txt_ad.Location = new System.Drawing.Point(101, 38);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(166, 20);
            this.txt_ad.TabIndex = 2;
            // 
            // lbl_konu
            // 
            this.lbl_konu.AutoSize = true;
            this.lbl_konu.Location = new System.Drawing.Point(12, 93);
            this.lbl_konu.Name = "lbl_konu";
            this.lbl_konu.Size = new System.Drawing.Size(31, 13);
            this.lbl_konu.TabIndex = 7;
            this.lbl_konu.Text = "konu";
            // 
            // txt_konu
            // 
            this.txt_konu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_konu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_konu.Enabled = false;
            this.txt_konu.Location = new System.Drawing.Point(101, 90);
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.Size = new System.Drawing.Size(166, 20);
            this.txt_konu.TabIndex = 6;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(12, 67);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(25, 13);
            this.lbl_mail.TabIndex = 5;
            this.lbl_mail.Text = "mail";
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_mail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_mail.Enabled = false;
            this.txt_mail.Location = new System.Drawing.Point(101, 64);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(166, 20);
            this.txt_mail.TabIndex = 4;
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_message.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_message.Enabled = false;
            this.txt_message.Location = new System.Drawing.Point(9, 16);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(255, 105);
            this.txt_message.TabIndex = 8;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(9, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(34, 13);
            this.lbl_message.TabIndex = 9;
            this.lbl_message.Text = "mesaj";
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.seperator);
            this.pnl_footer.Controls.Add(this.lbl_message);
            this.pnl_footer.Controls.Add(this.txt_message);
            this.pnl_footer.Location = new System.Drawing.Point(3, 116);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(275, 135);
            this.pnl_footer.TabIndex = 10;
            // 
            // lbl_reportstatus
            // 
            this.lbl_reportstatus.AutoSize = true;
            this.lbl_reportstatus.Location = new System.Drawing.Point(12, 119);
            this.lbl_reportstatus.Name = "lbl_reportstatus";
            this.lbl_reportstatus.Size = new System.Drawing.Size(35, 13);
            this.lbl_reportstatus.TabIndex = 11;
            this.lbl_reportstatus.Text = "label1";
            this.lbl_reportstatus.Visible = false;
            // 
            // lbl_statussonuc
            // 
            this.lbl_statussonuc.AutoSize = true;
            this.lbl_statussonuc.Location = new System.Drawing.Point(101, 119);
            this.lbl_statussonuc.Name = "lbl_statussonuc";
            this.lbl_statussonuc.Size = new System.Drawing.Size(35, 13);
            this.lbl_statussonuc.TabIndex = 12;
            this.lbl_statussonuc.Text = "label1";
            this.lbl_statussonuc.Visible = false;
            // 
            // seperator
            // 
            this.seperator.AutoSize = true;
            this.seperator.Location = new System.Drawing.Point(0, 118);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(274, 13);
            this.seperator.TabIndex = 10;
            this.seperator.Text = "---------------------------------------------------------------------------------" +
    "--------";
            // 
            // raporsablon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 250);
            this.Controls.Add(this.lbl_statussonuc);
            this.Controls.Add(this.lbl_reportstatus);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.lbl_konu);
            this.Controls.Add(this.txt_konu);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_reportid);
            this.Controls.Add(this.txt_reportid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "raporsablon";
            this.Text = "raporsablon";
            this.Load += new System.EventHandler(this.raporsablon_Load);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_reportid;
        private System.Windows.Forms.Label lbl_reportid;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_konu;
        private System.Windows.Forms.TextBox txt_konu;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Label lbl_reportstatus;
        private System.Windows.Forms.Label lbl_statussonuc;
        private System.Windows.Forms.Label seperator;
    }
}
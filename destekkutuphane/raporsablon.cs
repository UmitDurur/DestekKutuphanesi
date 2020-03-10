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

namespace destekkutuphane
{
    public partial class raporsablon : Form
    {
        public raporsablon(string metin)
        {
            InitializeComponent();
            tammetin = metin;
        }

        MySqlConnection baglan;
        MySqlCommand kmt;
        MySqlDataReader dr;
        destekformu ana = new destekformu();
        string tammetin;
        int reportid;

        private void language()
        {
            foreach (Control c in this.Controls) {
                if (c is Label)
                    c.Text = ana.languageconvert(c.Name);
                if (c is Panel)
                    foreach (Control c2 in c.Controls)
                        if (c2 is Label)
                            c2.Text = ana.languageconvert(c2.Name);
            }
        }

        private bool baglantiac()
        {
            DialogResult hatasonuc = DialogResult.Retry;
            while (hatasonuc == DialogResult.Retry && baglan.State.ToString() != "Open")
                try
                {
                    baglan.Open();
                }
                catch { hatasonuc = MessageBox.Show(ana.languageconvert("serverconnerror"), ana.languageconvert("error"), MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk); if (hatasonuc == DialogResult.Cancel) break; }
            if (baglan.State.ToString() == "Open")
                return true;
            else return false;
        }

        private void raporsablon_Load(object sender, EventArgs e)
        {
            language();
            string[] gecici = tammetin.Split('^');

            txt_reportid.Text = gecici[0];
                txt_ad.Text = gecici[2];
                txt_mail.Text = gecici[3];
                txt_konu.Text = gecici[4];
                txt_message.Text = gecici[5];
           /*
                if (!(txt_ad.Text == "Admin"|| txt_ad.Text=="Yönetici")){
                    seperator.Location = new Point(seperator.Location.X,seperator.Location.Y+23);
                    lbl_reportstatus.Show(); lbl_statussonuc.Show();
                    pnl_footer.Location = new Point(pnl_footer.Location.X,pnl_footer.Location.Y+23);
                    this.Size = new Size(this.Size.Width, this.Size.Height + 23);
                    if (Convert.ToInt32(dr["answerID"].ToString()) == 0)
                    {
                        lbl_statussonuc.Text = ana.languageconvert("notanswered");lbl_statussonuc.ForeColor = Color.Red;
                            }
                    else {
                        lbl_statussonuc.Text = ana.languageconvert("answered");lbl_statussonuc.ForeColor = Color.Green;
                    }
                }    
            else { MessageBox.Show(ana.languageconvert("unknownreport"), ana.languageconvert("error")); }*/
        }
    }
}

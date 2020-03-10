using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;

namespace destekkutuphane
{
    public partial class raporcevap : Form
    {
        public raporcevap(string nesne)
        {
            InitializeComponent();
            tammetin = nesne;
        }


        MySqlConnection baglan;
        MySqlCommand kmt;
        MySqlDataReader dr;
        destekformu ana = new destekformu();

        string tammetin;

        int reportid;


        public bool baglantiac()
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

        int sayac = 0;

        private void raporcevap_Load(object sender, EventArgs e)
        {
            this.Text = ana.languageconvert("report");
            this.Size = new Size(this.Width, this.Height + 23);

            try
            {
                while (!string.IsNullOrWhiteSpace(tammetin))
                {
                    raporsablon raporsbln = new raporsablon(tammetin);
                    raporsbln.TopLevel = false;
                    raporsbln.Name = "rapor" + sayac.ToString();
                    sayac++;
                    pnl_raporsonuc.Controls.Add(raporsbln);
                    raporsbln.Show();
                    raporsbln.Dock = DockStyle.Top;
                    raporsbln.BringToFront();

                    string[] gecici = tammetin.Split('^');
                    WebClient w = new WebClient();
                    System.Collections.Specialized.NameValueCollection reqparm = new System.Collections.Specialized.NameValueCollection();
                    reqparm.Add("reportid", gecici[1].ToString()); reqparm.Add("sender", "rogram");
                    byte[] b = w.UploadValues("http://api.umitdrr.com/Destek/v1/destekcek.php", "POST", reqparm);
                    Encoding TR = Encoding.GetEncoding("ISO-8859-9");
                    tammetin = TR.GetString(b);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /*
        if (dr.Read())
            reportid = Convert.ToInt32(dr["answerid"].ToString());
        else reportid = 0;
        if (sayac == 2)
            this.Size = new Size(this.Width + 12, this.Height);
        dr.Close();
    } while (reportid != 0);*/
    }
}

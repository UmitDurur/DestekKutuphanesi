using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net;

namespace destekkutuphane
{
    public partial class destekformu : Form
    {
        public destekformu()
        {
            InitializeComponent();
        }

        MySqlConnection baglan;
        MySqlCommand kmt;
        MySqlDataReader dr;
        raporcevap rpr=null;

        string panelad = "acilis";
        string sqlconnection;
        bool gerikontrol = false;



        CultureInfo ci;
        void language()
        {
            ci = new CultureInfo(Destek.Language);
            Assembly a = Assembly.Load("destekkutuphane");
            ResourceManager rm = new ResourceManager("destekkutuphane.Lang.langres", a);
            this.Text = rm.GetString("support", ci);
            foreach (Control c in this.Controls) {
                if ((c is Label && c.Name != "lbl_kalan") || c is Button)
                    c.Text = rm.GetString(c.Name, ci);
                if (c is Panel)
                {
                    if (c.Name != "pnl_reportkontrol")
                        foreach (Control c2 in c.Controls)
                        {
                            if ((c2 is Label && c2.Name != "lbl_kalan") || c2 is Button)
                                c2.Text = rm.GetString(c2.Name, ci);

                        }
                    else foreach (Control c2 in c.Controls)
                            if (c2 is Label)
                                c2.Text = rm.GetString(c2.Name.Substring(0, c2.Name.Length - 5), ci);
                            else if (c2 is Button)
                                c2.Text = rm.GetString(c2.Name, ci);
                }
            }
        }
        

        private void destekformu_Load(object sender, EventArgs e)
        {
            language();
            pnl_reportgonder.Hide();
            pnl_reportkontrol.Hide();
        }

        public string languageconvert(string tmp_giris)
        {
            ci = new CultureInfo(Destek.Language);
            Assembly a = Assembly.Load("destekkutuphane");
            ResourceManager rm = new ResourceManager("destekkutuphane.Lang.langres", a);
            return rm.GetString(tmp_giris, ci);
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ad.Text) || string.IsNullOrWhiteSpace(txt_mail.Text) || string.IsNullOrWhiteSpace(txt_konu.Text) || string.IsNullOrWhiteSpace(txt_message.Text))
                    throw new Exception(languageconvert("excnull"));

                if (txt_ad.Text.ToLower().Contains("admin") || txt_ad.Text.ToLower().Contains("yönetici") || txt_ad.Text.ToLower().Contains("yonetici"))
                    throw new Exception(languageconvert("invalidname") + " " + txt_ad.Text);
                if (!mailkontrolet("gonder"))
                    throw new Exception(languageconvert("invalidmail"));
                if (baglan.State.ToString() != "Open")
                //kmt = new MySqlCommand("CALL reportgonder(@appnamespace,@answerid,@sendername,@sendermail,@title,@message,@appcurrentversion)", baglan);
                kmt = new MySqlCommand("CALL reportgonder(@sendername,@sendermail,@title,@message,@appnamespace,@appcurrentversion)", baglan);
                kmt.Parameters.AddWithValue("@appnamespace", GenelBilgiler.AppNamespace);
                kmt.Parameters.AddWithValue("@answerid", 0);
                kmt.Parameters.AddWithValue("@sendername", txt_ad.Text);
                kmt.Parameters.AddWithValue("@sendermail", txt_mail.Text);
                kmt.Parameters.AddWithValue("@title", txt_konu.Text);
                kmt.Parameters.AddWithValue("@message", txt_message.Text);
                kmt.Parameters.AddWithValue("@appcurrentversion", GenelBilgiler.AppVersion);
                dr = kmt.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(languageconvert("reportsuccess") + " " + dr[0].ToString());
                    foreach (Control c in pnl_reportgonder.Controls)
                        if (c is TextBox)
                            c.Text = null;
                }
                else MessageBox.Show(languageconvert("operationfail"), languageconvert("error"));

            }
            catch (Exception exc) { MessageBox.Show(exc.Message, languageconvert("error")); foreach (Control c in pnl_reportgonder.Controls) { if (c is TextBox && string.IsNullOrWhiteSpace(c.Text)) { c.Focus(); break; } } }
            finally { baglan.Close(); if (dr != null) dr.Close(); }
        }

        private void txt_message_TextChanged(object sender, EventArgs e)
        {
            lbl_kalan.Text = txt_message.TextLength.ToString() + " /300";
        }
        private void btn_reportgonder_Click(object sender, EventArgs e)
        {
            btn_reportgonder.Enabled = false;
            btn_reportkontrol.Enabled = false;

            pnl_reportgonder.Width = 0;
            panelad = "reportgonder";
            gerikontrol = true;
            pnl_reportgonder.Show();
            aciliyor = true;
            pnl_reportgonder.BringToFront();
            tmr_paneldegis.Start();
            this.AcceptButton = btn_gonder;
            foreach (Control c in pnl_acilis.Controls)
                if (c is TextBox || c is Button)
                    c.TabStop = false;
            foreach (Control c in pnl_reportgonder.Controls)
                if (c is TextBox || c is Button)
                    c.TabStop = true;
            this.ActiveControl = null;
        }

        bool aciliyor = true;
        private void tmr_paneldegis_Tick(object sender, EventArgs e)
        {
            if (panelad == "reportgonder")
                if (aciliyor)
                {
                    if (pnl_reportgonder.Width < this.Width)
                    {
                        pnl_reportgonder.Width += 7;
                        if (pnl_reportgonder.Height != 300)
                            if (pnl_reportgonder.Height > 295 && pnl_reportgonder.Height < 300)
                                pnl_reportgonder.Height = 300;
                            else pnl_reportgonder.Height += 4;
                        if (this.Height != 365)
                            if (this.Height > 360 && this.Height < 365) this.Height = 365;
                            else this.Height += 4;
                    }
                    else {
                        tmr_paneldegis.Stop();
                    }
                }
                else {
                    if (pnl_reportgonder.Width > 0)
                    {
                        gerikontrol = false;
                        pnl_reportgonder.Width -= 7;
                        if (pnl_reportgonder.Height != 145)
                            if (pnl_reportgonder.Height > 145 && pnl_reportgonder.Height < 150)
                                pnl_reportgonder.Height = 145;
                            else pnl_reportgonder.Height -= 4;
                        if (this.Height != 207)
                            if (this.Height > 207 && this.Height < 212) this.Height = 207;
                            else this.Height -= 4;
                    }
                    else {
                        tmr_paneldegis.Stop();
                        panelad = "acilis";
                    }
                }
            else if (panelad == "reportkontrol")
            {
                if (aciliyor)
                {
                    if (pnl_reportkontrol.Width < this.Width)
                    {

                        pnl_reportkontrol.Width += 7;
                    }
                    else {
                        tmr_paneldegis.Stop();
                    }
                }
                else {
                    if (pnl_reportkontrol.Width > 0)
                    {
                        gerikontrol = false;
                        pnl_reportkontrol.Width -= 7;
                    }
                    else {
                        tmr_paneldegis.Stop();
                        panelad = "acilis";
                    }
                }
            }
            if (gerikontrol == false)
                btn_geri.Enabled = false;
            else btn_geri.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btn_reportgonder.Enabled = true;
            btn_reportkontrol.Enabled = true;
            aciliyor = false;
            this.AcceptButton = null;
            tmr_paneldegis.Start();
            foreach (Control c in pnl_reportgonder.Controls)
                if (c is TextBox || c is Button)
                    c.TabStop = false;
            foreach (Control c in pnl_reportkontrol.Controls)
                if (c is TextBox || c is Button)
                    c.TabStop = false;
            foreach (Control c in pnl_acilis.Controls)
                if (c is TextBox || c is Button)
                    c.TabStop = true;
            this.ActiveControl = null;
        }

        private void btn_reportkontrol_Click(object sender, EventArgs e)
        {
            btn_reportgonder.Enabled = false;
            btn_reportkontrol.Enabled = false;
            pnl_reportkontrol.Width = 0;
            panelad = "reportkontrol";
            pnl_reportkontrol.Show();
            gerikontrol = true;
            aciliyor = true;
            this.AcceptButton = btn_reportkontrolkntrl;
            pnl_reportkontrol.BringToFront();
            tmr_paneldegis.Start();
            foreach (Control c in pnl_acilis.Controls)
                if (c is TextBox || c is Button)
                    c.TabStop = false;
            foreach (Control c in pnl_reportkontrol.Controls)
                if (c is TextBox || c is Button)
                    c.TabStop = true;
            this.ActiveControl = null;

        }

        private void btn_reportkontrolkntrl_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    rpr.Close();
                }
                catch { }
                if (string.IsNullOrWhiteSpace(txt_adkntrl.Text) || string.IsNullOrWhiteSpace(txt_mailkntrl.Text) || string.IsNullOrWhiteSpace(txt_reportidkntrl.Text))
                    throw new Exception(languageconvert("excnull"));
                if (txt_adkntrl.Text.ToLower().Contains("admin") || txt_adkntrl.Text.ToLower().Contains("yönetici") || txt_adkntrl.Text.ToLower().Contains("yonetici"))
                    throw new Exception(languageconvert("invalidname") + " " + txt_adkntrl.Text);
                if (!mailkontrolet("kontrol"))
                    throw new Exception(languageconvert("invalidmail"));
                WebClient w = new WebClient();
                System.Collections.Specialized.NameValueCollection reqparm = new System.Collections.Specialized.NameValueCollection();
                reqparm.Add("reportid", txt_reportidkntrl.Text);
                reqparm.Add("sender", "rogram");
                byte[] b = w.UploadValues("http://api.umitdrr.com/Destek/v1/destekcek.php", "POST", reqparm);
                Encoding TR = Encoding.GetEncoding("ISO-8859-9");
                string a = TR.GetString(b);
                rpr = new raporcevap(a);
                rpr.Show();

            }
            //else MessageBox.Show(languageconvert("unknownreport"), languageconvert("error")); 
            catch (Exception ex) { MessageBox.Show(ex.Message, languageconvert("error")); }
            finally { if (dr != null) dr.Close(); }
        }

        private bool mailkontrolet(string nereden) {
           string bicim = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
   + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
   + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            if (nereden=="kontrol"){
                txt_mailkntrl.Text= txt_mailkntrl.Text.ToLower();
                return Regex.IsMatch(txt_mailkntrl.Text,bicim);
                }
            if (nereden == "gonder")
            {
                txt_mail.Text = txt_mail.Text.ToLower();
                return Regex.IsMatch(txt_mail.Text, bicim);
            }
            return false;
        }

        private void destekformu_LocationChanged(object sender, EventArgs e)
        {
            try
            {
                rpr.Left = this.Right - 10;
                rpr.Top = this.Top;
            }
            catch { }
        }

        private void destekformu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                rpr.Close();
            }
            catch { }


            }
    } 
}

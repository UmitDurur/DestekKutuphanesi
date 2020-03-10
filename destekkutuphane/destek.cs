using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace destekkutuphane
{
    public class Destek
    {


        private static string sendername;
        public static string Sendername { get { return sendername; } set { sendername = value; } }

        private static string sendermail;
        public static string Sendermail { get { return sendermail; } set { sendermail = value; } }

        private static string topic;
        public static string Topic { get { return topic; } set { topic = value; } }

        private static string message;
        public static string Message { get { return message; } set { message = value; } }

        private static string lang;
        public static string Language { get { return lang; } set { lang = value; } }




        public static void Destekform()
        {
            destekformu form = new destekformu();
            form.ShowDialog();

        }

        public static void Destekform(string mailAdresi)
        {
            destekformu form = new destekformu();
            form.txt_mail.Text = mailAdresi;
            form.ShowDialog();

        }

        public static void Destekform(string kullaniciAdi,string mailAdresi)
        {
            destekformu form = new destekformu();
            form.txt_ad.Text = kullaniciAdi;
            form.txt_ad.Enabled = false;
            form.txt_mail.Text = mailAdresi;
            form.txt_mail.Enabled = false;
            form.ShowDialog();
        }
    }
    public static class GenelBilgiler
    {

        public static string AppNamespace { get; set; }

        public static string AppVersion { get; set; }

        public static string AppName { get; set; }

    }
}


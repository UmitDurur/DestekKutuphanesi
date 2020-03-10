using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using destekkutuphane;


namespace destekkutuphanesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var nameSpace = Assembly.GetExecutingAssembly().GetName().Name;
            var version = Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenelBilgiler.AppNamespace = Assembly.GetExecutingAssembly().GetName().Name;
            Destek.Language = "en-GB";
            GenelBilgiler.AppVersion = Properties.Settings.Default.Version;
            Destek.Destekform();
        }
    }
}

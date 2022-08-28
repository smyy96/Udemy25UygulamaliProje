using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dovizOfis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolaralıs.Text = dolaralis;

            string dolarsatis= xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolarsatıs.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroalıs.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosatıs.Text = eurosatis;
        }

        private void btndolaral_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaralıs.Text;
        }

        private void btndolarsat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsatıs.Text;
        }

        private void btneuroal_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroalıs.Text;
        }

        private void btneurosat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosatıs.Text;
        }

        private void btnsat_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(txtmik.Text);
            tutar = kur * miktar;
            txttuts.Text = tutar.ToString();
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(txtmik.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txttuts.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            txtkalan.Text = kalan.ToString();
        }
    }
}

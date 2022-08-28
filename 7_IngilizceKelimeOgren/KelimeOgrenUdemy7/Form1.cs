using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KelimeOgrenUdemy7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sumeyye\Desktop\dbSozluk.accdb");

        Random rast = new Random();

        int sure = 90;
        int kelime = 0;



        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                label7.Text = dr[2].ToString();
                label7.Text = label7.Text.ToLower();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text==label7.Text)
            {
                kelime++;
                label5.Text = kelime.ToString();
                getir();
                textBox2.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label4.Text = sure.ToString();

            if (sure==0)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                timer1.Stop();
            }
        }
    }
}

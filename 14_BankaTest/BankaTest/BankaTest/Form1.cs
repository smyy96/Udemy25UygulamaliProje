using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5HVC58C\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand command = new SqlCommand("select*from TBLKISILER where HESAPNO=@hesapno and SIFRE=@sifre", baglanti);
            command.Parameters.AddWithValue("@hesapno", hesapNoMaskTt.Text);
            command.Parameters.AddWithValue("@sifre", Txtsifre.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm2 = new Form2();
                frm2.hesap = hesapNoMaskTt.Text;
                frm2.Show();
            }
            else
                MessageBox.Show("Hatalı giriş yaptınız.");
            
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}

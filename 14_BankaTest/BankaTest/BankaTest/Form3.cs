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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5HVC58C\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand command = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@ad,@soyad,@tc,@telefon,@hesapno,@sifre)",baglanti);

            command.Parameters.AddWithValue("@ad", Txtad.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@tc", maskedTC.Text);
            command.Parameters.AddWithValue("@telefon", maskedTelefon.Text);
            command.Parameters.AddWithValue("@hesapno", MaskedHesapNo.Text);
            command.Parameters.AddWithValue("@sifre", txtSifre.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler sisteme kaydedildi.");

            baglanti.Open();
            SqlCommand command2 = new SqlCommand("insert into TBLHESAP (HESAPNO,BAKIYE) values (@hesapno,@bakiye)", baglanti);
            command2.Parameters.AddWithValue("@hesapno", MaskedHesapNo.Text);
            command2.Parameters.AddWithValue("@bakiye", 0);
            command2.ExecuteNonQuery();
            baglanti.Close();


            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }

                if (item is MaskedTextBox)
                {
                    MaskedTextBox tbox = (MaskedTextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void btnHesapNo_Click(object sender, EventArgs e)
        {
            Random rst = new Random();
            int sayi = rst.Next(100000, 1000000);
            MaskedHesapNo.Text = sayi.ToString();
            while (true)
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("select*from TBLKISILER where HESAPNO=@hesapno", baglanti);
                command.Parameters.AddWithValue("@hesapno", MaskedHesapNo.Text);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    sayi = rst.Next(100000, 1000000);
                    MaskedHesapNo.Text = sayi.ToString();
                    MessageBox.Show("Hesap numarası güncelleştirildi.");
                }
                else
                {
                    baglanti.Close();
                    break;
                                        
                }
                baglanti.Close();
            }
            
        }
    }
}

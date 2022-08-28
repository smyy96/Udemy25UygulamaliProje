using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string hesap;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5HVC58C\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Gönderilenler
            baglanti.Open();
            SqlCommand command = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@bakiye where HESAPNO=@hesapno",baglanti);
            command.Parameters.AddWithValue("@hesapno", hesapNoMaskTt.Text);
            command.Parameters.AddWithValue("@bakiye", decimal.Parse(Txttutar.Text));
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Havale işlemi gerçekleştirildi.");


            //Silinenler
            baglanti.Open();
            SqlCommand command2 = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE-@bakiye2 where HESAPNO=@hesapno2", baglanti);
            command2.Parameters.AddWithValue("@hesapno2", hesap);
            command2.Parameters.AddWithValue("@bakiye2", decimal.Parse(Txttutar.Text));
            command2.ExecuteNonQuery();
            baglanti.Close();

            //Hareketler
            baglanti.Open();
            SqlCommand command3 = new SqlCommand("insert into TBLHAREKET (GONDEREN,ALICI,TUTAR) values (@gonderen,@alici,@tutar)", baglanti);
            command3.Parameters.AddWithValue("@gonderen", hesap);
            command3.Parameters.AddWithValue("@tutar", decimal.Parse(Txttutar.Text));
            command3.Parameters.AddWithValue("@alici", hesapNoMaskTt.Text);
            command3.ExecuteNonQuery();
            baglanti.Close();



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapno.Text = hesap;
            baglanti.Open();
            SqlCommand command = new SqlCommand("select*from TBLKISILER where HESAPNO=@hesapno", baglanti);
            command.Parameters.AddWithValue("@hesapno",hesap);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                lblAd.Text = dr[1]+" "+dr[2];
                lblTC.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hareketler hareketler = new Hareketler();
            hareketler.hesap = hesap;
            hareketler.Show();
        }
    }
}

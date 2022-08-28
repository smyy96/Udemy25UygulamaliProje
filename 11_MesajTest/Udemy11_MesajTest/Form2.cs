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

namespace Udemy11_MesajTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5HVC58C\SQLEXPRESS;Initial Catalog=Udemy10_TestDB;Integrated Security=True");

        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select MesajId, (Ad+' '+Soyad) as Gonderen, Baslık,Icerik from TBLICERIK inner join TBLKISILER on TBLICERIK.Gonderen=TBLKISILER.Numara where Alıcı=" + numara, baglanti);
           // Select MESAJID, (AD + ' ' + SOYAD) AS GONDEREN, BASLIK, ICERIK From TBLMESAJLAR inner join TBLKISILER on TBLMESAJLAR.GONDEREN = TBLKISILER.NUMARA Where ALICI = " + numara, baglanti
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select MesajId, (Ad+' '+Soyad) as Alıcı, Baslık,Icerik from TBLICERIK inner join TBLKISILER on TBLICERIK.Gonderen=TBLKISILER.Numara where Gonderen=" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            gelenkutusu();

            gidenkutusu();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Ad,Soyad from TBLKISILER where Numara=" + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLICERIK (Gonderen,Alıcı,Baslık,Icerik) values (@gonderen,@alıcı,@baslık,@icerik)", baglanti);
            komut.Parameters.AddWithValue("@gonderen", numara);
            komut.Parameters.AddWithValue("@alıcı", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@baslık", textBox1.Text);
            komut.Parameters.AddWithValue("@icerik", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajın gitti.");
            gidenkutusu();

        }
    }
}

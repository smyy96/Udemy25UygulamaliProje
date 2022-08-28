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

namespace Film_Arsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5HVC58C\SQLEXPRESS;Initial Catalog=DBFilmArsivi;Integrated Security=True");
        
        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLFilmler",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFilmler (AD,Kategori,Link) values(@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            komut.Parameters.AddWithValue("@P2", textBox2.Text);
            komut.Parameters.AddWithValue("@P3", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Listenize Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje smyy tarafından yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

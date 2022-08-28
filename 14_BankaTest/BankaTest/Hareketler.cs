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

namespace BankaTest
{
    public partial class Hareketler : Form
    {
        public Hareketler()
        {
            InitializeComponent();
        }
        public string hesap;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5HVC58C\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void Hareketler_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand command = new SqlCommand("Select TBL1.AD+' '+TBL1.SOYAD as 'GONDEREN',TBL2.AD+' '+TBL2.SOYAD as 'ALICI',TUTAR From TBLHAREKET inner join TBLKISILER as TBL2 on TBLHAREKET.ALICI= TBL2.HESAPNO inner join TBLKISILER as TBL1 on TBLHAREKET.GONDEREN= TBL1.HESAPNO", baglanti);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();            
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }
    }
}

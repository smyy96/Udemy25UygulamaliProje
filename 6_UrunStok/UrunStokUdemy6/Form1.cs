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

namespace UrunStokUdemy6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUdemy6DataSet1.stokUdemy6' table. You can move, or remove it, as needed.
            this.stokUdemy6TableAdapter1.Fill(this.dBUdemy6DataSet1.stokUdemy6);

        }
    }
}

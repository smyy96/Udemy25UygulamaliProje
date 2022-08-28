
namespace UrunStokUdemy6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBUdemy6DataSet = new UrunStokUdemy6.DBUdemy6DataSet();
            this.stokUdemy6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokUdemy6TableAdapter = new UrunStokUdemy6.DBUdemy6DataSetTableAdapters.stokUdemy6TableAdapter();
            this.dBUdemy6DataSet1 = new UrunStokUdemy6.DBUdemy6DataSet1();
            this.stokUdemy6BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stokUdemy6TableAdapter1 = new UrunStokUdemy6.DBUdemy6DataSet1TableAdapters.stokUdemy6TableAdapter();
            this.ürünAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUdemy6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokUdemy6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUdemy6DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokUdemy6BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünAdıDataGridViewTextBoxColumn,
            this.müşteriDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokUdemy6BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // dBUdemy6DataSet
            // 
            this.dBUdemy6DataSet.DataSetName = "DBUdemy6DataSet";
            this.dBUdemy6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokUdemy6BindingSource
            // 
            this.stokUdemy6BindingSource.DataMember = "stokUdemy6";
            this.stokUdemy6BindingSource.DataSource = this.dBUdemy6DataSet;
            // 
            // stokUdemy6TableAdapter
            // 
            this.stokUdemy6TableAdapter.ClearBeforeFill = true;
            // 
            // dBUdemy6DataSet1
            // 
            this.dBUdemy6DataSet1.DataSetName = "DBUdemy6DataSet1";
            this.dBUdemy6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokUdemy6BindingSource1
            // 
            this.stokUdemy6BindingSource1.DataMember = "stokUdemy6";
            this.stokUdemy6BindingSource1.DataSource = this.dBUdemy6DataSet1;
            // 
            // stokUdemy6TableAdapter1
            // 
            this.stokUdemy6TableAdapter1.ClearBeforeFill = true;
            // 
            // ürünAdıDataGridViewTextBoxColumn
            // 
            this.ürünAdıDataGridViewTextBoxColumn.DataPropertyName = "Ürün Adı";
            this.ürünAdıDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.ürünAdıDataGridViewTextBoxColumn.Name = "ürünAdıDataGridViewTextBoxColumn";
            // 
            // müşteriDataGridViewTextBoxColumn
            // 
            this.müşteriDataGridViewTextBoxColumn.DataPropertyName = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.HeaderText = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.Name = "müşteriDataGridViewTextBoxColumn";
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUdemy6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokUdemy6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUdemy6DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokUdemy6BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBUdemy6DataSet dBUdemy6DataSet;
        private System.Windows.Forms.BindingSource stokUdemy6BindingSource;
        private DBUdemy6DataSetTableAdapters.stokUdemy6TableAdapter stokUdemy6TableAdapter;
        private DBUdemy6DataSet1 dBUdemy6DataSet1;
        private System.Windows.Forms.BindingSource stokUdemy6BindingSource1;
        private DBUdemy6DataSet1TableAdapters.stokUdemy6TableAdapter stokUdemy6TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
    }
}


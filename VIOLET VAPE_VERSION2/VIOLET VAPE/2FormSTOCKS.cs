using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VIOLET_VAPE
{
    public partial class FormSALES : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\VIOLET.accdb");
        OleDbCommand cm = new OleDbCommand();
        OleDbDataReader dr;
        string _code, _descr, _cate, _stocks;

        public FormSALES()
        {
            InitializeComponent();
            cn.Open();
        }

        private void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cm = new OleDbCommand("Select * from Inventory", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(2), dr.GetValue(3), dr.GetValue(5));
            }
            dr.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtCODE.Text = _code;
            txtNAME.Text = _descr;
            txtCAT.Text = _cate;
            txtSTOCK.Text = _stocks;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _code = dataGridView1[0, i].Value.ToString();
            _descr = dataGridView1[1, i].Value.ToString();
            _cate = dataGridView1[2, i].Value.ToString();
            _stocks = dataGridView1[3, i].Value.ToString();
        }

        private void FormSALES_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void btnSRCH_Click(object sender, EventArgs e)
        {
            cm = new OleDbCommand("Select * from Inventory where Description like '" + txtSRCH.Text + "%'", cn);
            dr = cm.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(2), dr.GetValue(3), dr.GetValue(5));
            }
            dr.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSTOCK.Text) && !string.IsNullOrEmpty(txtADD.Text))
               txtDONE.Text = (Convert.ToDouble(txtSTOCK.Text)) + (Convert.ToDouble(txtADD.Text)).ToString();
            {
                cm = new OleDbCommand("update Inventory set ItemCode='" + txtCODE.Text + "', Description='" + txtNAME.Text + "', Category='" + txtCAT.Text + "', Stocks='" + txtDONE.Text + "' where ItemCode like '" + _code + "'", cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record succesfully updated.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadRecords();
            }
        }

        private void Clear()
        {
            txtCODE.Clear();
            txtNAME.Clear();
            txtCAT.Clear();
            txtSTOCK.Clear();
            btnADD.Enabled = false;
        }

    }
}

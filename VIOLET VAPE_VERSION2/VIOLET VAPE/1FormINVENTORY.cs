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
    public partial class FormINVENTORY : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\VIOLET.accdb");
        OleDbCommand cm = new OleDbCommand();
        OleDbDataReader dr;
        string _code, _bname, _descr, _cate, _price, _stocks;
        public FormINVENTORY()
        {
            InitializeComponent();
            cn.Open();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            cm = new OleDbCommand("insert into Inventory values ('" + txtID.Text + "','" + txtBNAME.Text + "','" + txtDESCRIP.Text + "','" + cboCATE.Text + "','" + txtPRICE.Text + "','" + txtSTOCKS.Text + "')", cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record successfully saved.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            LoadRecords();
        }

        private void FormINVENTORY_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cm = new OleDbCommand("Select * from Inventory", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5));
            }
            dr.Close();
        }
        private void Clear()
        {
            txtID.Clear();
            txtBNAME.Clear();
            cboCATE.Text = "";
            txtDESCRIP.Clear();
            txtPRICE.Clear();
            txtSTOCKS.Clear();
            btnADD.Enabled = true;
            btnEDIT.Enabled = false;
            btnDELETE.Enabled = false;

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            cm = new OleDbCommand("update Inventory set ItemCode='" + txtID.Text + "', BrandName='" + txtBNAME.Text + "', Description='" + txtDESCRIP.Text + "', Category='" + cboCATE.Text + "', Price='" + txtPRICE.Text + "', Stocks='" + txtSTOCKS.Text + "' where ItemCode like '" + _code + "'", cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record succesfully updated.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            LoadRecords();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            cm = new OleDbCommand("delete from Inventory  where ItemCode like '" + _code + "'", cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record succesfully deleted.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            LoadRecords();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = _code;
            txtBNAME.Text = _bname;
            txtDESCRIP.Text = _descr;
            cboCATE.Text = _cate;
            txtPRICE.Text = _price;
            txtSTOCKS.Text = _stocks;
            btnADD.Enabled = false;
            btnEDIT.Enabled = true;
            btnDELETE.Enabled = true;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
           _code = dataGridView1[0, i].Value.ToString();
           _bname = dataGridView1[1, i].Value.ToString();
           _descr = dataGridView1[2, i].Value.ToString();
           _cate = dataGridView1[3, i].Value.ToString();
           _price = dataGridView1[4, i].Value.ToString();
           _stocks = dataGridView1[5, i].Value.ToString();
        }



        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            cm = new OleDbCommand("Select * from Inventory where BrandName like '" + txtSEARCH.Text + "%'", cn);
            dr = cm.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5));
            }
            dr.Close();
        }
    }
}

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
    public partial class Form6 : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\VIOLET.accdb");
        OleDbCommand cm = new OleDbCommand();
        OleDbDataReader dr;
        string _id, _lname, _fname, _address, _user, _pass;
        DateTime _bdate;
        public Form6()
        {
            InitializeComponent();
            cn.Open();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {

                cm = new OleDbCommand("insert into tblAccount values ('" + txtID.Text + "','" + txtLNAME.Text + "','" + txtFNAME.Text + "','" + datePICK.Value + "','" + txtADDRESS.Text + "','" + txtUSER.Text + "','" + txtPASS.Text + "')", cn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Record successfully saved.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadRecords();
        }
        private void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cm = new OleDbCommand("Select * from tblAccount", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6));
            }
            dr.Close();
        }
        private void Clear()
        {
            txtADDRESS.Clear();
            txtFNAME.Clear();
            txtLNAME.Clear();
            txtID.Clear();
            txtUSER.Clear();
            txtPASS.Text = "";
            datePICK.Value = DateTime.Now;
            btnSAVE.Enabled = true;
            btnUPDATE.Enabled = false;
            btnDELETE.Enabled = false;

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
       //     cm = new OleDbCommand("update tblAccount set  lname='" + txtLNAME.Text + "'and fname='" + txtFNAME.Text + "'and bdate='" + datePICK.Value + "'and address='" + txtADDRESS.Text + "'and user='" + txtUSER.Text + "'and [pass]='" + txtPASS.Text + "' where acc like '" + _id + "'", cn);
            cm = new OleDbCommand("update tblAccount set acc='" + txtID.Text + "', lname='" + txtLNAME.Text + "', fname='" + txtFNAME.Text + "', bdate='" + datePICK.Value + "', address='" + txtADDRESS.Text + "' where acc like '" + _id + "'", cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record succesfully updated.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            LoadRecords();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtADDRESS.Text = _address;
            txtFNAME.Text = _fname;
            txtLNAME.Text = _lname;
            txtUSER.Text = _user;
            txtPASS.Text = _pass;
            txtID.Text = _id;
            datePICK.Value = _bdate;
            btnSAVE.Enabled = false;
            btnUPDATE.Enabled = true;
            btnDELETE.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _id = dataGridView1[0, i].Value.ToString();
            _lname = dataGridView1[1, i].Value.ToString();
            _fname = dataGridView1[2, i].Value.ToString();
            _bdate = (DateTime)dataGridView1[3, i].Value;
            _address = dataGridView1[4, i].Value.ToString();
            _user = dataGridView1[5, i].Value.ToString();
            _pass = dataGridView1[6, i].Value.ToString();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            cm = new OleDbCommand("delete from tblAccount  where acc like '" + _id + "'", cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record succesfully deleted.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            LoadRecords();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void btnSRCH_Click(object sender, EventArgs e)
        {
            cm = new OleDbCommand("Select * from tblAccount where lname like '" + txtSRCH.Text + "%'", cn);
            dr = cm.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6));
            }
            dr.Close();
        }

    }
}

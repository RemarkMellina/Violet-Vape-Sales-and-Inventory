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
    public partial class FormACCOUNT : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\VIOLET.accdb");
        OleDbCommand cm = new OleDbCommand();
        OleDbDataReader dr;
        string _IDS, _NAME, _USERNAME, _PASSWORD;
        DateTime _DATE;
        public FormACCOUNT()
        {
            InitializeComponent();
            cn.Open();
        }

        private void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cm = new OleDbCommand("Select * from ACCOUNT", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4));
            }
            dr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {


            txtid.Text = _IDS ;
            txtname.Text = _NAME ;
            dtdate.Value = _DATE;
            txtuser.Text = _USERNAME ;
            txtpass.Text = _PASSWORD ;
            btnSAVE.Enabled = false;
            btnDelete.Enabled = true;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _IDS = dataGridView1[0, i].Value.ToString();
            _NAME = dataGridView1[1, i].Value.ToString();
            _DATE = (DateTime)dataGridView1[2, i].Value;
            _USERNAME = dataGridView1[3, i].Value.ToString();
            _PASSWORD = dataGridView1[4, i].Value.ToString();
        }

        private void Clear()
         {
            txtid.Clear();
            txtname.Clear();
            dtdate.Value = DateTime.Now;
            txtuser.Clear();
            txtpass.Clear();
            btnSAVE.Enabled = true;
            btnDelete.Enabled = false;

         }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cm = new OleDbCommand("delete from ACCOUNT  where ID like '" + _IDS + "'", cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record succesfully deleted.", "VIOLET VAPE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            LoadRecords();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormACCOUNT_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }


        private void btnSAVE_Click(object sender, EventArgs e)
        {
            cm = new OleDbCommand("INSERT INTO ACCOUNT values ('" + txtid.Text + "','" + txtname.Text + "','" + dtdate.Value + "','" + txtuser.Text + "','" + txtpass.Text + "')", cn);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record successfully saved.", "VIOLET VAPE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            LoadRecords();
        }


    }
}

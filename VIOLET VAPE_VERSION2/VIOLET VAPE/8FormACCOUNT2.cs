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
    public partial class _8FormACCOUNT2 : Form
    {
        public _8FormACCOUNT2()
        {
            InitializeComponent();
        }

        private void _8FormACCOUNT2_Load(object sender, EventArgs e)
        {

        }

        private void btENTER_Click(object sender, EventArgs e)
        {
             OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\VIOLET.accdb");
            OleDbCommand cmd = new OleDbCommand();
            int i = 0;
            try
            {
                if ((ENTER.Text == string.Empty))
                {
                    MessageBox.Show("FILL UP THE BLANK!");
                }

                cmd = new OleDbCommand("select count(*)from ADMIN where ADMIN ='" + ENTER.Text + "'", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    i = (int)cmd.ExecuteScalar();
                }
                if (i > 0)
                {
                    panel2.Controls.Clear();
                    panel2.Visible = true;
                    Form6 cd1 = new Form6();
                    cd1.Show();
                    cd1.TopLevel = false;
                    cd1.AutoScroll = true;
                    cd1.Dock = DockStyle.Fill;
                    panel2.Controls.Add(cd1);

                }
                else
                {
                    MessageBox.Show("INCORRECT CODE!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

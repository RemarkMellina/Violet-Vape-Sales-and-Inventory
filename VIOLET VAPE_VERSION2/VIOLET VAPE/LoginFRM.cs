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
    public partial class LoginFRM : Form
    {
        public LoginFRM()
        {
            InitializeComponent();
        }

        private void BTNOK_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\VIOLET.accdb");
            OleDbCommand cmd = new OleDbCommand();
            int i = 0;
            try
            {
                if ((TXTUSER.Text == string.Empty)|| TXTPASS.Text == string.Empty)
                {
                    MessageBox.Show("FILL UP THE BLANK!");
                }

                cmd = new OleDbCommand("select count(*)from tblAccount where user ='" + TXTUSER.Text + "' AND pass ='"+ TXTPASS.Text +"'", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    i = (int)cmd.ExecuteScalar();
                }
                if (i > 0)
                {
                    MessageBox.Show("WELCOME TO VIOLET VAPE SHOP SYSTEM");
                    MainFRM mn = new MainFRM();
                    this.Hide();
                    mn.Show();

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

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginFRM_Load(object sender, EventArgs e)
        {

        }

    }
}

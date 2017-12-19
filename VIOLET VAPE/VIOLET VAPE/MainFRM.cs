using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIOLET_VAPE
{
    public partial class MainFRM : Form
    {
        public MainFRM()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            FormINVENTORY cd1 = new FormINVENTORY();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            FormSALES cd1 = new FormSALES();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            Form3 cd1 = new Form3();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            Form4 cd1 = new Form4();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            Form5 cd1 = new Form5();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            Form6 cd1 = new Form6();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            Form7 cd1 = new Form7();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            Form8 cd1 = new Form8();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Visible = true;
            FormACCOUNT cd1 = new FormACCOUNT();
            cd1.Show();
            cd1.TopLevel = false;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            panel3.Controls.Add(cd1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

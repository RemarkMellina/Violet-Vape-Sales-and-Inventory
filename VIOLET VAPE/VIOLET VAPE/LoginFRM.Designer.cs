﻿namespace VIOLET_VAPE
{
    partial class LoginFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFRM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNCANCEL = new System.Windows.Forms.Button();
            this.BTNOK = new System.Windows.Forms.Button();
            this.TXTPASS = new System.Windows.Forms.TextBox();
            this.TXTUSER = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTNCANCEL);
            this.panel1.Controls.Add(this.BTNOK);
            this.panel1.Controls.Add(this.TXTPASS);
            this.panel1.Controls.Add(this.TXTUSER);
            this.panel1.Location = new System.Drawing.Point(222, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 156);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME:";
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.BackColor = System.Drawing.Color.DarkOrchid;
            this.BTNCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNCANCEL.Location = new System.Drawing.Point(275, 105);
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(94, 29);
            this.BTNCANCEL.TabIndex = 3;
            this.BTNCANCEL.Text = "CANCEL";
            this.BTNCANCEL.UseVisualStyleBackColor = false;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // BTNOK
            // 
            this.BTNOK.BackColor = System.Drawing.Color.DarkOrchid;
            this.BTNOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNOK.Location = new System.Drawing.Point(169, 105);
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.Size = new System.Drawing.Size(94, 29);
            this.BTNOK.TabIndex = 2;
            this.BTNOK.Text = "OK";
            this.BTNOK.UseVisualStyleBackColor = false;
            this.BTNOK.Click += new System.EventHandler(this.BTNOK_Click);
            // 
            // TXTPASS
            // 
            this.TXTPASS.Location = new System.Drawing.Point(152, 74);
            this.TXTPASS.Name = "TXTPASS";
            this.TXTPASS.Size = new System.Drawing.Size(226, 20);
            this.TXTPASS.TabIndex = 1;
            this.TXTPASS.UseSystemPasswordChar = true;
            // 
            // TXTUSER
            // 
            this.TXTUSER.Location = new System.Drawing.Point(152, 33);
            this.TXTUSER.Name = "TXTUSER";
            this.TXTUSER.Size = new System.Drawing.Size(226, 20);
            this.TXTUSER.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(9, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 205);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADMINISTRATOR";
            // 
            // LoginFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(658, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginFRM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNCANCEL;
        private System.Windows.Forms.Button BTNOK;
        private System.Windows.Forms.TextBox TXTPASS;
        private System.Windows.Forms.TextBox TXTUSER;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}


namespace VIOLET_VAPE
{
    partial class _8FormACCOUNT2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ENTER = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btENTER = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 421);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.ENTER);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btENTER);
            this.panel1.Location = new System.Drawing.Point(310, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 133);
            this.panel1.TabIndex = 4;
            // 
            // ENTER
            // 
            this.ENTER.Location = new System.Drawing.Point(38, 48);
            this.ENTER.Name = "ENTER";
            this.ENTER.Size = new System.Drawing.Size(323, 20);
            this.ENTER.TabIndex = 5;
            this.ENTER.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OWNER PASSWORD:";
            // 
            // btENTER
            // 
            this.btENTER.Location = new System.Drawing.Point(128, 75);
            this.btENTER.Name = "btENTER";
            this.btENTER.Size = new System.Drawing.Size(155, 35);
            this.btENTER.TabIndex = 3;
            this.btENTER.Text = "ENTER";
            this.btENTER.UseVisualStyleBackColor = true;
            this.btENTER.Click += new System.EventHandler(this.btENTER_Click);
            // 
            // _8FormACCOUNT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 424);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_8FormACCOUNT2";
            this.Text = "_8FormACCOUNT2";
            this.Load += new System.EventHandler(this._8FormACCOUNT2_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ENTER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btENTER;

    }
}
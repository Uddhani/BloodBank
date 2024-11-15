namespace AreaBloodBankManagementSystem
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Apasswordtextb = new System.Windows.Forms.TextBox();
            this.Anametextb = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.Userloginbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 171);
            this.panel1.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(204, 106);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(342, 38);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Donate Blood - Save Life";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Red;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(87, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(614, 135);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Area Blood Bank Management System\r\n\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "New User Registation ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Red;
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(367, 363);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(298, 43);
            this.Loginbtn.TabIndex = 16;
            this.Loginbtn.Text = "Admin Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Apasswordtextb
            // 
            this.Apasswordtextb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apasswordtextb.ForeColor = System.Drawing.Color.Silver;
            this.Apasswordtextb.Location = new System.Drawing.Point(367, 305);
            this.Apasswordtextb.Name = "Apasswordtextb";
            this.Apasswordtextb.Size = new System.Drawing.Size(298, 30);
            this.Apasswordtextb.TabIndex = 14;
            this.Apasswordtextb.Text = "Enter Password";
            this.Apasswordtextb.Click += new System.EventHandler(this.texbox2_Click);
            // 
            // Anametextb
            // 
            this.Anametextb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anametextb.ForeColor = System.Drawing.Color.Silver;
            this.Anametextb.Location = new System.Drawing.Point(367, 237);
            this.Anametextb.Name = "Anametextb";
            this.Anametextb.Size = new System.Drawing.Size(298, 30);
            this.Anametextb.TabIndex = 13;
            this.Anametextb.Text = "Enter Admin Name";
            this.Anametextb.Click += new System.EventHandler(this.texbox1_Click);
            this.Anametextb.TextChanged += new System.EventHandler(this.texbox1_TextChanged);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.Red;
            this.l3.Location = new System.Drawing.Point(123, 305);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(132, 38);
            this.l3.TabIndex = 12;
            this.l3.Text = "Password";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.Red;
            this.l2.Location = new System.Drawing.Point(123, 229);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(180, 38);
            this.l2.TabIndex = 11;
            this.l2.Text = "Admin Name";
            // 
            // Userloginbtn
            // 
            this.Userloginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Userloginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userloginbtn.Location = new System.Drawing.Point(475, 433);
            this.Userloginbtn.Name = "Userloginbtn";
            this.Userloginbtn.Size = new System.Drawing.Size(299, 48);
            this.Userloginbtn.TabIndex = 19;
            this.Userloginbtn.Text = "User Login Here\r\n";
            this.Userloginbtn.UseVisualStyleBackColor = true;
            this.Userloginbtn.Click += new System.EventHandler(this.Userloginbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(812, 493);
            this.Controls.Add(this.Userloginbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Apasswordtextb);
            this.Controls.Add(this.Anametextb);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox Apasswordtextb;
        private System.Windows.Forms.TextBox Anametextb;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Button Userloginbtn;
    }
}
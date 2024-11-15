namespace AreaBloodBankManagementSystem
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodstockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Didtextb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Dagetextb = new System.Windows.Forms.TextBox();
            this.Daddresstextb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dphonetextb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dbirthdaytextb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dnametextb = new System.Windows.Forms.TextBox();
            this.Dgendercmb = new System.Windows.Forms.ComboBox();
            this.Dbloodgroupcmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(-2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 169);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1086, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(443, 73);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(311, 38);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Donate Blood - Save Life";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.bloodStockToolStripMenuItem,
            this.donateToolStripMenuItem1,
            this.bloodstockToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(5, 126);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(117, 39);
            this.donorToolStripMenuItem.Text = "| Donor";
            this.donorToolStripMenuItem.Click += new System.EventHandler(this.donorToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(193, 39);
            this.patientsToolStripMenuItem.Text = "| Donor Views";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(138, 39);
            this.donateToolStripMenuItem.Text = "| Patients";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // bloodStockToolStripMenuItem
            // 
            this.bloodStockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodStockToolStripMenuItem.Name = "bloodStockToolStripMenuItem";
            this.bloodStockToolStripMenuItem.Size = new System.Drawing.Size(214, 39);
            this.bloodStockToolStripMenuItem.Text = "| Patients Views";
            this.bloodStockToolStripMenuItem.Click += new System.EventHandler(this.bloodStockToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem1
            // 
            this.donateToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateToolStripMenuItem1.Name = "donateToolStripMenuItem1";
            this.donateToolStripMenuItem1.Size = new System.Drawing.Size(129, 39);
            this.donateToolStripMenuItem1.Text = "| Donate";
            this.donateToolStripMenuItem1.Click += new System.EventHandler(this.donateToolStripMenuItem1_Click);
            // 
            // bloodstockToolStripMenuItem1
            // 
            this.bloodstockToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodstockToolStripMenuItem1.Name = "bloodstockToolStripMenuItem1";
            this.bloodstockToolStripMenuItem1.Size = new System.Drawing.Size(200, 39);
            this.bloodstockToolStripMenuItem1.Text = "| Blood Report";
            this.bloodstockToolStripMenuItem1.Click += new System.EventHandler(this.bloodstockToolStripMenuItem1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Red;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(415, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(380, 140);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Area Blood Bank Management \r\n                  System\r\n\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Didtextb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.Dagetextb);
            this.panel2.Controls.Add(this.Daddresstextb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Dphonetextb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Dbirthdaytextb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Dnametextb);
            this.panel2.Controls.Add(this.Dgendercmb);
            this.panel2.Controls.Add(this.Dbloodgroupcmb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 573);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Didtextb
            // 
            this.Didtextb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Didtextb.ForeColor = System.Drawing.Color.Silver;
            this.Didtextb.Location = new System.Drawing.Point(199, 36);
            this.Didtextb.Name = "Didtextb";
            this.Didtextb.Size = new System.Drawing.Size(223, 30);
            this.Didtextb.TabIndex = 31;
            this.Didtextb.Text = "Enter Id";
            this.Didtextb.Click += new System.EventHandler(this.Didtextb_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Donor Id -";
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Silver;
            this.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(758, 434);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(177, 85);
            this.Deletebtn.TabIndex = 17;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Silver;
            this.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Addbtn.Location = new System.Drawing.Point(350, 434);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(178, 85);
            this.Addbtn.TabIndex = 15;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Dagetextb
            // 
            this.Dagetextb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dagetextb.ForeColor = System.Drawing.Color.Silver;
            this.Dagetextb.Location = new System.Drawing.Point(199, 245);
            this.Dagetextb.Name = "Dagetextb";
            this.Dagetextb.Size = new System.Drawing.Size(223, 30);
            this.Dagetextb.TabIndex = 10;
            this.Dagetextb.Text = "Enter Age";
            this.Dagetextb.Click += new System.EventHandler(this.Dagetextb_Click);
            this.Dagetextb.TextChanged += new System.EventHandler(this.Dagetextb_TextChanged);
            // 
            // Daddresstextb
            // 
            this.Daddresstextb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daddresstextb.ForeColor = System.Drawing.Color.Silver;
            this.Daddresstextb.Location = new System.Drawing.Point(601, 249);
            this.Daddresstextb.Multiline = true;
            this.Daddresstextb.Name = "Daddresstextb";
            this.Daddresstextb.Size = new System.Drawing.Size(223, 129);
            this.Daddresstextb.TabIndex = 14;
            this.Daddresstextb.Text = "Enter Address";
            this.Daddresstextb.Click += new System.EventHandler(this.Daddresstextb_Click);
            this.Daddresstextb.TextChanged += new System.EventHandler(this.Daddresstextb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Donor Full Name -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address - ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age -";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dphonetextb
            // 
            this.Dphonetextb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dphonetextb.ForeColor = System.Drawing.Color.Silver;
            this.Dphonetextb.Location = new System.Drawing.Point(601, 147);
            this.Dphonetextb.Name = "Dphonetextb";
            this.Dphonetextb.Size = new System.Drawing.Size(223, 30);
            this.Dphonetextb.TabIndex = 12;
            this.Dphonetextb.Text = "Enter Phone Number";
            this.Dphonetextb.Click += new System.EventHandler(this.Dphonetextb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year of Birth -";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Dbirthdaytextb
            // 
            this.Dbirthdaytextb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbirthdaytextb.ForeColor = System.Drawing.Color.Silver;
            this.Dbirthdaytextb.Location = new System.Drawing.Point(601, 36);
            this.Dbirthdaytextb.Name = "Dbirthdaytextb";
            this.Dbirthdaytextb.Size = new System.Drawing.Size(223, 30);
            this.Dbirthdaytextb.TabIndex = 11;
            this.Dbirthdaytextb.Text = "Enter Date of Birth";
            this.Dbirthdaytextb.Click += new System.EventHandler(this.Dbirthdaytextb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone Number -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(871, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender -";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Dnametextb
            // 
            this.Dnametextb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dnametextb.ForeColor = System.Drawing.Color.Silver;
            this.Dnametextb.Location = new System.Drawing.Point(199, 137);
            this.Dnametextb.Name = "Dnametextb";
            this.Dnametextb.Size = new System.Drawing.Size(223, 30);
            this.Dnametextb.TabIndex = 9;
            this.Dnametextb.Text = "Enter Full Name";
            this.Dnametextb.Click += new System.EventHandler(this.Dnametextb_Click);
            this.Dnametextb.TextChanged += new System.EventHandler(this.Dnametextb_TextChanged);
            // 
            // Dgendercmb
            // 
            this.Dgendercmb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgendercmb.ForeColor = System.Drawing.Color.Silver;
            this.Dgendercmb.FormattingEnabled = true;
            this.Dgendercmb.Items.AddRange(new object[] {
            "(None)",
            "Male",
            "Female"});
            this.Dgendercmb.Location = new System.Drawing.Point(1002, 35);
            this.Dgendercmb.Name = "Dgendercmb";
            this.Dgendercmb.Size = new System.Drawing.Size(202, 31);
            this.Dgendercmb.TabIndex = 6;
            this.Dgendercmb.Text = "Select Gender";
            this.Dgendercmb.Click += new System.EventHandler(this.Dgendercmb_Click);
            // 
            // Dbloodgroupcmb
            // 
            this.Dbloodgroupcmb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbloodgroupcmb.ForeColor = System.Drawing.Color.Silver;
            this.Dbloodgroupcmb.FormattingEnabled = true;
            this.Dbloodgroupcmb.Items.AddRange(new object[] {
            "(None)",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.Dbloodgroupcmb.Location = new System.Drawing.Point(1002, 144);
            this.Dbloodgroupcmb.Name = "Dbloodgroupcmb";
            this.Dbloodgroupcmb.Size = new System.Drawing.Size(202, 31);
            this.Dbloodgroupcmb.TabIndex = 8;
            this.Dbloodgroupcmb.Text = "Select Blood Group";
            this.Dbloodgroupcmb.Click += new System.EventHandler(this.Dbloodgroupcmb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(862, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Blood Group -";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1242, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodStockToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox Dagetextb;
        private System.Windows.Forms.TextBox Daddresstextb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dphonetextb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dbirthdaytextb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Dnametextb;
        private System.Windows.Forms.ComboBox Dgendercmb;
        private System.Windows.Forms.ComboBox Dbloodgroupcmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bloodstockToolStripMenuItem1;
        private System.Windows.Forms.TextBox Didtextb;
        private System.Windows.Forms.Label label8;
    }
}
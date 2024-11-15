using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaBloodBankManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void texbox1_Click(object sender, EventArgs e)
        {
            Anametextb.Text = "";
        }

        private void texbox2_Click(object sender, EventArgs e)
        {
            Apasswordtextb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void texbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (Anametextb.Text == "" || Apasswordtextb.Text == "") 
            {
                MessageBox.Show("Enter the Admin name and Password...");
            }
            else if (Anametextb.Text == "Admin" || Apasswordtextb.Text == "123")
            {
                Form4 form = new Form4();
                form.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Enter the Correct Admin name and Password...");
                Anametextb.Text = "";
                Apasswordtextb.Text = "";
            }
        }

        private void Userloginbtn_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
            this.Hide();
        }
    }
}

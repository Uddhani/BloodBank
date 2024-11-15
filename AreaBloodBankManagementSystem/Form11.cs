using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace AreaBloodBankManagementSystem
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        // Connect Sql

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VLCDUKL;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");


        // reset
        private void Reset()
        {

            Unametextb.Text = "";
            Upasswordtextb.Text = "";
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from tb_User where Uname ='"+Unametextb.Text+" ' and Upassword= '"+Upasswordtextb.Text+" '",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Form10 form = new Form10();
                form.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username and password. Try again");
            }
            Con.Close();


           /* if (Unametextb.Text == "" || Upasswordtextb.Text == "")
            {
                MessageBox.Show("Enter the User name and Password...");
            }
            else if (Unametextb.Text == "User" || Upasswordtextb.Text == "123")
            {
                Form10 form = new Form10();
                form.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Enter the Correct User name and Password...");
                Unametextb.Text = "";
                Upasswordtextb.Text = "";
            }*/

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Unametextb_Click(object sender, EventArgs e)
        {
            Unametextb.Text = "";
        }

        private void Upasswordtextb_Click(object sender, EventArgs e)
        {
            Upasswordtextb.Text = "";
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}

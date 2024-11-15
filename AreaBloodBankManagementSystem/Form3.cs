using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AreaBloodBankManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Connect Sql

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VLCDUKL;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        // reset
        private void Reset()
        {
            Uidtextb.Text = "";
            Unametextb.Text = "";
            Uagetextb.Text = "";
            Ubirthdaytextb.Text = "";
            Ugendercmb.SelectedIndex = 0;
            Ubloodgroupcmb.SelectedIndex = 0;
            Uphonetextb.Text = "";
            Uaddresstextb.Text = "";
            Upasswordtextb.Text = "";
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            Unametextb.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Uagetextb.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            Ubirthdaytextb.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            Uaddresstextb.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            Upasswordtextb.Text = "";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            Uphonetextb.Text = "";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            Ugendercmb.SelectedIndex = 0;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            Ubloodgroupcmb.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uidtextb.Text = "";
            Unametextb.Text = "";
            Uagetextb.Text = ""; 
            Ubirthdaytextb.Text = ""; 
            Uaddresstextb.Text = "";
            Upasswordtextb.Text = "";
            Uphonetextb.Text = "";
            Ugendercmb.SelectedItem = 0;
            Ubloodgroupcmb.SelectedItem = 0;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             //Add User Data

            if ( Uidtextb.Text == "" || Unametextb.Text == "" || Uagetextb.Text == "" || Ubirthdaytextb.Text == "" || Ugendercmb.SelectedIndex == -1 || Ubloodgroupcmb.SelectedIndex == -1 || Uphonetextb.Text == "" || Uaddresstextb.Text == "" || Upasswordtextb.Text =="")
            {
                MessageBox.Show("Incomplete Information....");
            }
            else
            {
                try
                {
                    string query = "insert into tb_User values('" + Uidtextb.Text + "','" + Unametextb.Text + "','" + Uagetextb.Text + "','" + Ubirthdaytextb.Text + "','" + Ugendercmb.SelectedItem.ToString() + "','" + Ubloodgroupcmb.SelectedItem.ToString() + "','" + Uphonetextb.Text + "','" + Uaddresstextb.Text + "','"+Upasswordtextb.Text +"')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User data Successfully Added....");
                    Con.Close();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            Uidtextb.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

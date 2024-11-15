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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // Connect Sql

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VLCDUKL;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");


        // reset
        private void Reset()
        {
            Pidtextb.Text = "";
            Pnametextb.Text = "";
            Pagetextb.Text = "";
            Pbirthdaytextb.Text = "";
            Pgendercmb.SelectedIndex = 0;
            Pbloodgroupcmb.SelectedIndex = 0;
            Pphonetextb.Text = "";
            Paddresstextb.Text = "";
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            //Add Patients Data

            if ( Pidtextb.Text == "" || Pnametextb.Text == "" || Pagetextb.Text == "" || Pbirthdaytextb.Text == "" || Pgendercmb.SelectedIndex == -1 || Pbloodgroupcmb.SelectedIndex == -1 || Pphonetextb.Text == "" || Paddresstextb.Text == "")
            {
                MessageBox.Show("Incomplete Information....");
            }
            else
            {
                try
                {
                    string query = "insert into tb_Patients values('" + Pidtextb.Text + "','" + Pnametextb.Text + "','" + Pagetextb.Text + "','" + Pbirthdaytextb.Text + "','" + Pgendercmb.SelectedItem.ToString() + "','" + Pbloodgroupcmb.SelectedItem.ToString() + "','" + Pphonetextb.Text + "','" + Paddresstextb.Text + "' )";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patients Successfully Added....");
                    Con.Close();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }
        
            
        

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Pidtextb.Text = "";
            Pnametextb.Text = "";
            Pagetextb.Text = "";
            Pbirthdaytextb.Text = "";
            Pgendercmb.SelectedIndex = 0;
            Pbloodgroupcmb.SelectedIndex = 0;
            Pphonetextb.Text = "";
            Paddresstextb.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Pnametextb_Click(object sender, EventArgs e)
        {

        }

        private void Dgendercmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dbloodgroupcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Pnametextb_Click_1(object sender, EventArgs e)
        {
            Pnametextb.Text = "";
        }

        private void Pagetextb_Click(object sender, EventArgs e)
        {
            Pagetextb.Text = "";
        }

        private void Pbirthdaytextb_Click(object sender, EventArgs e)
        {
            Pbirthdaytextb.Text = "";
        }

        private void Pphonetextb_Click(object sender, EventArgs e)
        {
            Pphonetextb.Text = "";
        }

        private void Paddresstextb_Click(object sender, EventArgs e)
        {
            Paddresstextb.Text = "";
        }

        private void Pgendercmb_Click(object sender, EventArgs e)
        {
            Pgendercmb.SelectedIndex = 0;
        }

        private void Pbloodgroupcmb_Click(object sender, EventArgs e)
        {
            Pbloodgroupcmb.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pidtextb_Click(object sender, EventArgs e)
        {
            Pidtextb.Text = "";
        }

        private void bloodStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void donateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }

        private void bloodstockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Pbirthdaytextb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

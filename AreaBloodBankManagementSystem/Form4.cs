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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Connect Sql

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VLCDUKL;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");


        // reset
        private void Reset()
        {
            Didtextb.Text = "";
            Dnametextb.Text = "";
            Dagetextb.Text = "";
            Dbirthdaytextb.Text = "";
            Dgendercmb.SelectedIndex = 0;
            Dbloodgroupcmb.SelectedIndex = 0;
            Dphonetextb.Text = "";
            Daddresstextb.Text = "";

        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
        //Add Donor Data

            if( Didtextb.Text == "" || Dnametextb.Text == "" || Dagetextb.Text == "" || Dbirthdaytextb.Text == "" || Dgendercmb.SelectedIndex == -1 || Dbloodgroupcmb.SelectedIndex == -1 || Dphonetextb.Text == "" || Daddresstextb.Text == "")
            {
                MessageBox.Show("Incomplete Information....");
            }
            else
            {
                try
                {
                    string query = "insert into tb_Donor values('" + Didtextb.Text + "','" + Dnametextb.Text + "','" + Dagetextb.Text + "','" + Dbirthdaytextb.Text + "','" + Dgendercmb.SelectedItem.ToString() + "','" + Dbloodgroupcmb.SelectedItem.ToString() + "','" + Dphonetextb.Text + "','" + Daddresstextb.Text + "' )";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Added....");
                    Con.Close();
                    Reset();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Dnametextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dagetextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dnametextb_Click(object sender, EventArgs e)
        {
            Dnametextb.Text = "";
        }

        private void Dagetextb_Click(object sender, EventArgs e)
        {
            Dagetextb.Text = "";
        }

        private void Daddresstextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Daddresstextb_Click(object sender, EventArgs e)
        {
            Daddresstextb.Text = "";
        }

        private void Dbirthdaytextb_Click(object sender, EventArgs e)
        {
            Dbirthdaytextb.Text = "";
        }

        private void Dphonetextb_Click(object sender, EventArgs e)
        {
            Dphonetextb.Text = "";
        }

        private void Dgendercmb_Click(object sender, EventArgs e)
        {
            Dgendercmb.SelectedIndex = 0;
        }

        private void Dbloodgroupcmb_Click(object sender, EventArgs e)
        {
            Dbloodgroupcmb.SelectedIndex = 0;
        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Didtextb.Text = "";
            Dnametextb.Text = "";
            Dagetextb.Text = "";
            Dbirthdaytextb.Text = "";
            Dgendercmb.SelectedIndex = 0;
            Dbloodgroupcmb.SelectedIndex = 0;
            Dphonetextb.Text = "";
            Daddresstextb.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Didtextb_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void bloodStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Didtextb_Click(object sender, EventArgs e)
        {
            Didtextb.Text = "";
        }
    }
}

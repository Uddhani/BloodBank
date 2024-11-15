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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            populate();
            BloodStock();
            
        }
        // Connect Sql

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VLCDUKL;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");

        // view table

        private void populate()
        {
            Con.Open();
            string Query = "Select * from tb_Donor";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder bulder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Donatelist.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BloodStock()
        {
            Con.Open();
            string Query = "Select * from tb_Blood";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder bulder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Bloodstocklist.DataSource = ds.Tables[0];
            Con.Close();
        }

        
        private void Form8_Load(object sender, EventArgs e)
        {

        }
        int oldstock;
        private void Updatestock(string Bgroup)
        {
            //update the blood stock

            Con.Open();
            string Query = "Select * from tb_Blood where BloodGroup ='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(Query,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BloodBagStock"].ToString());
            }
            Con.Close();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dnametextb.Text = Donatelist.SelectedRows[0].Cells[1].Value.ToString();
            Dbloodgrouptextb.Text = Donatelist.SelectedRows[0].Cells[5].Value.ToString();
            Updatestock(Dbloodgrouptextb.Text);
        }
        // select data show
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Dnametextb.Text = Donatelist.SelectedRows[0].Cells[1].Value.ToString();
                Dbloodgrouptextb.Text = Donatelist.SelectedRows[0].Cells[5].Value.ToString();
                Updatestock(Dbloodgrouptextb.Text);
            }
            
        }

        private void Reset()
        {
            Dbloodgrouptextb.Text = "";
            Dnametextb.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Dnametextb.Text == "")
            {
                MessageBox.Show("Select a Donor");
            } 
            else
            {
                try
                {
                    int stock = oldstock +1;
                    string query = "update tb_Blood set BloodBagStock  =" + stock + " where BloodGroup ='" + Dbloodgrouptextb.Text + "' ";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Successfull.... ");
                    Con.Close();
                    Reset();
                    BloodStock();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dnametextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bloodstocklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void bloodstockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

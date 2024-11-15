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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            populate();
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
            Donordgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        int key =0;
        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Didtextb.Text = Donordgv.SelectedRows[0].Cells[1].Value.ToString();
            Dnametextb.Text = Donordgv.SelectedRows[0].Cells[2].Value.ToString();
            Dagetextb.Text = Donordgv.SelectedRows[0].Cells[3].Value.ToString();
            Dbirthdaytextb.Text = Donordgv.SelectedRows[0].Cells[4].Value.ToString();
            Dgendercmb.SelectedItem = Donordgv.SelectedRows[0].Cells[5].Value.ToString();
            Dbloodgroupcmb.SelectedItem = Donordgv.SelectedRows[0].Cells[6].Value.ToString();
            Dphonetextb.Text = Donordgv.SelectedRows[0].Cells[7].Value.ToString();
            Daddresstextb.Text = Donordgv.SelectedRows[0].Cells[8].Value.ToString();

            if (Didtextb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Donordgv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

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
            key = 0;
        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (Didtextb.Text.Equals(""))
            {
                MessageBox.Show("Select the Donor to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from tb_Donor where Did = '" + Didtextb.Text + "';";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Deleted....");
                    Con.Close();
                    //Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
             if (Didtextb.Text == "" || Dnametextb.Text == "" || Dagetextb.Text == "" || Dbirthdaytextb.Text == "" || Dgendercmb.SelectedIndex == -1 || Dbloodgroupcmb.SelectedIndex == -1 || Dphonetextb.Text == "" || Daddresstextb.Text == "")
            {
                MessageBox.Show("Select the Donor to Edit");
            }
            else
            {
                try
                {
                    string query = "update tb_Donor set Did ='"+Didtextb.Text+"',Dfname ='"+Dnametextb.Text+ "',Dage ='"+Dagetextb.Text+ "',Dbirthday ='"+Dbirthdaytextb.Text+"',Dgender ='"+Dgendercmb.SelectedItem.ToString()+ "',Dbloodgroup ='"+Dbloodgroupcmb.SelectedItem.ToString()+ "',Dphone ='"+Dphonetextb.Text+ "',Daddress ='"+Daddresstextb.Text+"' where Did = '"+Didtextb.Text+ "';" ;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Editeed....");
                    Con.Close();
                    //Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Pnametextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pbirthdaytextb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pgendercmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Donordgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                Didtextb.Text = Donordgv.SelectedRows[0].Cells[0].Value.ToString();
                Dnametextb.Text = Donordgv.SelectedRows[0].Cells[1].Value.ToString();
                Dagetextb.Text = Donordgv.SelectedRows[0].Cells[2].Value.ToString();
                Dbirthdaytextb.Text = Donordgv.SelectedRows[0].Cells[3].Value.ToString();
                Dgendercmb.SelectedItem = Donordgv.SelectedRows[0].Cells[4].Value.ToString();
                Dbloodgroupcmb.SelectedItem = Donordgv.SelectedRows[0].Cells[5].Value.ToString();
                Dphonetextb.Text = Donordgv.SelectedRows[0].Cells[6].Value.ToString();
                Daddresstextb.Text = Donordgv.SelectedRows[0].Cells[7].Value.ToString();


            }
        }

        private void Didtextb_Click(object sender, EventArgs e)
        {
            Didtextb.Text = "";
        }

        private void Dnametextb_Click(object sender, EventArgs e)
        {
            Dnametextb.Text = "";
        }

        private void Dagetextb_Click(object sender, EventArgs e)
        {
            Dagetextb.Text = "";
        }

        private void Dbirthdaytextb_Click(object sender, EventArgs e)
        {
            Dbirthdaytextb.Text = "";
        }

        private void Dphonetextb_Click(object sender, EventArgs e)
        {
            Dphonetextb.Text = "";
        }

        private void Daddresstextb_Click(object sender, EventArgs e)
        {
            Daddresstextb.Text = "";
        }

        private void Dgendercmb_Click(object sender, EventArgs e)
        {
            Dgendercmb.SelectedItem = 0;
        }

        private void Dbloodgroupcmb_Click(object sender, EventArgs e)
        {
            Dbloodgroupcmb.SelectedItem = 0;
        }
    }
}

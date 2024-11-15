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
    public partial class Form7 : Form
    {
        public Form7()
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
            string Query = "Select * from tb_Patients";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder bulder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Patientsdgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        int key =0;
        private void Patientsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Pidtextb.Text = Patientsdgv.SelectedRows[0].Cells[1].Value.ToString();
            Pnametextb.Text = Patientsdgv.SelectedRows[0].Cells[2].Value.ToString();
            Pagetextb.Text = Patientsdgv.SelectedRows[0].Cells[3].Value.ToString();
            Pbirthdaytextb.Text = Patientsdgv.SelectedRows[0].Cells[4].Value.ToString();
            Pgendercmb.SelectedItem = Patientsdgv.SelectedRows[0].Cells[5].Value.ToString();
            Pbloodgroupcmb.SelectedItem = Patientsdgv.SelectedRows[0].Cells[6].Value.ToString();
            Pphonetextb.Text = Patientsdgv.SelectedRows[0].Cells[7].Value.ToString();
            Paddresstextb.Text = Patientsdgv.SelectedRows[0].Cells[8].Value.ToString();

            if(Pidtextb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Patientsdgv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


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
            key = 0;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (Pidtextb.Text == "" || Pnametextb.Text == "" || Pagetextb.Text == "" || Pbirthdaytextb.Text == "" || Pgendercmb.SelectedIndex == -1 || Pbloodgroupcmb.SelectedIndex == -1 || Pphonetextb.Text == "" || Paddresstextb.Text == "")
            {
                MessageBox.Show("Select the Patient to Edit");
            }
            else
            {
                try
                {
                    string query = "update tb_Patients set Pid ='"+Pidtextb.Text+"',Pname ='"+Pnametextb.Text+ "',Page ='"+Pagetextb.Text+ "',Pbirthday ='"+Pbirthdaytextb.Text+"',Pgender ='"+Pgendercmb.SelectedItem.ToString()+ "',Pbloodgroup ='"+Pbloodgroupcmb.SelectedItem.ToString()+ "',Pphone ='"+Pphonetextb.Text+ "',Paddress ='"+Paddresstextb.Text+"' where Pid = '"+Pidtextb.Text+ "';" ;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patients Successfully Editeed....");
                    Con.Close();
                    Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (Pidtextb.Text.Equals(""))
            {
                MessageBox.Show("Select the Patient to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from tb_Patients where Pid = '" + Pidtextb.Text + "';";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patients Successfully Deleted....");
                    Con.Close();
                    Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Pidtextb_Click(object sender, EventArgs e)
        {
            Pidtextb.Text = "";
        }

        private void Pnametextb_Click(object sender, EventArgs e)
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

        private void Pbloodgroupcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pbloodgroupcmb_Click(object sender, EventArgs e)
        {
            Pbloodgroupcmb.SelectedIndex = 0;
        }

        private void Patientsdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                Pidtextb.Text = Patientsdgv.SelectedRows[0].Cells[0].Value.ToString();
                Pnametextb.Text = Patientsdgv.SelectedRows[0].Cells[1].Value.ToString();
                Pagetextb.Text = Patientsdgv.SelectedRows[0].Cells[2].Value.ToString();
                Pbirthdaytextb.Text = Patientsdgv.SelectedRows[0].Cells[3].Value.ToString();
                Pgendercmb.SelectedItem = Patientsdgv.SelectedRows[0].Cells[4].Value.ToString();
                Pbloodgroupcmb.SelectedItem = Patientsdgv.SelectedRows[0].Cells[5].Value.ToString();
                Pphonetextb.Text = Patientsdgv.SelectedRows[0].Cells[6].Value.ToString();
                Paddresstextb.Text = Patientsdgv.SelectedRows[0].Cells[7].Value.ToString();


            }
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
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
    }
}

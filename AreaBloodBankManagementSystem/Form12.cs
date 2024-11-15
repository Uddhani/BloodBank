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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            populate();
            populate1();
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
            Donordgv.DataSource = ds.Tables[0];
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

        private void populate1()
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
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
            this.Hide();
        }

        private void Patientsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            GetData();
        }

        // Connect Sql

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-VLCDUKL;Initial Catalog=BloodBankManagementSystem;Integrated Security=True");


        private void GetData()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from tb_Donor", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Dlb.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select count (*) from tb_Patients", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Plb.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("Select count (*) from tb_Blood", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            int BStock = Convert.ToInt32( dt2.Rows[0][0].ToString());
            BSlb.Text=""+ BStock;

            //blood group

            SqlDataAdapter sda3 = new SqlDataAdapter("Select BloodBagStock  from tb_Blood where BloodGroup='" + "O+" + "' ", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            l1.Text = dt3.Rows[0][0].ToString();

            SqlDataAdapter sda4 = new SqlDataAdapter("Select BloodBagStock  from tb_Blood where BloodGroup='" + "O-" + "' ", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            l2.Text = dt4.Rows[0][0].ToString();

            SqlDataAdapter sda5 = new SqlDataAdapter("Select BloodBagStock  from tb_Blood where BloodGroup='" + "B+" + "' ", Con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            l3.Text = dt5.Rows[0][0].ToString();

            SqlDataAdapter sda6 = new SqlDataAdapter("Select BloodBagStock  from tb_Blood where BloodGroup='" + "B-" + "' ", Con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            l4.Text = dt6.Rows[0][0].ToString();

            SqlDataAdapter sda7 = new SqlDataAdapter("Select BloodBagStock  from tb_Blood where BloodGroup='" + "A+" + "' ", Con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            l5.Text = dt7.Rows[0][0].ToString();

            SqlDataAdapter sda8 = new SqlDataAdapter("Select BloodBagStock  from tb_Blood where BloodGroup='" + "A-" + "' ", Con);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
            l6.Text = dt8.Rows[0][0].ToString();

            SqlDataAdapter sda9 = new SqlDataAdapter("Select BloodBagStock  from tb_Blood where BloodGroup='" + "AB+" + "' ", Con);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            l7.Text = dt9.Rows[0][0].ToString();

            SqlDataAdapter sda10 = new SqlDataAdapter("Select BloodBagStock  from tb_Blood where BloodGroup='" + "AB-" + "' ", Con);
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
            l8.Text = dt10.Rows[0][0].ToString();


            Con.Close();
        }
        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
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

        private void donateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BSlb_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace WinFormsApp1
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\OneDrive\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FillName()
        {
            try
            {
                Con.Open();

                // Correct table name
                string query = "SELECT Mname FROM MemberTbl";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Mname", typeof(string));
                    dt.Load(rdr);

                    // Bind data to ComboBox
                    NameCb.DisplayMember = "Mname";
                    NameCb.ValueMember = "Mname";
                    NameCb.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while filling names: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "SELECT * FROM PaymentTbl where PMember='" + SearchName + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // NameTb.Text = "";
            AmountTb.Text = "";
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int key = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (NameCb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Misssing Information");
            }
            else
            {
                string payperiode = Perioder.Value.Month.ToString() + Perioder.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT count(*) FROM PaymentTbl WHERE PMember='" + NameCb.SelectedValue.ToString() + "' and PMonth='" + payperiode + "'", Con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid For This Month");
                }
                else
                {
                    string query = "INSERT INTO  PaymentTbl VALUES ('" + payperiode + "','" + NameCb.SelectedValue.ToString() + "','" + AmountTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Succesfully");
                }



                Con.Close();
                populate();
            }
        }

        private void NameCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchName.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}

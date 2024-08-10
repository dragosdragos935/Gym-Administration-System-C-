using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\OneDrive\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM MemberTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                MemberSDVG.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while populating data: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
           
            populate();
            MessageBox.Show("Please click on the id to select people to UPDATE/Delete");
        }

        int key = 0;

        private void MemberSDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MemberSDVG.Rows.Count)
            {
                DataGridViewRow row = MemberSDVG.Rows[e.RowIndex];
                key = Convert.ToInt32(row.Cells["MId"].Value);
                Console.WriteLine(key);

                if (row.Cells["MName"].Value != null)
                    NameTb.Text = row.Cells["MName"].Value.ToString();
                if (row.Cells["MPhone"].Value != null)
                    PhoneTb.Text = row.Cells["MPhone"].Value.ToString();
                if (row.Cells["MGen"].Value != null)
                    GenderCb.Text = row.Cells["MGen"].Value.ToString();
                if (row.Cells["MAge"].Value != null)
                    AgeTb.Text = row.Cells["MAge"].Value.ToString();
                if (row.Cells["MAmount"].Value != null)
                    AmountTb.Text = row.Cells["MAmount"].Value.ToString();
                if (row.Cells["MTiming"].Value != null)
                    TimingCb.Text = row.Cells["MTiming"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Invalid row index. Please click on a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            // Handle the text changed event here
            // For example, you could validate the text or enable/disable buttons
            Console.WriteLine("Name text changed to: " + NameTb.Text);
        }

        private void TimingCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle any combo box change logic if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            AgeTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimingCb.Text = "";
            AmountTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" || GenderCb.Text == "" || TimingCb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE MemberTbl SET MName=@MName, MPhone=@MPhone, MGen=@MGen, MAge=@MAge, MAmount=@MAmount, MTiming=@MTiming WHERE MId=@MId";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@MName", NameTb.Text);
                        cmd.Parameters.AddWithValue("@MPhone", PhoneTb.Text);
                        cmd.Parameters.AddWithValue("@MGen", GenderCb.Text);
                        cmd.Parameters.AddWithValue("@MAge", AgeTb.Text);
                        cmd.Parameters.AddWithValue("@MAmount", AmountTb.Text);
                        cmd.Parameters.AddWithValue("@MTiming", TimingCb.Text);
                        cmd.Parameters.AddWithValue("@MId", key);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Member Updated Successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating member: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate(); // Refresh the DataGridView to show the updated data
                    NameTb.Text = "";
                    AgeTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.Text = "";
                    TimingCb.Text = "";
                    AmountTb.Text = "";

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Check if a member is selected (key is not 0)
            if (key == 0)
            {
                MessageBox.Show("Select a member to delete.");
                return;
            }

            // Confirm the deletion with the user
            var result = MessageBox.Show("Are you sure you want to delete this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Open the database connection
                    Con.Open();

                    // Prepare the DELETE SQL query
                    string query = "DELETE FROM MemberTbl WHERE MId=@MId";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Add parameter to the command
                        cmd.Parameters.AddWithValue("@MId", key);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }

                    // Inform the user
                    MessageBox.Show("Member deleted successfully.");
                }
                catch (Exception ex)
                {
                    // Handle any errors that might have occurred
                    MessageBox.Show("Error while deleting member: " + ex.Message);
                }
                finally
                {
                    // Close the database connection
                    Con.Close();

                    // Refresh the DataGridView to show the updated data
                    populate();
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

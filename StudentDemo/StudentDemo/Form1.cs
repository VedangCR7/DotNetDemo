using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace StudentDemo
{
     
    
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);
            PopulateBranchDropdown();
        }

        private void ClearFormFields()
        {
            txtRollNo.Clear();
            txtName.Clear();
            cmbBranch.SelectedIndex = -1; 
            txtPercentage.Clear();
        }


        private void PopulateBranchDropdown()
        {
            cmbBranch.Items.Add("Computer Science");
            cmbBranch.Items.Add("Mechanical");
            cmbBranch.Items.Add("Electrical");
            cmbBranch.Items.Add("Civil");
            cmbBranch.Items.Add("Electronics");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "INSERT INTO student (roll_no, name, branch, percentage) VALUES (@roll_no, @name, @branch, @percentage)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(txtRollNo.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@branch", cmbBranch.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@percentage", Convert.ToDouble(txtPercentage.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Student added successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "SELECT name, branch, percentage FROM student WHERE roll_no = @roll_no";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(txtRollNo.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows && dr.Read())
                {
                    txtName.Text = dr["name"].ToString();
                    cmbBranch.SelectedItem = dr["branch"].ToString();
                    txtPercentage.Text = dr["percentage"].ToString();
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "UPDATE student SET name = @name, branch = @branch, percentage = @percentage WHERE roll_no = @roll_no";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(txtRollNo.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@branch", cmbBranch.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@percentage", Convert.ToDouble(txtPercentage.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Student updated successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "DELETE FROM student WHERE roll_no = @roll_no";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(txtRollNo.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Student deleted successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "SELECT * FROM student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

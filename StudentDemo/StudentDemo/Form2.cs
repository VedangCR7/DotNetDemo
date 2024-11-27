using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace StudentDemo
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);

        }
        private void PopulateBranchDropdown()
        {
          
            cmbBranch.Items.Add("Computer Science");
            cmbBranch.Items.Add("Mechanical");
            cmbBranch.Items.Add("Electrical");
            cmbBranch.Items.Add("Civil");
            cmbBranch.Items.Add("Electronics");
        }

        
        private DataSet GetStudents()
        {
            da = new SqlDataAdapter("select * from student", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da); 
            ds = new DataSet();
            da.Fill(ds, "student");
            return ds;
        }
        private void ClearFormFields()
        {
            txtRollNo.Clear();
            txtName.Clear();
            cmbBranch.SelectedIndex = -1; 
            txtPercentage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudents();
              
                DataRow row = ds.Tables["student"].NewRow();
                row["roll_no"] = Convert.ToInt32(txtRollNo.Text);
                row["name"] = txtName.Text;
                row["branch"] = cmbBranch.SelectedItem.ToString();
                row["percentage"] = Convert.ToDouble(txtPercentage.Text);
                ds.Tables["student"].Rows.Add(row); 
                int result = da.Update(ds.Tables["student"]);
                if (result >= 1)
                {
                    MessageBox.Show("Student record inserted successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudents();
                DataRow row = ds.Tables["student"].Rows.Find(Convert.ToInt32(txtRollNo.Text));
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    cmbBranch.SelectedItem = row["branch"].ToString();
                    txtPercentage.Text = row["percentage"].ToString();
                }
                else
                {
                    MessageBox.Show("Student record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudents();
                
                DataRow row = ds.Tables["student"].Rows.Find(Convert.ToInt32(txtRollNo.Text));
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["branch"] = cmbBranch.SelectedItem.ToString();
                    row["percentage"] = Convert.ToDouble(txtPercentage.Text);

                    
                    int result = da.Update(ds.Tables["student"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Student record updated successfully");
                        ClearFormFields();
                    }
                }
                else
                {
                    MessageBox.Show("Student record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudents();
                DataRow row = ds.Tables["student"].Rows.Find(Convert.ToInt32(txtRollNo.Text));
                if (row != null)
                {
                    row.Delete(); 
                    int result = da.Update(ds.Tables["student"]); 
                    if (result >= 1)
                    {
                        MessageBox.Show("Student record deleted successfully");
                        ClearFormFields();
                    }
                }
                else
                {
                    MessageBox.Show("Student record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            ds = GetStudents();
            dataGridView1.DataSource = ds.Tables["student"];
        }
    }
}

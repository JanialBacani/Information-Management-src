using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DATABASEINFOMAN
{
    public partial class JobRoles : Form
    {
        public JobRoles()
        {
            InitializeComponent();
        }

        private void txtJobRoleID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

                    
                    string insertQuery = "INSERT INTO job_roles (Job_role_ID, Employee_ID, Department_ID, Role_Name, Salary) VALUES (@Job_role_ID, @Employee_ID, @Department_ID, @Role_Name, @Salary)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, MyConn);
                    insertCommand.Parameters.AddWithValue("@Job_role_ID", txtJobRoleID.Text);
                    insertCommand.Parameters.AddWithValue("@Employee_ID", txtEmployeeID.Text);
                    insertCommand.Parameters.AddWithValue("@Department_ID", txtDeptID.Text);
                    insertCommand.Parameters.AddWithValue("@Role_Name", txtRoleName.Text);
                    insertCommand.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    insertCommand.ExecuteNonQuery();

                  
                    string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, New_Value, Performed_By) " +
                                      "VALUES ('INSERT', 'job_roles', @Record_ID, NULL, @NewValue, 'Admin')";
                    MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                    string newValue = $"{{'Job_role_ID': '{txtJobRoleID.Text}', 'Employee_ID': '{txtEmployeeID.Text}', 'Department_ID': '{txtDeptID.Text}', 'Role_Name': '{txtRoleName.Text}', 'Salary': '{txtSalary.Text}'}}";
                    logCommand.Parameters.AddWithValue("@Record_ID", txtJobRoleID.Text);
                    logCommand.Parameters.AddWithValue("@NewValue", newValue);
                    logCommand.ExecuteNonQuery();

                    MessageBox.Show("Record Saved and Audit Log Created");

                   
                    btnDisplay_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

                    
                    string selectQuery = "SELECT Employee_ID, Department_ID, Role_Name, Salary FROM job_roles WHERE Job_role_ID = @Job_role_ID";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, MyConn);
                    selectCommand.Parameters.AddWithValue("@Job_role_ID", txtJobRoleID.Text);
                    string oldValue = "";
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oldValue = $"{{'Employee_ID': '{reader["Employee_ID"]}', 'Department_ID': '{reader["Department_ID"]}', 'Role_Name': '{reader["Role_Name"]}', 'Salary': '{reader["Salary"]}'}}";
                        }
                    }

                    
                    string updateQuery = "UPDATE job_roles SET Employee_ID = @Employee_ID, Department_ID = @Department_ID, Role_Name = @Role_Name, Salary = @Salary WHERE Job_role_ID = @Job_role_ID";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, MyConn);
                    updateCommand.Parameters.AddWithValue("@Job_role_ID", txtJobRoleID.Text);
                    updateCommand.Parameters.AddWithValue("@Employee_ID", txtEmployeeID.Text);
                    updateCommand.Parameters.AddWithValue("@Department_ID", txtDeptID.Text);
                    updateCommand.Parameters.AddWithValue("@Role_Name", txtRoleName.Text);
                    updateCommand.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    updateCommand.ExecuteNonQuery();

                   
                    string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, New_Value, Performed_By) " +
                                      "VALUES ('UPDATE', 'job_roles', @Record_ID, @OldValue, @NewValue, 'Admin')";
                    MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                    string newValue = $"{{'Employee_ID': '{txtEmployeeID.Text}', 'Department_ID': '{txtDeptID.Text}', 'Role_Name': '{txtRoleName.Text}', 'Salary': '{txtSalary.Text}'}}";
                    logCommand.Parameters.AddWithValue("@Record_ID", txtJobRoleID.Text);
                    logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                    logCommand.Parameters.AddWithValue("@NewValue", newValue);
                    logCommand.ExecuteNonQuery();

                    MessageBox.Show("Record Updated and Audit Log Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

               
                    string selectQuery = "SELECT Employee_ID, Department_ID, Role_Name, Salary FROM job_roles WHERE Job_role_ID = @Job_role_ID";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, MyConn);
                    selectCommand.Parameters.AddWithValue("@Job_role_ID", txtJobRoleID.Text);
                    string oldValue = "";
                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oldValue = $"{{'Employee_ID': '{reader["Employee_ID"]}', 'Department_ID': '{reader["Department_ID"]}', 'Role_Name': '{reader["Role_Name"]}', 'Salary': '{reader["Salary"]}'}}";
                        }
                    }

                   
                    string deleteQuery = "DELETE FROM job_roles WHERE Job_role_ID = @Job_role_ID";
                    MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, MyConn);
                    deleteCommand.Parameters.AddWithValue("@Job_role_ID", txtJobRoleID.Text);
                    deleteCommand.ExecuteNonQuery();

                  
                    string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, New_Value, Performed_By) " +
                                      "VALUES ('DELETE', 'job_roles', @Record_ID, @OldValue, NULL, 'Admin')";
                    MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                    logCommand.Parameters.AddWithValue("@Record_ID", txtJobRoleID.Text);
                    logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                    logCommand.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted and Audit Log Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string Query = "SELECT Job_role_ID, Employee_ID, Department_ID, Role_Name, Salary FROM job_roles;";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand);
                    DataTable dTable = new DataTable();
                    MyConn.Open();
                    MyAdapter.Fill(dTable);
                    dataGridJobRoles.DataSource = dTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void query_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();

            
            Form1 employeeForm = new Form1();
            employeeForm.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();


            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            projectforms projectform = new projectforms();
            projectform.Show();
        }

        private void JobRoles_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jobrole_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridJobRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtJobRoleID.Text.Trim(); 
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string query = "SELECT Job_role_ID, Employee_ID, Department_ID, Role_Name, Salary FROM job_roles WHERE Job_role_ID LIKE @SearchTerm OR Employee_ID LIKE @SearchTerm OR Department_ID LIKE @SearchTerm OR Role_Name LIKE @SearchTerm";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                    MyCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%"); 
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand);
                    DataTable dTable = new DataTable();
                    MyConn.Open();
                    MyAdapter.Fill(dTable);
                    dataGridJobRoles.DataSource = dTable; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnERD_Click(object sender, EventArgs e)
        {
            this.Hide();


            erd ERD = new erd();
            ERD.Show();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location loc = new DATABASEINFOMAN.Location();
            loc.Show();
        }
    }
    
}

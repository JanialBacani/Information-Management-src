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
    public partial class projectforms : Form
    {
        public projectforms()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";             
                string ProjectID = txtprojid.Text;
                string Query = "SELECT Project_ID, Project_Name, Department_ID FROM projects WHERE Project_ID = @Project_ID";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MyCommand.Parameters.AddWithValue("@Project_ID", ProjectID);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand);
                    DataTable dTable = new DataTable();
                    MyConn.Open();

                    MyAdapter.Fill(dTable);
                    datagridproj.DataSource = dTable;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM departments WHERE Department_ID = @Department_ID";
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, MyConn);
                    checkCommand.Parameters.AddWithValue("@Department_ID", this.txtmanagingid.Text);

                    int departmentExists = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (departmentExists == 0)
                    {
                        MessageBox.Show("The Department_ID does not exist. Please add the department first.");
                        return;
                    }

                   
                    string insertQuery = "INSERT INTO projects (Project_ID, Department_ID, Project_Name) VALUES (@Project_ID, @Department_ID, @Project_Name)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, MyConn);
                    insertCommand.Parameters.AddWithValue("@Project_ID", this.txtprojid.Text);
                    insertCommand.Parameters.AddWithValue("@Department_ID", this.txtmanagingid.Text);
                    insertCommand.Parameters.AddWithValue("@Project_Name", this.txtprojname.Text);
                    insertCommand.ExecuteNonQuery();

                  
                    string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, New_Value, Performed_By) " +
                                      "VALUES ('INSERT', 'projects', @Record_ID, @NewValue, @Performed_By)";
                    MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                    logCommand.Parameters.AddWithValue("@Record_ID", this.txtprojid.Text);
                    logCommand.Parameters.AddWithValue("@NewValue", $"Department_ID: {this.txtmanagingid.Text}, Project_Name: {this.txtprojname.Text}");
                    logCommand.Parameters.AddWithValue("@Performed_By", "Admin");
                    logCommand.ExecuteNonQuery();

                    MessageBox.Show("Record Saved");
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
                string Query = "SELECT Project_ID, Department_ID, Project_Name FROM projects;";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand);
                    DataTable dTable = new DataTable();
                    MyConn.Open();

                    MyAdapter.Fill(dTable);
                    datagridproj.DataSource = dTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            
            projectforms projectForm = new projectforms();
            projectForm.Show();

            this.Close(); 
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();

           
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();


         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string selectQuery = "SELECT * FROM projects WHERE Project_ID = @Project_ID";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, MyConn);
                    selectCmd.Parameters.AddWithValue("@Project_ID", txtprojid.Text);

                    MyConn.Open();
                    MySqlDataReader reader = selectCmd.ExecuteReader();

                    string oldValue = string.Empty;
                    if (reader.Read())
                    {
                        oldValue = $"Department_ID: {reader["Department_ID"]}, Project_Name: {reader["Project_Name"]}";
                    }
                    reader.Close();

                  
                    string deleteQuery = "DELETE FROM projects WHERE Project_ID = @Project_ID";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, MyConn);
                    deleteCmd.Parameters.AddWithValue("@Project_ID", txtprojid.Text);
                    deleteCmd.ExecuteNonQuery();

                    
                    string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, Performed_By) " +
                                      "VALUES ('DELETE', 'projects', @Record_ID, @OldValue, @Performed_By)";
                    MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                    logCommand.Parameters.AddWithValue("@Record_ID", txtprojid.Text);
                    logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                    logCommand.Parameters.AddWithValue("@Performed_By", "Admin");
                    logCommand.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string selectQuery = "SELECT * FROM projects WHERE Project_ID = @Project_ID";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, MyConn);
                    selectCmd.Parameters.AddWithValue("@Project_ID", txtprojid.Text);

                    MyConn.Open();
                    MySqlDataReader reader = selectCmd.ExecuteReader();

                    string oldValue = string.Empty;
                    if (reader.Read())
                    {
                        oldValue = $"Department_ID: {reader["Department_ID"]}, Project_Name: {reader["Project_Name"]}";
                    }
                    reader.Close();

                 
                    string updateQuery = "UPDATE projects SET Department_ID = @Department_ID, Project_Name = @Project_Name WHERE Project_ID = @Project_ID";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, MyConn);
                    updateCmd.Parameters.AddWithValue("@Project_ID", txtprojid.Text);
                    updateCmd.Parameters.AddWithValue("@Department_ID", txtmanagingid.Text);
                    updateCmd.Parameters.AddWithValue("@Project_Name", txtprojname.Text);
                    updateCmd.ExecuteNonQuery();

                 
                    string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, New_Value, Performed_By) " +
                                      "VALUES ('UPDATE', 'projects', @Record_ID, @OldValue, @NewValue, @Performed_By)";
                    MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                    logCommand.Parameters.AddWithValue("@Record_ID", txtprojid.Text);
                    logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                    logCommand.Parameters.AddWithValue("@NewValue", $"Department_ID: {txtmanagingid.Text}, Project_Name: {txtprojname.Text}");
                    logCommand.Parameters.AddWithValue("@Performed_By", "Admin");
                    logCommand.ExecuteNonQuery();

                    MessageBox.Show("Record Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJobRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobRoles jobroles = new JobRoles();


            jobroles.Show();
        }

        private void btnERD_Click(object sender, EventArgs e)
        {
            this.Hide();


            erd ERD = new erd();
            ERD.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location loc = new Location();
            loc.Show();
        }
    }
}

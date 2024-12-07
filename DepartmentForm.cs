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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of the Employee form and show it
            Form1 employeeForm = new Form1();
            employeeForm.Show();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            projectforms projectform = new projectforms();
            projectform.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {            
                if (string.IsNullOrWhiteSpace(txtdeptid.Text))
                {
                    MessageBox.Show("Please enter a Department ID to search.");
                    return;
                }            
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";     
                string Query = @"
                    SELECT 
                        d.Department_ID,
                        d.Name AS Department_Name
                    FROM 
                        departments d
                    WHERE 
                         d.Department_ID = @Department_ID";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                 
                    using (MySqlCommand MyCommand = new MySqlCommand(Query, MyConn))
                    {
                    
                        MyCommand.Parameters.AddWithValue("@Department_ID", txtdeptid.Text); 
                        MyConn.Open();
                        using (MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand))
                        {
                            DataTable dTable = new DataTable();
                            MyAdapter.Fill(dTable);
                            if (dTable.Rows.Count > 0)
                            {
                                datagriddept.DataSource = dTable;
                                txtDepartmentName.Text = dTable.Rows[0]["Department_Name"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Record not found!");
                                datagriddept.DataSource = null; 
                                txtDepartmentName.Clear();
                            }
                        }
                    }
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
                string Query = "INSERT INTO departments(Department_ID, Name) VALUES('" +
                this.txtdeptid.Text + "', '" +
                this.txtDepartmentName.Text + "');";

                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

                MyConn.Open();
                MyCommand.ExecuteNonQuery();            
                string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, New_Value, Performed_By) " +
                                  "VALUES ('INSERT', 'departments', @Record_ID, @NewValue, @Performed_By)";
                MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                logCommand.Parameters.AddWithValue("@Record_ID", txtdeptid.Text);
                logCommand.Parameters.AddWithValue("@NewValue", $"Name: {txtDepartmentName.Text}");
                logCommand.Parameters.AddWithValue("@Performed_By", "Admin"); // Replace with current user if available
                logCommand.ExecuteNonQuery();

                MessageBox.Show("Record Saved");

                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string Query = "SELECT Department_ID, Name FROM departments;";
                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    using (MySqlCommand MyCommand = new MySqlCommand(Query, MyConn))
                    {
                        DataTable dTable = new DataTable();
                        using (MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand))
                        {
                            MyConn.Open();
                            MyAdapter.Fill(dTable);
                            datagriddept.DataSource = dTable;
                            string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, New_Value, Performed_By) " +
                                              "VALUES ('DISPLAY', 'departments', 'All Departments Displayed', @Performed_By)";
                            MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                            logCommand.Parameters.AddWithValue("@Performed_By", "Admin"); 
                            logCommand.ExecuteNonQuery();
                        }
                    }
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
                string selectQuery = "SELECT * FROM departments WHERE Department_ID = @Department_ID";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, MyConn);
                selectCmd.Parameters.AddWithValue("@Department_ID", txtdeptid.Text);
                MyConn.Open();
                MySqlDataReader reader = selectCmd.ExecuteReader();

                string oldValue = string.Empty;
                if (reader.Read())
                {
                    oldValue = $"Name: {reader["Name"]}";
                }
                reader.Close();

                string deleteQuery = "DELETE FROM departments WHERE Department_ID = @Department_ID";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, MyConn);
                deleteCmd.Parameters.AddWithValue("@Department_ID", txtdeptid.Text);
                deleteCmd.ExecuteNonQuery();

                string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, Performed_By) " +
                                  "VALUES ('DELETE', 'departments', @Record_ID, @OldValue, @Performed_By)";
                MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                logCommand.Parameters.AddWithValue("@Record_ID", txtdeptid.Text);
                logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                logCommand.Parameters.AddWithValue("@Performed_By", "Admin");
                logCommand.ExecuteNonQuery();

                MessageBox.Show("Record Deleted");
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void txtdeptid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnJobRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobRoles jobroles = new JobRoles();


            jobroles.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string selectQuery = "SELECT * FROM departments WHERE Department_ID = @Department_ID";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, MyConn);
                selectCmd.Parameters.AddWithValue("@Department_ID", txtdeptid.Text);
                MyConn.Open();
                MySqlDataReader reader = selectCmd.ExecuteReader();

                string oldValue = string.Empty;
                if (reader.Read())
                {
                    oldValue = $"Name: {reader["Name"]}";
                }
                reader.Close();

                string updateQuery = "UPDATE departments SET Name = @Name WHERE Department_ID = @Department_ID";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, MyConn);

                updateCmd.Parameters.AddWithValue("@Department_ID", txtdeptid.Text);
                updateCmd.Parameters.AddWithValue("@Name", txtDepartmentName.Text);

                updateCmd.ExecuteNonQuery();

                string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, New_Value, Performed_By) " +
                                  "VALUES ('UPDATE', 'departments', @Record_ID, @OldValue, @NewValue, @Performed_By)";
                MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                logCommand.Parameters.AddWithValue("@Record_ID", txtdeptid.Text);
                logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                logCommand.Parameters.AddWithValue("@NewValue", $"Name: {txtDepartmentName.Text}");
                logCommand.Parameters.AddWithValue("@Performed_By", "Admin");
                logCommand.ExecuteNonQuery();

                MessageBox.Show("Record Updated");
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnERD_Click(object sender, EventArgs e)
        {
            this.Hide();

          
            erd ERD = new erd();
            ERD.Show();
        }
        private void DisplayAuditLog()
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string Query = "SELECT Log_ID, Action_Type, Table_Name, Record_ID, Old_Value, New_Value, Timestamp, Performed_By FROM audit_log";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand);
                    DataTable dTable = new DataTable();
                    MyConn.Open();
                    MyAdapter.Fill(dTable);
                    dataGridAuditLog.DataSource = dTable; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location loc = new Location();

            loc.Show();
        }
    }
}


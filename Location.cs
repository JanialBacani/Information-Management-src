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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocID_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLocID.Text))
                {
                    MessageBox.Show("Please enter a Location ID to search.");
                    return;
                }
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string Query = @"
                      SELECT 
                         Location_ID,
                         Department_ID,
                        Address
                     FROM 
                         locationss
                     WHERE 
                         Location_ID = @Location_ID";
                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    using (MySqlCommand MyCommand = new MySqlCommand(Query, MyConn))
                    {
                        MyCommand.Parameters.AddWithValue("@Location_ID", txtLocation.Text);
                        MyConn.Open();
                        using (MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand))
                        {
                            DataTable dTable = new DataTable();
                            MyAdapter.Fill(dTable);

                            if (dTable.Rows.Count > 0)
                            {
                                dataGridLocation.DataSource = dTable; 
                                txtDepartment.Text = dTable.Rows[0]["Department_ID"].ToString();
                                txtAddress.Text = dTable.Rows[0]["Address"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Record not found!");
                                dataGridLocation.DataSource = null;
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
                string insertQuery = "INSERT INTO locationss (Location_ID, Department_ID, Address) VALUES (@Location_ID, @Department_ID, @Address)";
                string logQuery = "INSERT INTO audit_log (Table_Name, Action_Type, Record_ID, New_Value, Timestamp, Performed_By) " +
                                  "VALUES ('locationss', 'INSERT', @Location_ID, @NewValue, NOW(), @PerformedBy)";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

               
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, MyConn))
                    {
                        insertCommand.Parameters.AddWithValue("@Location_ID", txtLocation.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@Department_ID", txtDepartment.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        insertCommand.ExecuteNonQuery();
                    }

                   
                    using (MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn))
                    {
                        string newValue = $"{{'Department_ID': '{txtDepartment.Text}', 'Address': '{txtAddress.Text}'}}";
                        logCommand.Parameters.AddWithValue("@Location_ID", txtLocation.Text.Trim());
                        logCommand.Parameters.AddWithValue("@NewValue", newValue);
                        logCommand.Parameters.AddWithValue("@PerformedBy", "Admin"); // Replace with dynamic user information
                        logCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record Saved and Audit Log Created.");
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
                string selectQuery = "SELECT Department_ID, Address FROM locationss WHERE Location_ID = @Location_ID";
                string updateQuery = "UPDATE locationss SET Department_ID = @Department_ID, Address = @Address WHERE Location_ID = @Location_ID";
                string logQuery = "INSERT INTO audit_log (Table_Name, Action_Type, Record_ID, Old_Value, New_Value, Timestamp, Performed_By) " +
                                  "VALUES ('locationss', 'UPDATE', @Location_ID, @OldValue, @NewValue, NOW(), @PerformedBy)";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

                    string oldValue = "";
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, MyConn))
                    {
                        selectCommand.Parameters.AddWithValue("@Location_ID", txtLocID.Text.Trim());
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                oldValue = $"{{'Department_ID': '{reader["Department_ID"]}', 'Address': '{reader["Address"]}'}}";
                            }
                        }
                    }

                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, MyConn))
                    {
                        updateCommand.Parameters.AddWithValue("@Location_ID", txtLocID.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@Department_ID", txtDeptID.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        updateCommand.ExecuteNonQuery();
                    }

                    
                    using (MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn))
                    {
                        string newValue = $"{{'Department_ID': '{txtDeptID.Text}', 'Address': '{txtAddress.Text}'}}";
                        logCommand.Parameters.AddWithValue("@Location_ID", txtLocID.Text.Trim());
                        logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                        logCommand.Parameters.AddWithValue("@NewValue", newValue);
                        logCommand.Parameters.AddWithValue("@PerformedBy", "Admin"); 
                        logCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record Updated and Audit Log Created.");
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
                string Query = "SELECT Location_ID, Department_ID, Address FROM locationss;";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand);
                    DataTable dTable = new DataTable();
                    MyConn.Open();
                    MyAdapter.Fill(dTable);
                    dataGridLocation.DataSource = dTable; 
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
          
                if (string.IsNullOrWhiteSpace(txtLocID.Text))
                {
                    MessageBox.Show("Please enter a Location ID to delete.");
                    return;
                }

                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string selectQuery = "SELECT Department_ID, Address FROM locationss WHERE Location_ID = @Location_ID";
                string deleteQuery = "DELETE FROM locationss WHERE Location_ID = @Location_ID";
                string logQuery = "INSERT INTO audit_log (Table_Name, Action_Type, Record_ID, Old_Value, Timestamp, Performed_By) " +
                                  "VALUES ('locationss', 'DELETE', @Location_ID, @OldValue, NOW(), @PerformedBy)";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

                 
                    string oldValue = "";
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, MyConn))
                    {
                        selectCommand.Parameters.AddWithValue("@Location_ID", txtLocID.Text.Trim());
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                oldValue = $"{{'Department_ID': '{reader["Department_ID"]}', 'Address': '{reader["Address"]}'}}";
                            }
                            else
                            {
                                MessageBox.Show("Location not found!");
                                return;
                            }
                        }
                    }

                    Console.WriteLine($"Old Value: {oldValue}");

                   
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, MyConn))
                    {
                        deleteCommand.Parameters.AddWithValue("@Location_ID", txtLocID.Text.Trim());
                        int affectedRows = deleteCommand.ExecuteNonQuery();

               
                        Console.WriteLine($"Rows affected: {affectedRows}");
                        if (affectedRows == 0)
                        {
                            MessageBox.Show("No record deleted. Please check if the Location ID exists.");
                            return;
                        }
                    }

                  
                    using (MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn))
                    {
                        logCommand.Parameters.AddWithValue("@Location_ID", txtLocID.Text.Trim());
                        logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                        logCommand.Parameters.AddWithValue("@PerformedBy", "Admin"); 
                        logCommand.ExecuteNonQuery();
                    }

                 

                    MessageBox.Show("Record Deleted and Audit Log Created.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of the Employee form and show it
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
            projectforms projectsForm = new projectforms();


            projectsForm.Show();
        }

        private void query_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void btnERD_Click(object sender, EventArgs e)
        {
            this.Hide();


            erd ERD = new erd();
            ERD.Show();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

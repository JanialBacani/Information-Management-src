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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {



        }

        private void Display_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {


        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtidno.Text))
                {
                    MessageBox.Show("Please enter an ID number to search.");
                    return;
                }
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";

                string Query = @"
                     SELECT 
                         e.Employee_ID,
                         e.Name AS Employee_Name,
                         e.Hire_Date,
                         e.Department_ID
        
                     FROM 
                         employees e
                     WHERE 
                         e.Employee_ID = @Employee_ID";
                
                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    using (MySqlCommand MyCommand = new MySqlCommand(Query, MyConn))
                    {
                        MyCommand.Parameters.AddWithValue("@Employee_ID", txtidno.Text);   
                        MyConn.Open();
                        using (MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand))
                        {
                            DataTable dTable = new DataTable();
                            MyAdapter.Fill(dTable);
                            if (dTable.Rows.Count > 0)
                            {
                               datagrid.DataSource = dTable;
                                txtfirstname.Text = dTable.Rows[0]["Employee_Name"].ToString();
                                hiredate.Text = Convert.ToDateTime(dTable.Rows[0]["Hire_Date"]).ToString("yyyy-MM-dd");
                                txtdeptid.Text = dTable.Rows[0]["Department_ID"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Record not found!");
                                datagrid.DataSource = null;
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

        private void txtidno_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string Query = "INSERT INTO employees (Employee_ID, Name, Hire_Date, Department_ID) VALUES ('" +
                                this.txtidno.Text + "', '" +
                                this.txtfirstname.Text + "', '" +
                                this.hiredate.Text + "', '" +
                                this.txtdeptid.Text + "');";

                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MyConn.Open();
                MyCommand.ExecuteReader();

                // Insert audit log
                string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, New_Value, Performed_By) " +
                                  "VALUES ('INSERT', 'employees', @Record_ID, @NewValue, @Performed_By)";
                MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                logCommand.Parameters.AddWithValue("@Record_ID", txtidno.Text);
                logCommand.Parameters.AddWithValue("@NewValue", $"Name: {txtfirstname.Text}, Hire_Date: {hiredate.Text}, Dept_ID: {txtdeptid.Text}");
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
                string Query = "SELECT Employee_ID, Name, COALESCE(DATE_FORMAT(Hire_Date, '%Y-%m-%d'), 'No Date') AS Hire_Date, Department_ID FROM employees;";
                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    using (MySqlCommand MyCommand = new MySqlCommand(Query, MyConn))
                    {
                        DataTable dTable = new DataTable();
                        using (MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand))
                        {
                            MyConn.Open();
                            MyAdapter.Fill(dTable);
                            datagrid.DataSource = dTable;
                            datagrid.Columns["Employee_ID"].HeaderText = "Employee ID";
                            datagrid.Columns["Name"].HeaderText = "Employee Name";
                            datagrid.Columns["Hire_Date"].HeaderText = "Hire Date";
                            datagrid.Columns["Department_ID"].HeaderText = "Department ID"; // Ensure this is displayed
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void txthiredate_Click(object sender, EventArgs e)
        {

        }
        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }
        private void hiredate_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string selectQuery = "SELECT * FROM employees WHERE Employee_ID = @Employee_ID";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, MyConn);
                selectCmd.Parameters.AddWithValue("@Employee_ID", txtidno.Text);
                MyConn.Open();
                MySqlDataReader reader = selectCmd.ExecuteReader();

                string oldValue = string.Empty;
                if (reader.Read())
                {
                    oldValue = $"Name: {reader["Name"]}, Hire_Date: {reader["Hire_Date"]}, Dept_ID: {reader["Department_ID"]}";
                }
                reader.Close();

                string deleteQuery = "DELETE FROM employees WHERE Employee_ID = @Employee_ID";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, MyConn);
                deleteCmd.Parameters.AddWithValue("@Employee_ID", txtidno.Text);
                deleteCmd.ExecuteNonQuery();

                string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, Performed_By) " +
                                  "VALUES ('DELETE', 'employees', @Record_ID, @OldValue, @Performed_By)";
                MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                logCommand.Parameters.AddWithValue("@Record_ID", txtidno.Text);
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
        private void btnShow_Click(object sender, EventArgs e)                 
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";           
                string Query = "SELECT Employee_ID, Name, COALESCE(DATE_FORMAT(Hire_Date, '%Y-%m-%d'), 'No Date') AS Hire_Date FROM employees;";

                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    using (MySqlCommand MyCommand = new MySqlCommand(Query, MyConn))
                    {
                        DataTable dTable = new DataTable();

                        using (MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand))
                        {
                            MyConn.Open();

                            MyAdapter.Fill(dTable);

                            
                            datagrid.DataSource = dTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();   
        }
        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
        }
        private void ID_Click(object sender, EventArgs e)
        {
        }
        private void FirstName_Click(object sender, EventArgs e)
        {
        }
         private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            projectforms projectsForm = new projectforms();
            projectsForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                string selectQuery = "SELECT * FROM employees WHERE Employee_ID = @Employee_ID";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, MyConn);
                selectCmd.Parameters.AddWithValue("@Employee_ID", txtidno.Text);
                MyConn.Open();
                MySqlDataReader reader = selectCmd.ExecuteReader();

                string oldValue = string.Empty;
                if (reader.Read())
                {
                    oldValue = $"Name: {reader["Name"]}, Hire_Date: {reader["Hire_Date"]}, Dept_ID: {reader["Department_ID"]}";
                }
                reader.Close();

                string updateQuery = "UPDATE employees SET Employee_ID=@Employee_ID, Name=@Name, Hire_Date=@Hire_Date, Department_ID=@Department_ID WHERE Employee_ID=@Employee_ID";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, MyConn);
                updateCmd.Parameters.AddWithValue("@Employee_ID", txtidno.Text);
                updateCmd.Parameters.AddWithValue("@Name", txtfirstname.Text);
                updateCmd.Parameters.AddWithValue("@Hire_Date", hiredate.Text);
                updateCmd.Parameters.AddWithValue("@Department_ID", txtdeptid.Text);
                updateCmd.ExecuteNonQuery();
              
                string logQuery = "INSERT INTO audit_log (Action_Type, Table_Name, Record_ID, Old_Value, New_Value, Performed_By) " +
                                  "VALUES ('UPDATE', 'employees', @Record_ID, @OldValue, @NewValue, @Performed_By)";
                MySqlCommand logCommand = new MySqlCommand(logQuery, MyConn);
                logCommand.Parameters.AddWithValue("@Record_ID", txtidno.Text);
                logCommand.Parameters.AddWithValue("@OldValue", oldValue);
                logCommand.Parameters.AddWithValue("@NewValue", $"Name: {txtfirstname.Text}, Hire_Date: {hiredate.Text}, Dept_ID: {txtdeptid.Text}");
                logCommand.Parameters.AddWithValue("@Performed_By", "Admin");
                logCommand.ExecuteNonQuery();

                MessageBox.Show("Record Updated");
                MyConn.Close();
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
        private void btnLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Location loc = new Location();
            loc.Show();
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
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void txtdeptid_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

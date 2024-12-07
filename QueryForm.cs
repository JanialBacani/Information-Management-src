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
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
            
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {              
              string MyConnection = "datasource=localhost;port=3308;username=root;password=;database=infoman";
                using (MySqlConnection MyConn = new MySqlConnection(MyConnection))
                {
                    MyConn.Open();

                    string query = txtQuery.Text;

                    using (MySqlCommand MyCommand = new MySqlCommand(query, MyConn))
                    {
                        if (query.Trim().ToUpper().StartsWith("SELECT"))
                        {                     
                            MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand);
                            DataTable dTable = new DataTable();
                            MyAdapter.Fill(dTable);
                            dataGridResults.DataSource = dTable;
                        }
                        else
                        {
                            int rowsAffected = MyCommand.ExecuteNonQuery();
                            MessageBox.Show($"{rowsAffected} row(s) affected.");
                        }
                    }
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

        private void btnJobRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            JobRoles jobroles = new JobRoles();


            jobroles.Show();
        }

        private void dataGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
    


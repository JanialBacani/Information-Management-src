using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASEINFOMAN
{
    public partial class erd : Form
    {
        public erd()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
   
            pictureBox1.Image = Image.FromFile("C:/Users/Janial/Documents/3rd year FILES/INFOMAN/FILES/erd.png");


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();          
            Form1 employeeForm = new Form1();
            employeeForm.Show();
        }
    }
}

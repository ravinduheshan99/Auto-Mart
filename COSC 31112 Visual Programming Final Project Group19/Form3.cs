using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void btncustomer3_Click(object sender, EventArgs e)
        {
            frm11 obj = new frm11();
            obj.Show();
            this.Hide();
        }

        private void btnappointment3_Click(object sender, EventArgs e)
        {
            frm10 obj = new frm10();
            obj.Show();
            this.Hide();
        }

        private void btninventory3_Click(object sender, EventArgs e)
        {
            frm12 obj = new frm12();
            obj.Show();
            this.Hide();
        }

        private void btnlogout3_Click(object sender, EventArgs e)
        {
            frm1 obj = new frm1();
            obj.Show();
            this.Hide();
            MessageBox.Show("Successfully Logout!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnexit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaboutus3_Click(object sender, EventArgs e)
        {
            string url = "file:///C:/Users/Ravindu%20Haputhanthri/Desktop/COSC%2031112_Final%20Project_%20Group19/car.html";
            System.Diagnostics.Process.Start(url);
        }

        private void btnappointment3_MouseEnter(object sender, EventArgs e)
        {
            btnappointment3.BackColor = Color.RoyalBlue;
        }

        private void btnappointment3_MouseLeave(object sender, EventArgs e)
        {
            btnappointment3.BackColor = Color.Black;
        }

        private void btncustomer3_MouseEnter(object sender, EventArgs e)
        {
            btncustomer3.BackColor = Color.RoyalBlue;
        }

        private void btncustomer3_MouseLeave(object sender, EventArgs e)
        {
            btncustomer3.BackColor = Color.Black;
        }

        private void btninventory3_MouseEnter(object sender, EventArgs e)
        {
           btninventory3.BackColor = Color.RoyalBlue;
        }

        private void btninventory3_MouseLeave(object sender, EventArgs e)
        {
            btninventory3.BackColor = Color.Black;
        }

        private void btnaboutus3_MouseEnter(object sender, EventArgs e)
        {
            btnaboutus3.BackColor = Color.RoyalBlue;
        }

        private void btnaboutus3_MouseLeave(object sender, EventArgs e)
        {
            btnaboutus3.BackColor = Color.Black;
        }

        private void btnlogout3_MouseEnter(object sender, EventArgs e)
        {
            btnlogout3.BackColor = Color.RoyalBlue;
        }

        private void btnlogout3_MouseLeave(object sender, EventArgs e)
        {
            btnlogout3.BackColor = Color.Black;
        }

        private void btnexit3_MouseEnter(object sender, EventArgs e)
        {
            btnexit3.BackColor = Color.RoyalBlue;
        }

        private void btnexit3_MouseLeave(object sender, EventArgs e)
        {
            btnexit3.BackColor = Color.Black;
        }
    }
}

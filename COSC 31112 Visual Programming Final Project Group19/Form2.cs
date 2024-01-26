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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            frm5 obj = new frm5();
            obj.Show();
            this.Hide();
        }

        private void btnappointment_Click(object sender, EventArgs e)
        {
            frm4 obj = new frm4();
            obj.Show();
            this.Hide();
        }

        private void btnvehicle_Click(object sender, EventArgs e)
        {
            frm7 obj = new frm7();
            obj.Show();
            this.Hide();
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            frm8 obj = new frm8();
            obj.Show();
            this.Hide();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            frm6 obj = new frm6();
            obj.Show();
            this.Hide();
        }

        private void btnsalary_Click(object sender, EventArgs e)
        {
            frm9 obj = new frm9();
            obj.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            frm1 obj = new frm1();
            obj.Show();
            this.Hide();
            MessageBox.Show("Successfully Logout!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnaboutus_Click(object sender, EventArgs e)
        {
            string url = "file:///C:/Users/Ravindu%20Haputhanthri/Desktop/COSC%2031112_Final%20Project_%20Group19/car.html";
            System.Diagnostics.Process.Start(url);
        }

        private void btnappointment_MouseEnter(object sender, EventArgs e)
        {
            btnappointment.BackColor = Color.RoyalBlue;
        }

        private void btnappointment_MouseLeave(object sender, EventArgs e)
        {
            btnappointment.BackColor = Color.Black;
        }

        private void btncustomer_MouseEnter(object sender, EventArgs e)
        {
            btncustomer.BackColor = Color.RoyalBlue;
            
        }

        private void btncustomer_MouseLeave(object sender, EventArgs e)
        {
            btncustomer.BackColor = Color.Black;
        }

        private void btninventory_MouseEnter(object sender, EventArgs e)
        {
            btninventory.BackColor = Color.RoyalBlue;
        }

        private void btninventory_MouseLeave(object sender, EventArgs e)
        {
            btninventory.BackColor = Color.Black;
        }

        private void btnvehicle_MouseEnter(object sender, EventArgs e)
        {
            btnvehicle.BackColor = Color.RoyalBlue;
        }

        private void btnvehicle_MouseLeave(object sender, EventArgs e)
        {
            btnvehicle.BackColor = Color.Black;
        }

        private void btnemployee_MouseEnter(object sender, EventArgs e)
        {
            btnemployee.BackColor = Color.RoyalBlue;
        }

        private void btnemployee_MouseLeave(object sender, EventArgs e)
        {
            btnemployee.BackColor = Color.Black;
        }

        private void btnsalary_MouseEnter(object sender, EventArgs e)
        {
            btnsalary.BackColor = Color.RoyalBlue;
        }

        private void btnsalary_MouseLeave(object sender, EventArgs e)
        {
            btnsalary.BackColor = Color.Black;
        }

        private void btnaboutus_MouseEnter(object sender, EventArgs e)
        {
            btnaboutus.BackColor = Color.RoyalBlue;
        }

        private void btnaboutus_MouseLeave(object sender, EventArgs e)
        {
            btnaboutus.BackColor = Color.Black;
        }

        private void btnlogout_MouseEnter(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.RoyalBlue;
        }

        private void btnlogout_MouseLeave(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.Black;
        }

        private void btnexit_MouseEnter(object sender, EventArgs e)
        {
            btnexit.BackColor = Color.RoyalBlue;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.BackColor = Color.Red;
        }
    }
}

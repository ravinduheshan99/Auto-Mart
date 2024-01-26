using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    public partial class frm1 : Form
    {

        public frm1()
        {
            InitializeComponent();
        }

        string aun = "admin";
        string apw = "admin123";
        string sun = "staff";
        string spw = "staff123";
        private void btnregister_Click(object sender, EventArgs e)
        {
          
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            lbllogintype.BackColor = Color.Transparent;
            lblun.BackColor = Color.Transparent;
            lblpw.BackColor = Color.Transparent;
            rdbtnadministrator.BackColor = Color.Transparent;
            rdbtnstaff.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (txtun.Text == aun && txtpw.Text == apw && rdbtnadministrator.Checked == true)
            {
                frm2 obj = new frm2();
                obj.Show();
                this.Hide();
                MessageBox.Show("Login Successfull!", "Welcome To Admin Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtun.Text != aun && txtpw.Text != apw && rdbtnadministrator.Checked == true)
            {
                MessageBox.Show("Invalid username & password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtun.Text == aun && txtpw.Text != apw && rdbtnadministrator.Checked == true)
            {
                MessageBox.Show("Invalid password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtun.Text != aun && txtpw.Text == apw && rdbtnadministrator.Checked == true)
            {
                MessageBox.Show("Invalid username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtun.Text == sun && txtpw.Text == spw && rdbtnstaff.Checked == true)
            {
                frm3 obj = new frm3();
                obj.Show();
                this.Hide();
                MessageBox.Show("Login Successfull!", "Welcome To Staff Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtun.Text != sun && txtpw.Text != spw && rdbtnstaff.Checked == true)
            {
                MessageBox.Show("Invalid username & password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtun.Text == sun && txtpw.Text != spw && rdbtnstaff.Checked == true)
            {
                MessageBox.Show("Invalid password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtun.Text != sun && txtpw.Text == spw && rdbtnstaff.Checked == true)
            {
                MessageBox.Show("Invalid username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select the login type and enter the username and password");
            }
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.RoyalBlue;
            
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.Black;
            
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

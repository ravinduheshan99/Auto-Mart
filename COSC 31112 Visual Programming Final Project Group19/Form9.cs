using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    public partial class frm9 : Form
    {
        public frm9()
        {
            InitializeComponent();
        }

        private void btnmainmenu9_Click(object sender, EventArgs e)
        {
            frm2 obj = new frm2();
            obj.Show();
            this.Hide();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            if (txtemployeeno.Text.Length < 3)
            {
                MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtemployeeno.Clear();
                txtemployeeno.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "select fname,lname,jposition,branch,salary,image from Employee where enumber = '" + txtemployeeno.Text + "'";
                    com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("enumber", txtemployeeno.Text);
                    SqlDataReader dr;
                    dr = com.ExecuteReader();

                    if (dr.Read())
                    {

                        txtfn.Text = dr["fname"].ToString();
                        txtln.Text = dr["lname"].ToString();
                        txtjobposition.Text = dr["jposition"].ToString();
                        txtbranch.Text = dr["branch"].ToString();
                        txtbasicsalary.Text = dr["salary"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Employee Not Found.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        txtemployeeno.Clear();
                        txtemployeeno.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnnetsalary_Click(object sender, EventArgs e)
        {
            double sal, extra, tot, etf, netsal;
            int hours;

            hours = int.Parse(txtextrahoursworked.Text);
            extra = (hours * 125);
            txtextraearnings.Text = extra.ToString();
            sal = double.Parse(txtbasicsalary.Text);
            tot = extra + sal;
            txtgrosssalary.Text = tot.ToString();
            etf = tot * 4 / 100;
            txtetf.Text = etf.ToString();
            netsal=tot-etf;
            txtnetsalary.Text = netsal.ToString();
        }

        private void btnclear9_Click(object sender, EventArgs e)
        {
            txtemployeeno.Text = "";
            txtfn.Text = "";
            txtln.Text = "";
            txtjobposition.Text = "";
            txtbranch.Text = "";
            txtbasicsalary.Text = "";
            txtextrahoursworked.Text = "";
            txtextraearnings.Text = "";
            txtgrosssalary.Text = "";
            txtetf.Text = "";
            txtnetsalary.Text = "";
        }

        private void btnclose9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm9_Load(object sender, EventArgs e)
        {

        }
    }
}

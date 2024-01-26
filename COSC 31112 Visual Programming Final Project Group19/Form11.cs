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
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            if (txtcustomerno.Text.Length < 3)
            {
                MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtcustomerno.Clear();
                txtcustomerno.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "insert into Customer(cusno,title,fname,lname,dob,adrs,nic,lphone,hphone,email,make,model,chassisno,status,regno) values('" + txtcustomerno.Text + "','" + cbxtitle.Text + "','" + txtfn.Text + "','" + txtln.Text + "','" + dtpdateofbirth.Text + "','" + txtaddress.Text + "','" + txtnic.Text + "','" + txtlp.Text + "','" + txthp.Text + "','" + txtemail.Text + "','" + cbxmake.Text + "','" + txtmodel.Text + "','" + txtchassis.Text + "','" + cbxstatus.Text + "','" + txtregistrationno.Text + "')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    txtcustomerno.Text = "";
                    cbxtitle.Text = "";
                    txtfn.Text = "";
                    txtln.Text = "";
                    dtpdateofbirth.Text = "";
                    txtaddress.Text = "";
                    txtnic.Text = "";
                    txtlp.Text = "";
                    txthp.Text = "";
                    txtemail.Text = "";
                    cbxmake.Text = "";
                    txtmodel.Text = "";
                    txtchassis.Text = "";
                    cbxstatus.Text = "";
                    txtregistrationno.Text = "";
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

        private void btnupdatecustomer_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            try
            {
                con.Open();
                string sql = "Update customer set title='" + cbxtitle.Text + "',fname='" + txtfn.Text + "',lname='" + txtln.Text + "',dob='" + dtpdateofbirth.Text + "',adrs='" + txtaddress.Text + "',nic='" + txtnic.Text + "',lphone='" + txtlp.Text + "',hphone='" + txthp.Text + "',email='" + txtemail.Text + "',make='" + cbxmake.Text + "',model='" + txtmodel.Text + "',chassisno='" + txtchassis.Text + "',status='" + cbxstatus.Text + "',regno='" + txtregistrationno.Text + "'where cusno='" + txtcustomerno.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                MessageBox.Show("Customer Detail Updated Successfully.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                txtcustomerno.Text = "";
                cbxtitle.Text = "";
                txtfn.Text = "";
                txtln.Text = "";
                dtpdateofbirth.Text = "";
                txtaddress.Text = "";
                txtnic.Text = "";
                txtlp.Text = "";
                txthp.Text = "";
                txtemail.Text = "";
                cbxmake.Text = "";
                txtmodel.Text = "";
                txtchassis.Text = "";
                cbxstatus.Text = "";
                txtregistrationno.Text = "";
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

        private void btnsearchcustomer_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            if (txtcustomerno.Text.Length < 3)
            {
                MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtcustomerno.Clear();
                txtcustomerno.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "select * from Customer where cusno = '" + txtcustomerno.Text + "'";
                    com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("cusno", txtcustomerno.Text);
                    SqlDataReader dr;
                    dr = com.ExecuteReader();

                    if (dr.Read())
                    {
                        cbxtitle.Text = dr["title"].ToString();
                        txtfn.Text = dr["fname"].ToString();
                        txtln.Text = dr["lname"].ToString();
                        dtpdateofbirth.Text = dr["dob"].ToString();
                        txtaddress.Text = dr["adrs"].ToString();
                        txtnic.Text = dr["nic"].ToString();
                        txtlp.Text = dr["lphone"].ToString();
                        txthp.Text = dr["hphone"].ToString();
                        txtemail.Text = dr["email"].ToString();
                        cbxmake.Text = dr["make"].ToString();
                        txtmodel.Text = dr["model"].ToString();
                        txtchassis.Text = dr["chassisno"].ToString();
                        cbxstatus.Text = dr["status"].ToString();
                        txtregistrationno.Text = dr["regno"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Found.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        txtcustomerno.Clear();
                        txtcustomerno.Focus();
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

        private void btndeletecustomer_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            try
            {
                con.Open();
                string sql = "Delete from Customer where cusno = '" + txtcustomerno.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted Successfully", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                txtcustomerno.Text = "";
                cbxtitle.Text = "";
                txtfn.Text = "";
                txtln.Text = "";
                dtpdateofbirth.Text = "";
                txtaddress.Text = "";
                txtnic.Text = "";
                txtlp.Text = "";
                txthp.Text = "";
                txtemail.Text = "";
                cbxmake.Text = "";
                txtmodel.Text = "";
                txtchassis.Text = "";
                cbxstatus.Text = "";
                txtregistrationno.Text = "";
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

        private void btnmainmenu5_Click(object sender, EventArgs e)
        {
            frm3 obj = new frm3();
            obj.Show();
            this.Hide();
        }

        private void btnclear5_Click(object sender, EventArgs e)
        {
            txtcustomerno.Text = "";
            cbxtitle.Text = "";
            txtfn.Text = "";
            txtln.Text = "";
            dtpdateofbirth.Text = "";
            txtaddress.Text = "";
            txtnic.Text = "";
            txtlp.Text = "";
            txthp.Text = "";
            txtemail.Text = "";
            cbxmake.Text = "";
            txtmodel.Text = "";
            txtchassis.Text = "";
            cbxstatus.Text = "";
            txtregistrationno.Text = "";
        }

        private void btnclose5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

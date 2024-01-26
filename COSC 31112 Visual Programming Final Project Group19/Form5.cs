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
    public partial class frm5 : Form
    {
        public frm5()
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

        private void frm5_Load(object sender, EventArgs e)
        {
            cbxtitle.Items.Add("Mr.");
            cbxtitle.Items.Add("Mrs.");
            cbxtitle.Items.Add("Miss.");
            cbxtitle.Items.Add("Dr.");
            cbxtitle.Items.Add("Prof.");
            cbxtitle.Items.Add("Rev.");

            cbxmake.Items.Add("Acura");
            cbxmake.Items.Add("Alfa Romeo");
            cbxmake.Items.Add("AM General");
            cbxmake.Items.Add("Audi");
            cbxmake.Items.Add("BMW");
            cbxmake.Items.Add("Chevrolet");
            cbxmake.Items.Add("Chrysler");
            cbxmake.Items.Add("Daihatsu");
            cbxmake.Items.Add("FIAT");
            cbxmake.Items.Add("Ford");
            cbxmake.Items.Add("Honda");
            cbxmake.Items.Add("Hummer");
            cbxmake.Items.Add("Hyundai");
            cbxmake.Items.Add("Isuzu");
            cbxmake.Items.Add("Jaguar");
            cbxmake.Items.Add("Jeep");
            cbxmake.Items.Add("Kia");
            cbxmake.Items.Add("Land Rover");
            cbxmake.Items.Add("Mazda");
            cbxmake.Items.Add("Mercedes-Benz");
            cbxmake.Items.Add("MINI");
            cbxmake.Items.Add("Mitsubishi");
            cbxmake.Items.Add("Nissan");
            cbxmake.Items.Add("Peugeot");
            cbxmake.Items.Add("Porsche");
            cbxmake.Items.Add("Renault");
            cbxmake.Items.Add("Rolls-Royce");
            cbxmake.Items.Add("Subaru");
            cbxmake.Items.Add("Suzuki");
            cbxmake.Items.Add("Toyota");
            cbxmake.Items.Add("Volkswagen");
            cbxmake.Items.Add("Volvo");

            cbxstatus.Items.Add("Registered");
            cbxstatus.Items.Add("Unregistered");

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
                    com.Parameters.AddWithValue("cusno",txtcustomerno.Text);
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
                        txtregistrationno.Text = dr["regno"].ToString() ;
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Found.","Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                        txtcustomerno.Clear();
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
                string sql = "Delete from Customer where cusno = '"+txtcustomerno.Text+"'";
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
             con.Close ();
            }
        }

        private void btnupdatecustomer_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            try
            {
                con.Open ();
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

        private void btnmainmenu5_Click(object sender, EventArgs e)
        {
            frm2 obj = new frm2();
            obj.Show();
            this.Hide();
        }
    }
}

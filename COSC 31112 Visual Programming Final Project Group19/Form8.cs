using COSC_31112_Visual_Programming_Final_Project_Group19.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    public partial class frm8 : Form
    {
        public frm8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cbxtitle.Items.Add("Mr.");
            cbxtitle.Items.Add("Mrs.");
            cbxtitle.Items.Add("Miss.");
            cbxtitle.Items.Add("Dr.");
            cbxtitle.Items.Add("Prof.");
            cbxtitle.Items.Add("Rev.");

            cbxgender.Items.Add("Male");
            cbxgender.Items.Add("Female");

            cbxbranch.Items.Add("Colombo");
            cbxbranch.Items.Add("Kandy");
            cbxbranch.Items.Add("Galle");
            cbxbranch.Items.Add("Jaffna");
            cbxbranch.Items.Add("Ampara");

            cbxjobposition.Items.Add("Sales Manager");
            cbxjobposition.Items.Add("Sales Representative");
            cbxjobposition.Items.Add("Fleet Sales Manager");
            cbxjobposition.Items.Add("Finance and Insurance Manager");
            cbxjobposition.Items.Add("Customer Service Representative");
            cbxjobposition.Items.Add("Inventory Manager");
            cbxjobposition.Items.Add("Service Advisor");
            cbxjobposition.Items.Add("Mechanic/Technician");
            cbxjobposition.Items.Add("Detailer");
            cbxjobposition.Items.Add("Lot Attendant");
            cbxjobposition.Items.Add("Marketing Manager");
            cbxjobposition.Items.Add("Human Resources Manager");
            cbxjobposition.Items.Add("Accountant/Finance Controller");
            cbxjobposition.Items.Add("Administrative Assistant");
            cbxjobposition.Items.Add("Security Personnel");
            cbxjobposition.Items.Add("Parts and Accessories Specialist");
            cbxjobposition.Items.Add("Delivery Driver");
            cbxjobposition.Items.Add("Online Sales Specialist");
            cbxjobposition.Items.Add("IT Support Specialist");
            cbxjobposition.Items.Add("Legal Counsel");
        }

        private void btnmainmenu8_Click(object sender, EventArgs e)
        {
            frm2 obj = new frm2();
            obj.Show();
            this.Hide();
        }

        private void btnbrowseimage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    pictureBox8.Image = Image.FromFile(filename);
                }
            }
        }
       

        private void btnaddemployee_Click(object sender, EventArgs e)
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
                    string sql = "insert into Employee(enumber,title,fname,lname,gender,dob,adrs,nic,lphone,hphone,email,image,jposition,wstart,wend,branch,salary) values('" + txtemployeeno.Text + "','" + cbxtitle.Text + "','" + txtfn.Text + "','" + txtln.Text + "','" + cbxgender.Text + "','" + dtpdob.Text + "','" + txtaddress.Text + "','" + txtnic.Text + "','" + txtlp.Text + "','" + txthp.Text + "','" + txtemail.Text + "','" + ConvertImageToBinary(pictureBox8.Image) + "','" + cbxjobposition.Text + "','" + dtpworkingsince.Text + "','" + dtpcontractexpiration.Text + "','" +cbxbranch.Text+ "','" +txtsalary.Text+ "')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Successfully", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    txtemployeeno.Text = "";
                    cbxtitle.Text = "";
                    txtfn.Text = "";
                    txtln.Text = "";
                    cbxgender.Text = "";
                    dtpdob.Text = "";
                    txtaddress.Text = "";
                    txtnic.Text = "";
                    txtlp.Text = "";
                    txthp.Text = "";
                    txtemail.Text = "";
                    pictureBox8.Text = "";
                    cbxjobposition.Text = "";
                    dtpworkingsince.Text = "";
                    dtpcontractexpiration.Text = "";
                    cbxbranch.Text = "";
                    txtsalary.Text = "";
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

        private void btnsearchemployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT title,fname,lname,gender,dob,adrs,nic,lphone,hphone,email,jposition,wstart,wend,branch,salary FROM Employee where enumber='" + txtemployeeno.Text + "'", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    cbxtitle.Text = reader["title"].ToString();
                                    txtfn.Text = reader["fname"].ToString();
                                    txtln.Text = reader["lname"].ToString();
                                    cbxgender.Text = reader["gender"].ToString();
                                    dtpdob.Text = reader["dob"].ToString();
                                    txtaddress.Text = reader["adrs"].ToString();
                                    txtnic.Text = reader["nic"].ToString();
                                    txtlp.Text = reader["lphone"].ToString();
                                    txthp.Text = reader["hphone"].ToString();
                                    txtemail.Text = reader["email"].ToString();
                                    cbxjobposition.Text = reader["jposition"].ToString();
                                    dtpworkingsince.Text = reader["wstart"].ToString();
                                    dtpcontractexpiration.Text = reader["wend"].ToString();
                                    cbxbranch.Text = reader["branch"].ToString();
                                    txtsalary.Text = reader["salary"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Employee Does Not Exsist");
                                }
                            }
                        }

                    }
                    using (SqlCommand command1 = new SqlCommand("SELECT image FROM Employee where enumber='" + txtemployeeno.Text + "'", connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command1))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            using (SqlDataReader reader = command1.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Byte[] photo = (byte[])reader["image"];
                                    pictureBox8.Image = ConvertBinaryToImage(photo);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 
Image ConvertBinaryToImage(byte[] data)
    {
        try
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error converting binary to image: {ex.Message}");
            // Handle the ArgumentException appropriately in your application
            return null;
        }
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine($"Error converting binary to image: {ex.Message}");
            // Handle the OutOfMemoryException appropriately in your application
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error converting binary to image: {ex.Message}");
            // Handle other exceptions appropriately in your application
            return null;
        }
    }


    byte[] ConvertImageToBinary(Image img)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Save the image to the MemoryStream
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    // Ensure all data is written to the MemoryStream and then get the byte array
                    ms.Flush();

                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting image to binary: {ex.Message}");
                return null; // Handle the error appropriately in your application
            }
        }


        private void btnupdateemployee_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            try
            {
                con.Open();
                string sql = "Update Employee set title='" + cbxtitle.Text + "',fname='" + txtfn.Text + "',lname='" + txtln.Text + "',gender='" + cbxgender.Text + "',dob='" + dtpdob.Text + "',adrs='" + txtaddress.Text + "',nic='" + txtnic.Text + "',lphone='" + txtlp.Text + "',hphone='" + txthp.Text + "',email='" + txtemail.Text + "',image='" + pictureBox8.Text + "',jposition='" + cbxjobposition.Text + "',wstart='" + dtpworkingsince.Text + "',wend='" + dtpcontractexpiration.Text + "',branch='"+cbxbranch.Text+"',salary='"+txtsalary.Text+"' where enumber='" + txtemployeeno.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                MessageBox.Show("Employee Detail Updated Successfully.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                txtemployeeno.Text = "";
                cbxtitle.Text = "";
                txtfn.Text = "";
                txtln.Text = "";
                dtpdob.Text = "";
                txtaddress.Text = "";
                txtnic.Text = "";
                txtlp.Text = "";
                txthp.Text = "";
                txtemail.Text = "";
                pictureBox8.Text = "";
                cbxjobposition.Text = "";
                dtpworkingsince.Text = "";
                dtpcontractexpiration.Text = "";
                cbxbranch.Text = "";
                txtsalary.Text = "";
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

        private void btndeleteemployee_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            try
            {
                con.Open();
                string sql = "Delete from Employee where enumber = '" + txtemployeeno.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                txtemployeeno.Text = "";
                cbxtitle.Text = "";
                txtfn.Text = "";
                txtln.Text = "";
                dtpdob.Text = "";
                txtaddress.Text = "";
                txtnic.Text = "";
                txtlp.Text = "";
                txthp.Text = "";
                txtemail.Text = "";
                pictureBox8.Text = "";
                cbxjobposition.Text = "";
                dtpworkingsince.Text = "";
                dtpcontractexpiration.Text = "";
                cbxbranch.Text = "";
                txtsalary.Text = "";
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

        private void btnclear8_Click(object sender, EventArgs e)
        {
            txtemployeeno.Text = "";
            cbxtitle.Text = "";
            txtfn.Text = "";
            txtln.Text = "";
            dtpdob.Text = "";
            txtaddress.Text = "";
            txtnic.Text = "";
            txtlp.Text = "";
            txthp.Text = "";
            txtemail.Text = "";
            pictureBox8.Text = "";
            cbxjobposition.Text = "";
            dtpworkingsince.Text = "";
            dtpcontractexpiration.Text = "";
            cbxbranch.Text = "";
            txtsalary.Text = "";
        }

        private void btnclose8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

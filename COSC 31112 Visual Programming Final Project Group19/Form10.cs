﻿using System;
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
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void btnmainmenu4_Click(object sender, EventArgs e)
        {
            frm3 obj = new frm3();
            obj.Show();
            this.Hide();
        }

        private void btnclose4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear4_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            cbxbranch.Text = "";
            date4.Text = "";
            time4.Text = "";
            txtdescription.Text = "";
            txtcontactnumber.Text = "";
            gridLoad();
        }

        private void btndeleteappointment_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                if (MessageBox.Show("Do You Want To Delete This Appointment Detail, Confirm?", "Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string query = "DELETE FROM Appointment WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", txtid.Text); // Assuming clicked_date is the id
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            gridLoad();// Refresh your DataGridView or grid
                            MessageBox.Show("Appointment Detail Successfully Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                          
                            txtid.Text = "";
                            cbxbranch.Text = "";
                            date4.Text = "";
                            time4.Text = "";
                            txtdescription.Text = "";
                            txtcontactnumber.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to Delete Appointment Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("An error occurred: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdateappointment_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    if (MessageBox.Show("Do You Want To Update The Appointment Data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        string query = "UPDATE Appointment SET branch = @branch, date = @date, time = @time, description = @description, contactno = @contactno WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", txtid.Text); // Assuming id is an integer
                            cmd.Parameters.AddWithValue("@branch", cbxbranch.Text);
                            cmd.Parameters.AddWithValue("@date", date4.Text);
                            cmd.Parameters.AddWithValue("@time", time4.Text); // Ensure that the data type matches your database
                            cmd.Parameters.AddWithValue("@description", txtdescription.Text);
                            cmd.Parameters.AddWithValue("@contactno", txtcontactnumber.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appointment successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                gridLoad(); // Reload the data into your DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Failed to update appointment details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnaddappointment_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            if (txtid.Text.Length < 3)
            {
                MessageBox.Show("Please Enter a Valid Appointment Id", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtid.Clear();
                txtid.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "insert into Appointment(id,branch,date,time,description,contactno) values('" + txtid.Text + "','" + cbxbranch.Text + "','" + date4.Text + "','" + time4.Text + "','" + txtdescription.Text + "','" + txtcontactnumber.Text + "')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Appointment Added Successfully", "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridLoad();
                    txtid.Text = "";
                    date4.Text = "";
                    time4.Text = "";
                    cbxbranch.Text = "";
                    txtdescription.Text = "";
                    txtcontactnumber.Text = "";
                    gridLoad();
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

        private void btnsearchappointment_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();
                string sql = "select * from Appointment where date='" + date4.Text + "'";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView10.DataSource = dataTable;
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

        private void frm10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group19DataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.group19DataSet.Appointment);

            cbxbranch.Items.Add("Colombo");
            cbxbranch.Items.Add("Kandy");
            cbxbranch.Items.Add("Galle");
            cbxbranch.Items.Add("Jaffna");
            cbxbranch.Items.Add("Ampara");

            lblbranch.BackColor = Color.Transparent;
            lblid.BackColor = Color.Transparent;
            lbldescription.BackColor = Color.Transparent;
            lblcontactnumber.BackColor = Color.Transparent;

            gridLoad();
        }

        private void gridLoad()
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Appointment ", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            dataGridView10.DataSource = ds1.Tables[0];

        }

        private string clicked_id;
        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (e.RowIndex >= 0)
            {

                clicked_id = dataGridView10.Rows[e.RowIndex].Cells[0].Value.ToString();
                string query = "SELECT * FROM Appointment WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", clicked_id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtid.Text = ds.Tables[0].Rows[0][0].ToString();
                        cbxbranch.Text = ds.Tables[0].Rows[0][1].ToString();
                        date4.Text = ds.Tables[0].Rows[0][2].ToString();
                        time4.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtdescription.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtcontactnumber.Text = ds.Tables[0].Rows[0][5].ToString();
                    }
                    con.Close();
                }
            }
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

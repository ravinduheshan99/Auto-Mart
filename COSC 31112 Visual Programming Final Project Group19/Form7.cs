using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    public partial class frm7 : Form
    {
        public frm7()
        {
            InitializeComponent();
        }

        private void btnmainmenu7_Click(object sender, EventArgs e)
        {
            frm2 obj = new frm2();
            obj.Show();
            this.Hide();

        }

        private void frm7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group19DataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.group19DataSet.Inventory);

            cbxbrand.Items.Add("Acura");
            cbxbrand.Items.Add("Alfa Romeo");
            cbxbrand.Items.Add("AM General");
            cbxbrand.Items.Add("Audi");
            cbxbrand.Items.Add("BMW");
            cbxbrand.Items.Add("Chevrolet");
            cbxbrand.Items.Add("Chrysler");
            cbxbrand.Items.Add("Daihatsu");
            cbxbrand.Items.Add("FIAT");
            cbxbrand.Items.Add("Ford");
            cbxbrand.Items.Add("Honda");
            cbxbrand.Items.Add("Hummer");
            cbxbrand.Items.Add("Hyundai");
            cbxbrand.Items.Add("Isuzu");
            cbxbrand.Items.Add("Jaguar");
            cbxbrand.Items.Add("Jeep");
            cbxbrand.Items.Add("Kia");
            cbxbrand.Items.Add("Land Rover");
            cbxbrand.Items.Add("Mazda");
            cbxbrand.Items.Add("Mercedes-Benz");
            cbxbrand.Items.Add("MINI");
            cbxbrand.Items.Add("Mitsubishi");
            cbxbrand.Items.Add("Nissan");
            cbxbrand.Items.Add("Peugeot");
            cbxbrand.Items.Add("Porsche");
            cbxbrand.Items.Add("Renault");
            cbxbrand.Items.Add("Rolls-Royce");
            cbxbrand.Items.Add("Subaru");
            cbxbrand.Items.Add("Suzuki");
            cbxbrand.Items.Add("Toyota");
            cbxbrand.Items.Add("Volkswagen");
            cbxbrand.Items.Add("Volvo");

            cbxvehicletype.Items.Add("Car");
            cbxvehicletype.Items.Add("Van");
            cbxvehicletype.Items.Add("Jeep");
            cbxvehicletype.Items.Add("Bike");
            cbxvehicletype.Items.Add("Threewheeler");
            cbxvehicletype.Items.Add("Bus");
            cbxvehicletype.Items.Add("Lorry");
            cbxvehicletype.Items.Add("Heavy Vehicle");

            cbxcondition.Items.Add("Brand New");
            cbxcondition.Items.Add("Used");
            cbxcondition.Items.Add("Reconditioned");

            cbxtransmission.Items.Add("Auto");
            cbxtransmission.Items.Add("Manual");
            cbxtransmission.Items.Add("Tiptronic");
            cbxtransmission.Items.Add("Other");

            cbxbranch.Items.Add("Colombo");
            cbxbranch.Items.Add("Kandy");
            cbxbranch.Items.Add("Galle");
            cbxbranch.Items.Add("Jaffna");
            cbxbranch.Items.Add("Ampara");

            cbxfueltype.Items.Add("Petrol");
            cbxfueltype.Items.Add("Diesel");
            cbxfueltype.Items.Add("Hybrid");
            cbxfueltype.Items.Add("Electronic");
            cbxfueltype.Items.Add("Other");

            cbxbodytype.Items.Add("Convertible");
            cbxbodytype.Items.Add("Coup");
            cbxbodytype.Items.Add("Hatchback");
            cbxbodytype.Items.Add("Minivan");
            cbxbodytype.Items.Add("Pickup");
            cbxbodytype.Items.Add("sedan");
            cbxbodytype.Items.Add("SUV");
            cbxbodytype.Items.Add("Wagon");
        }

        private void btnaddvehicle_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com;

            if (txtvehicleregno.Text.Length < 3)
            {
                MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtvehicleregno.Clear();
                txtvehicleregno.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "insert into Inventory(brand,vtype,condition,year,transmission,branch,ftype,btype,vregno,chassisno,ecapacity,price,qty) values('" + cbxbrand.Text + "','" + cbxvehicletype.Text + "','" + cbxcondition.Text + "','" + txtyear.Text + "','" + cbxtransmission.Text + "','" + cbxbranch.Text + "','" + cbxfueltype.Text + "','" + cbxbodytype.Text + "','" + txtvehicleregno.Text + "','" + txtchassisno.Text + "','" + txtenginecapacity.Text + "','" + txtprice.Text + "','"+txtqty.Text+"')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    gridLoad();
                    MessageBox.Show("Item Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                    cbxbrand.Text = "";
                    cbxvehicletype.Text = "";
                    cbxcondition.Text = "";
                    txtyear.Text = "";
                    cbxtransmission.Text = "";
                    cbxbranch.Text = "";
                    cbxfueltype.Text = "";
                    cbxbodytype.Text = "";
                    txtvehicleregno.Text = "";
                    txtchassisno.Text = "";
                    txtenginecapacity.Text = "";
                    txtprice.Text = "";
                    txtqty.Text = "";
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

        private void btnsearchvehicle_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();
                string sql = "select * from Inventory where branch='" + cbxbranch.Text + "'";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView7.DataSource = dataTable;
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

        private void btnclose7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndeletevehicle_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                if (MessageBox.Show("Do You Want To Delete This Vehicle Detail, Confirm?", "Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string query = "DELETE FROM Inventory WHERE vregno = @vregno";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@vregno", txtvehicleregno.Text); 
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            gridLoad();// Refresh your DataGridView or grid
                            MessageBox.Show("Vehicle Detail Successfully Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
   
                            cbxbrand.Text = "";
                            cbxvehicletype.Text = "";
                            cbxcondition.Text = "";
                            txtyear.Text = "";
                            cbxtransmission.Text = "";
                            cbxbranch.Text = "";
                            cbxfueltype.Text = "";
                            cbxbodytype.Text = "";
                            txtvehicleregno.Text = "";
                            txtchassisno.Text = "";
                            txtenginecapacity.Text = "";
                            txtprice.Text = "";
                            txtqty.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to Delete Vehicle Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("An error occurred: " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear7_Click(object sender, EventArgs e)
        {
            cbxbrand.Text = "";
            cbxvehicletype.Text = "";
            cbxcondition.Text = "";
            txtyear.Text = "";
            cbxtransmission.Text = "";
            cbxbranch.Text = "";
            cbxfueltype.Text = "";
            cbxbodytype.Text = "";
            txtvehicleregno.Text = "";
            txtchassisno.Text = "";
            txtenginecapacity.Text = "";
            txtprice.Text = "";
            txtqty.Text = "";
            gridLoad();
        }

        private void btnupdatevehicle_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    if (MessageBox.Show("Do You Want To Update The Vehicle Data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        string query = "UPDATE Inventory SET brand = @brand, vtype = @vtype, condition = @condition, year = @year, transmission = @transmission , branch=@branch , ftype=@ftype , btype=@btype , chassisno=@chassisno , ecapacity=@ecapacity , price=@price , qty=@qty  WHERE vregno = @vregno";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@brand", cbxbrand.Text); // Assuming id is an integer
                            cmd.Parameters.AddWithValue("@vtype", cbxvehicletype.Text);
                            cmd.Parameters.AddWithValue("@condition", cbxcondition.Text);
                            cmd.Parameters.AddWithValue("@year", txtyear.Text); // Ensure that the data type matches your database
                            cmd.Parameters.AddWithValue("@transmission", cbxtransmission.Text);
                            cmd.Parameters.AddWithValue("@branch", cbxbranch.Text);
                            cmd.Parameters.AddWithValue("@ftype", cbxfueltype.Text);
                            cmd.Parameters.AddWithValue("@btype", cbxbodytype.Text);
                            cmd.Parameters.AddWithValue("@vregno", txtvehicleregno.Text); // Ensure that the data type matches your database
                            cmd.Parameters.AddWithValue("@chassisno", txtchassisno.Text);
                            cmd.Parameters.AddWithValue("@ecapacity", txtenginecapacity.Text);
                            cmd.Parameters.AddWithValue("@price", txtprice.Text);
                            cmd.Parameters.AddWithValue("@qty", txtqty.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                gridLoad(); // Reload the data into your DataGridView
                                MessageBox.Show("Vehicle Detail Successfully Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                cbxbrand.Text = "";
                                cbxvehicletype.Text = "";
                                cbxcondition.Text = "";
                                txtyear.Text = "";
                                cbxtransmission.Text = "";
                                cbxbranch.Text = "";
                                cbxfueltype.Text = "";
                                cbxbodytype.Text = "";
                                txtvehicleregno.Text = "";
                                txtchassisno.Text = "";
                                txtenginecapacity.Text = "";
                                txtprice.Text = "";
                                txtqty.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to Update Vehicle Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

       

        

        private void lblvehicleregno_Click(object sender, EventArgs e)
        {

        }

        private void lblchassisno_Click(object sender, EventArgs e)
        {

        }

        private void lblenginecapacity_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void txtvehicleregno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtchassisno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtenginecapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbladdoreditvehicle_Click(object sender, EventArgs e)
        {

        }

        private void cbxcondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxbrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxbranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxbodytype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxtransmission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxfueltype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxvehicletype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblfueltype_Click(object sender, EventArgs e)
        {

        }

        private void lblcondition_Click(object sender, EventArgs e)
        {

        }

        private void lblbranch_Click(object sender, EventArgs e)
        {

        }

        private void lblbodytype_Click(object sender, EventArgs e)
        {

        }

        private void lbltransmission_Click(object sender, EventArgs e)
        {

        }

        private void lblmanufactureyear_Click(object sender, EventArgs e)
        {

        }

        private void lblvehicletype_Click(object sender, EventArgs e)
        {

        }

        private void lblbrand_Click(object sender, EventArgs e)
        {

        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblqty_Click(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private string clicked_brand;
        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            if (e.RowIndex >= 0)
            {

                clicked_brand = dataGridView7.Rows[e.RowIndex].Cells[0].Value.ToString();
                string query = "SELECT * FROM Inventory WHERE brand = @brand";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@brand", clicked_brand);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cbxbrand.Text = ds.Tables[0].Rows[0][0].ToString();
                        cbxvehicletype.Text = ds.Tables[0].Rows[0][1].ToString();
                        cbxcondition.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtyear.Text = ds.Tables[0].Rows[0][3].ToString();
                        cbxtransmission.Text = ds.Tables[0].Rows[0][4].ToString();
                        cbxbranch.Text = ds.Tables[0].Rows[0][5].ToString();
                        cbxfueltype.Text = ds.Tables[0].Rows[0][6].ToString();
                        cbxbodytype.Text = ds.Tables[0].Rows[0][7].ToString();
                        txtvehicleregno.Text = ds.Tables[0].Rows[0][8].ToString();
                        txtchassisno.Text = ds.Tables[0].Rows[0][9].ToString();
                        txtenginecapacity.Text = ds.Tables[0].Rows[0][10].ToString();
                        txtprice.Text = ds.Tables[0].Rows[0][11].ToString();
                        txtqty.Text = ds.Tables[0].Rows[0][12].ToString();
                    }
                    con.Close();
                }
            }
        }

        private void gridLoad()
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory ", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            dataGridView7.DataSource = ds1.Tables[0];

        }
    }
}

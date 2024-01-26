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
    public partial class frm6 : Form
    {
        public frm6()
        {
            InitializeComponent();
        }

        private void lblcustomerno_Click(object sender, EventArgs e)
        {

        }

        private void btnsearchvehicle_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();
                string sql = "select * from Inventory where branch='" + cbxbranch.Text + "' or brand='" + cbxbrand.Text + "' or vtype='" + cbxvehicletype.Text +"' or condition='" + cbxcondition.Text +"' or year='" + txtyear.Text + "' or transmission='" + cbxtransmission.Text + "' or ftype='" + cbxfueltype.Text + "' or btype='" + cbxbodytype.Text + "' or vregno='" + txtvehicleregno.Text + "' or ecapacity='" + txtenginecapacity.Text + "' or price='" + txtprice.Text + "' or qty='" + txtqty.Text +"'";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView6.DataSource = dataTable;
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

        private void frm6_Load(object sender, EventArgs e)
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

            gridLoad();
        }

        private void btnclose7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmainmenu7_Click(object sender, EventArgs e)
        {
            frm2 obj = new frm2();
            obj.Show();
            this.Hide();
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

        private void gridLoad()
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory ", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            dataGridView6.DataSource = ds1.Tables[0];

        }
    }
}

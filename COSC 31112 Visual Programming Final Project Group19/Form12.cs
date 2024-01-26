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
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void btnsearchvehicle_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-9HG1TI6\\SQLEXPRESS;Initial Catalog=Group19;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();
                string sql = "select * from Inventory where branch='" + cbxbranch.Text + "' or brand='" + cbxbrand.Text + "' or vtype='" + cbxvehicletype.Text + "' or condition='" + cbxcondition.Text + "' or year='" + txtyear.Text + "' or transmission='" + cbxtransmission.Text + "' or ftype='" + cbxfueltype.Text + "' or btype='" + cbxbodytype.Text + "' or vregno='" + txtvehicleregno.Text + "' or ecapacity='" + txtenginecapacity.Text + "' or price='" + txtprice.Text + "' or qty='" + txtqty.Text + "'";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView6.DataSource = dataTable;

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

        private void btnmainmenu7_Click(object sender, EventArgs e)
        {
            frm3 obj = new frm3();
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
        }

        private void btnclose7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    partial class frm12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm12));
            this.lblpersonaldetails = new System.Windows.Forms.Label();
            this.vtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.vregnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointments = new COSC_31112_Visual_Programming_Final_Project_Group19.Appointments();
            this.cbxcondition = new System.Windows.Forms.ComboBox();
            this.cbxbrand = new System.Windows.Forms.ComboBox();
            this.cbxbranch = new System.Windows.Forms.ComboBox();
            this.cbxbodytype = new System.Windows.Forms.ComboBox();
            this.cbxtransmission = new System.Windows.Forms.ComboBox();
            this.cbxfueltype = new System.Windows.Forms.ComboBox();
            this.lblfueltype = new System.Windows.Forms.Label();
            this.cbxvehicletype = new System.Windows.Forms.ComboBox();
            this.lblcondition = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lblbodytype = new System.Windows.Forms.Label();
            this.lbltransmission = new System.Windows.Forms.Label();
            this.lblmanufactureyear = new System.Windows.Forms.Label();
            this.lblvehicletype = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtenginecapacity = new System.Windows.Forms.TextBox();
            this.txtchassisno = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtvehicleregno = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblenginecapacity = new System.Windows.Forms.Label();
            this.lblchassisno = new System.Windows.Forms.Label();
            this.lblvehicleregno = new System.Windows.Forms.Label();
            this.btnmainmenu7 = new System.Windows.Forms.Button();
            this.btnclose7 = new System.Windows.Forms.Button();
            this.btnsearchvehicle = new System.Windows.Forms.Button();
            this.inventoryTableAdapter = new COSC_31112_Visual_Programming_Final_Project_Group19.AppointmentsTableAdapters.InventoryTableAdapter();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnclear7 = new System.Windows.Forms.Button();
            this.lblinventory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpersonaldetails
            // 
            this.lblpersonaldetails.AutoSize = true;
            this.lblpersonaldetails.BackColor = System.Drawing.Color.Black;
            this.lblpersonaldetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonaldetails.ForeColor = System.Drawing.Color.White;
            this.lblpersonaldetails.Location = new System.Drawing.Point(11, 75);
            this.lblpersonaldetails.Name = "lblpersonaldetails";
            this.lblpersonaldetails.Size = new System.Drawing.Size(60, 20);
            this.lblpersonaldetails.TabIndex = 162;
            this.lblpersonaldetails.Text = "Filters :";
            // 
            // vtypeDataGridViewTextBoxColumn
            // 
            this.vtypeDataGridViewTextBoxColumn.DataPropertyName = "vtype";
            this.vtypeDataGridViewTextBoxColumn.HeaderText = "vtype";
            this.vtypeDataGridViewTextBoxColumn.Name = "vtypeDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // transmissionDataGridViewTextBoxColumn
            // 
            this.transmissionDataGridViewTextBoxColumn.DataPropertyName = "transmission";
            this.transmissionDataGridViewTextBoxColumn.HeaderText = "transmission";
            this.transmissionDataGridViewTextBoxColumn.Name = "transmissionDataGridViewTextBoxColumn";
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            // 
            // ftypeDataGridViewTextBoxColumn
            // 
            this.ftypeDataGridViewTextBoxColumn.DataPropertyName = "ftype";
            this.ftypeDataGridViewTextBoxColumn.HeaderText = "ftype";
            this.ftypeDataGridViewTextBoxColumn.Name = "ftypeDataGridViewTextBoxColumn";
            // 
            // btypeDataGridViewTextBoxColumn
            // 
            this.btypeDataGridViewTextBoxColumn.DataPropertyName = "btype";
            this.btypeDataGridViewTextBoxColumn.HeaderText = "btype";
            this.btypeDataGridViewTextBoxColumn.Name = "btypeDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.vtypeDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.transmissionDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.ftypeDataGridViewTextBoxColumn,
            this.btypeDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.vregnoDataGridViewTextBoxColumn,
            this.ecapacityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.inventoryBindingSource1;
            this.dataGridView6.Location = new System.Drawing.Point(301, 97);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(741, 340);
            this.dataGridView6.TabIndex = 161;
            // 
            // vregnoDataGridViewTextBoxColumn
            // 
            this.vregnoDataGridViewTextBoxColumn.DataPropertyName = "vregno";
            this.vregnoDataGridViewTextBoxColumn.HeaderText = "vregno";
            this.vregnoDataGridViewTextBoxColumn.Name = "vregnoDataGridViewTextBoxColumn";
            // 
            // ecapacityDataGridViewTextBoxColumn
            // 
            this.ecapacityDataGridViewTextBoxColumn.DataPropertyName = "ecapacity";
            this.ecapacityDataGridViewTextBoxColumn.HeaderText = "ecapacity";
            this.ecapacityDataGridViewTextBoxColumn.Name = "ecapacityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.appointments;
            // 
            // appointments
            // 
            this.appointments.DataSetName = "Appointments";
            this.appointments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxcondition
            // 
            this.cbxcondition.FormattingEnabled = true;
            this.cbxcondition.Location = new System.Drawing.Point(174, 151);
            this.cbxcondition.Name = "cbxcondition";
            this.cbxcondition.Size = new System.Drawing.Size(121, 21);
            this.cbxcondition.TabIndex = 154;
            // 
            // cbxbrand
            // 
            this.cbxbrand.FormattingEnabled = true;
            this.cbxbrand.Location = new System.Drawing.Point(174, 97);
            this.cbxbrand.Name = "cbxbrand";
            this.cbxbrand.Size = new System.Drawing.Size(121, 21);
            this.cbxbrand.TabIndex = 155;
            // 
            // cbxbranch
            // 
            this.cbxbranch.FormattingEnabled = true;
            this.cbxbranch.Location = new System.Drawing.Point(174, 232);
            this.cbxbranch.Name = "cbxbranch";
            this.cbxbranch.Size = new System.Drawing.Size(121, 21);
            this.cbxbranch.TabIndex = 156;
            // 
            // cbxbodytype
            // 
            this.cbxbodytype.FormattingEnabled = true;
            this.cbxbodytype.Location = new System.Drawing.Point(174, 286);
            this.cbxbodytype.Name = "cbxbodytype";
            this.cbxbodytype.Size = new System.Drawing.Size(121, 21);
            this.cbxbodytype.TabIndex = 157;
            // 
            // cbxtransmission
            // 
            this.cbxtransmission.FormattingEnabled = true;
            this.cbxtransmission.Location = new System.Drawing.Point(174, 204);
            this.cbxtransmission.Name = "cbxtransmission";
            this.cbxtransmission.Size = new System.Drawing.Size(121, 21);
            this.cbxtransmission.TabIndex = 158;
            // 
            // cbxfueltype
            // 
            this.cbxfueltype.FormattingEnabled = true;
            this.cbxfueltype.Location = new System.Drawing.Point(174, 259);
            this.cbxfueltype.Name = "cbxfueltype";
            this.cbxfueltype.Size = new System.Drawing.Size(121, 21);
            this.cbxfueltype.TabIndex = 159;
            // 
            // lblfueltype
            // 
            this.lblfueltype.AutoSize = true;
            this.lblfueltype.BackColor = System.Drawing.Color.Black;
            this.lblfueltype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfueltype.ForeColor = System.Drawing.Color.White;
            this.lblfueltype.Location = new System.Drawing.Point(35, 264);
            this.lblfueltype.Name = "lblfueltype";
            this.lblfueltype.Size = new System.Drawing.Size(69, 17);
            this.lblfueltype.TabIndex = 153;
            this.lblfueltype.Text = "Fuel Type :";
            // 
            // cbxvehicletype
            // 
            this.cbxvehicletype.FormattingEnabled = true;
            this.cbxvehicletype.Location = new System.Drawing.Point(174, 124);
            this.cbxvehicletype.Name = "cbxvehicletype";
            this.cbxvehicletype.Size = new System.Drawing.Size(121, 21);
            this.cbxvehicletype.TabIndex = 160;
            // 
            // lblcondition
            // 
            this.lblcondition.AutoSize = true;
            this.lblcondition.BackColor = System.Drawing.Color.Black;
            this.lblcondition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondition.ForeColor = System.Drawing.Color.White;
            this.lblcondition.Location = new System.Drawing.Point(35, 156);
            this.lblcondition.Name = "lblcondition";
            this.lblcondition.Size = new System.Drawing.Size(71, 17);
            this.lblcondition.TabIndex = 148;
            this.lblcondition.Text = "Condition :";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.BackColor = System.Drawing.Color.Black;
            this.lblbranch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranch.ForeColor = System.Drawing.Color.White;
            this.lblbranch.Location = new System.Drawing.Point(35, 237);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(54, 17);
            this.lblbranch.TabIndex = 146;
            this.lblbranch.Text = "Branch :";
            // 
            // lblbodytype
            // 
            this.lblbodytype.AutoSize = true;
            this.lblbodytype.BackColor = System.Drawing.Color.Black;
            this.lblbodytype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbodytype.ForeColor = System.Drawing.Color.White;
            this.lblbodytype.Location = new System.Drawing.Point(35, 291);
            this.lblbodytype.Name = "lblbodytype";
            this.lblbodytype.Size = new System.Drawing.Size(75, 17);
            this.lblbodytype.TabIndex = 147;
            this.lblbodytype.Text = "Body Type :";
            // 
            // lbltransmission
            // 
            this.lbltransmission.AutoSize = true;
            this.lbltransmission.BackColor = System.Drawing.Color.Black;
            this.lbltransmission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransmission.ForeColor = System.Drawing.Color.White;
            this.lbltransmission.Location = new System.Drawing.Point(35, 209);
            this.lbltransmission.Name = "lbltransmission";
            this.lbltransmission.Size = new System.Drawing.Size(90, 17);
            this.lbltransmission.TabIndex = 150;
            this.lbltransmission.Text = "Transmission :";
            // 
            // lblmanufactureyear
            // 
            this.lblmanufactureyear.AutoSize = true;
            this.lblmanufactureyear.BackColor = System.Drawing.Color.Black;
            this.lblmanufactureyear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanufactureyear.ForeColor = System.Drawing.Color.White;
            this.lblmanufactureyear.Location = new System.Drawing.Point(34, 182);
            this.lblmanufactureyear.Name = "lblmanufactureyear";
            this.lblmanufactureyear.Size = new System.Drawing.Size(135, 17);
            this.lblmanufactureyear.TabIndex = 149;
            this.lblmanufactureyear.Text = "Year Of Manufacture :";
            // 
            // lblvehicletype
            // 
            this.lblvehicletype.AutoSize = true;
            this.lblvehicletype.BackColor = System.Drawing.Color.Black;
            this.lblvehicletype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehicletype.ForeColor = System.Drawing.Color.White;
            this.lblvehicletype.Location = new System.Drawing.Point(35, 129);
            this.lblvehicletype.Name = "lblvehicletype";
            this.lblvehicletype.Size = new System.Drawing.Size(86, 17);
            this.lblvehicletype.TabIndex = 151;
            this.lblvehicletype.Text = "Vehicle Type :";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.Color.Black;
            this.lblbrand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.ForeColor = System.Drawing.Color.White;
            this.lblbrand.Location = new System.Drawing.Point(35, 102);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(49, 17);
            this.lblbrand.TabIndex = 152;
            this.lblbrand.Text = "Brand :";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(174, 417);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(121, 20);
            this.txtqty.TabIndex = 141;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(174, 391);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(121, 20);
            this.txtprice.TabIndex = 142;
            // 
            // txtenginecapacity
            // 
            this.txtenginecapacity.Location = new System.Drawing.Point(174, 365);
            this.txtenginecapacity.Name = "txtenginecapacity";
            this.txtenginecapacity.Size = new System.Drawing.Size(121, 20);
            this.txtenginecapacity.TabIndex = 143;
            // 
            // txtchassisno
            // 
            this.txtchassisno.Location = new System.Drawing.Point(174, 339);
            this.txtchassisno.Name = "txtchassisno";
            this.txtchassisno.Size = new System.Drawing.Size(121, 20);
            this.txtchassisno.TabIndex = 144;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(175, 178);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(120, 20);
            this.txtyear.TabIndex = 145;
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.Black;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.White;
            this.lblqty.Location = new System.Drawing.Point(37, 420);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(63, 17);
            this.lblqty.TabIndex = 135;
            this.lblqty.Text = "Quantity :";
            // 
            // txtvehicleregno
            // 
            this.txtvehicleregno.Location = new System.Drawing.Point(174, 313);
            this.txtvehicleregno.Name = "txtvehicleregno";
            this.txtvehicleregno.Size = new System.Drawing.Size(121, 20);
            this.txtvehicleregno.TabIndex = 140;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Black;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.White;
            this.lblprice.Location = new System.Drawing.Point(37, 395);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(43, 17);
            this.lblprice.TabIndex = 136;
            this.lblprice.Text = "Price :";
            // 
            // lblenginecapacity
            // 
            this.lblenginecapacity.AutoSize = true;
            this.lblenginecapacity.BackColor = System.Drawing.Color.Black;
            this.lblenginecapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenginecapacity.ForeColor = System.Drawing.Color.White;
            this.lblenginecapacity.Location = new System.Drawing.Point(36, 369);
            this.lblenginecapacity.Name = "lblenginecapacity";
            this.lblenginecapacity.Size = new System.Drawing.Size(107, 17);
            this.lblenginecapacity.TabIndex = 139;
            this.lblenginecapacity.Text = "Engine Capacity :";
            // 
            // lblchassisno
            // 
            this.lblchassisno.AutoSize = true;
            this.lblchassisno.BackColor = System.Drawing.Color.Black;
            this.lblchassisno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchassisno.ForeColor = System.Drawing.Color.White;
            this.lblchassisno.Location = new System.Drawing.Point(35, 343);
            this.lblchassisno.Name = "lblchassisno";
            this.lblchassisno.Size = new System.Drawing.Size(80, 17);
            this.lblchassisno.TabIndex = 137;
            this.lblchassisno.Text = "Chassis No :";
            // 
            // lblvehicleregno
            // 
            this.lblvehicleregno.AutoSize = true;
            this.lblvehicleregno.BackColor = System.Drawing.Color.Black;
            this.lblvehicleregno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehicleregno.ForeColor = System.Drawing.Color.White;
            this.lblvehicleregno.Location = new System.Drawing.Point(35, 317);
            this.lblvehicleregno.Name = "lblvehicleregno";
            this.lblvehicleregno.Size = new System.Drawing.Size(112, 13);
            this.lblvehicleregno.TabIndex = 138;
            this.lblvehicleregno.Text = "Vehicle Register No :";
            // 
            // btnmainmenu7
            // 
            this.btnmainmenu7.BackColor = System.Drawing.Color.Black;
            this.btnmainmenu7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmainmenu7.ForeColor = System.Drawing.Color.White;
            this.btnmainmenu7.Location = new System.Drawing.Point(365, 463);
            this.btnmainmenu7.Name = "btnmainmenu7";
            this.btnmainmenu7.Size = new System.Drawing.Size(127, 45);
            this.btnmainmenu7.TabIndex = 131;
            this.btnmainmenu7.Text = "Main Menu";
            this.btnmainmenu7.UseVisualStyleBackColor = false;
            this.btnmainmenu7.Click += new System.EventHandler(this.btnmainmenu7_Click);
            // 
            // btnclose7
            // 
            this.btnclose7.BackColor = System.Drawing.Color.Red;
            this.btnclose7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose7.ForeColor = System.Drawing.Color.White;
            this.btnclose7.Location = new System.Drawing.Point(865, 463);
            this.btnclose7.Name = "btnclose7";
            this.btnclose7.Size = new System.Drawing.Size(127, 45);
            this.btnclose7.TabIndex = 132;
            this.btnclose7.Text = "Close";
            this.btnclose7.UseVisualStyleBackColor = false;
            this.btnclose7.Click += new System.EventHandler(this.btnclose7_Click);
            // 
            // btnsearchvehicle
            // 
            this.btnsearchvehicle.BackColor = System.Drawing.Color.Black;
            this.btnsearchvehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearchvehicle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchvehicle.ForeColor = System.Drawing.Color.White;
            this.btnsearchvehicle.Location = new System.Drawing.Point(37, 463);
            this.btnsearchvehicle.Name = "btnsearchvehicle";
            this.btnsearchvehicle.Size = new System.Drawing.Size(258, 45);
            this.btnsearchvehicle.TabIndex = 133;
            this.btnsearchvehicle.Text = "Search Vehicle";
            this.btnsearchvehicle.UseVisualStyleBackColor = false;
            this.btnsearchvehicle.Click += new System.EventHandler(this.btnsearchvehicle_Click);
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.appointments;
            // 
            // btnclear7
            // 
            this.btnclear7.BackColor = System.Drawing.Color.Black;
            this.btnclear7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear7.ForeColor = System.Drawing.Color.White;
            this.btnclear7.Location = new System.Drawing.Point(606, 463);
            this.btnclear7.Name = "btnclear7";
            this.btnclear7.Size = new System.Drawing.Size(127, 45);
            this.btnclear7.TabIndex = 134;
            this.btnclear7.Text = "Clear";
            this.btnclear7.UseVisualStyleBackColor = false;
            this.btnclear7.Click += new System.EventHandler(this.btnclear7_Click);
            // 
            // lblinventory
            // 
            this.lblinventory.AutoSize = true;
            this.lblinventory.BackColor = System.Drawing.Color.Black;
            this.lblinventory.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinventory.ForeColor = System.Drawing.Color.White;
            this.lblinventory.Location = new System.Drawing.Point(423, 22);
            this.lblinventory.Name = "lblinventory";
            this.lblinventory.Size = new System.Drawing.Size(250, 54);
            this.lblinventory.TabIndex = 130;
            this.lblinventory.Text = "INVENTORY";
            // 
            // frm12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 530);
            this.Controls.Add(this.lblpersonaldetails);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.cbxcondition);
            this.Controls.Add(this.cbxbrand);
            this.Controls.Add(this.cbxbranch);
            this.Controls.Add(this.cbxbodytype);
            this.Controls.Add(this.cbxtransmission);
            this.Controls.Add(this.cbxfueltype);
            this.Controls.Add(this.lblfueltype);
            this.Controls.Add(this.cbxvehicletype);
            this.Controls.Add(this.lblcondition);
            this.Controls.Add(this.lblbranch);
            this.Controls.Add(this.lblbodytype);
            this.Controls.Add(this.lbltransmission);
            this.Controls.Add(this.lblmanufactureyear);
            this.Controls.Add(this.lblvehicletype);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtenginecapacity);
            this.Controls.Add(this.txtchassisno);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.txtvehicleregno);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblenginecapacity);
            this.Controls.Add(this.lblchassisno);
            this.Controls.Add(this.lblvehicleregno);
            this.Controls.Add(this.btnmainmenu7);
            this.Controls.Add(this.btnclose7);
            this.Controls.Add(this.btnsearchvehicle);
            this.Controls.Add(this.btnclear7);
            this.Controls.Add(this.lblinventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm12";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpersonaldetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn vregnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private Appointments appointments;
        private System.Windows.Forms.ComboBox cbxcondition;
        private System.Windows.Forms.ComboBox cbxbrand;
        private System.Windows.Forms.ComboBox cbxbranch;
        private System.Windows.Forms.ComboBox cbxbodytype;
        private System.Windows.Forms.ComboBox cbxtransmission;
        private System.Windows.Forms.ComboBox cbxfueltype;
        private System.Windows.Forms.Label lblfueltype;
        private System.Windows.Forms.ComboBox cbxvehicletype;
        private System.Windows.Forms.Label lblcondition;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lblbodytype;
        private System.Windows.Forms.Label lbltransmission;
        private System.Windows.Forms.Label lblmanufactureyear;
        private System.Windows.Forms.Label lblvehicletype;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtenginecapacity;
        private System.Windows.Forms.TextBox txtchassisno;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtvehicleregno;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblenginecapacity;
        private System.Windows.Forms.Label lblchassisno;
        private System.Windows.Forms.Label lblvehicleregno;
        private System.Windows.Forms.Button btnmainmenu7;
        private System.Windows.Forms.Button btnclose7;
        private System.Windows.Forms.Button btnsearchvehicle;
        private AppointmentsTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Button btnclear7;
        private System.Windows.Forms.Label lblinventory;
    }
}
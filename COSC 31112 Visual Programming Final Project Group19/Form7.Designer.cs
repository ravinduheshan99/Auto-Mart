namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    partial class frm7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm7));
            this.btndeletevehicle = new System.Windows.Forms.Button();
            this.btnmainmenu7 = new System.Windows.Forms.Button();
            this.btnclose7 = new System.Windows.Forms.Button();
            this.btnsearchvehicle = new System.Windows.Forms.Button();
            this.btnclear7 = new System.Windows.Forms.Button();
            this.btnupdatevehicle = new System.Windows.Forms.Button();
            this.btnaddvehicle = new System.Windows.Forms.Button();
            this.lblvehicleregno = new System.Windows.Forms.Label();
            this.lblchassisno = new System.Windows.Forms.Label();
            this.lblenginecapacity = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtvehicleregno = new System.Windows.Forms.TextBox();
            this.txtchassisno = new System.Windows.Forms.TextBox();
            this.txtenginecapacity = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lbladdoreditvehicle = new System.Windows.Forms.Label();
            this.cbxcondition = new System.Windows.Forms.ComboBox();
            this.cbxbrand = new System.Windows.Forms.ComboBox();
            this.cbxbranch = new System.Windows.Forms.ComboBox();
            this.cbxbodytype = new System.Windows.Forms.ComboBox();
            this.cbxtransmission = new System.Windows.Forms.ComboBox();
            this.cbxfueltype = new System.Windows.Forms.ComboBox();
            this.cbxvehicletype = new System.Windows.Forms.ComboBox();
            this.lblfueltype = new System.Windows.Forms.Label();
            this.lblcondition = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lblbodytype = new System.Windows.Forms.Label();
            this.lbltransmission = new System.Windows.Forms.Label();
            this.lblmanufactureyear = new System.Windows.Forms.Label();
            this.lblvehicletype = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.group19DataSet = new COSC_31112_Visual_Programming_Final_Project_Group19.Group19DataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new COSC_31112_Visual_Programming_Final_Project_Group19.Group19DataSetTableAdapters.InventoryTableAdapter();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vregnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassisnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group19DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeletevehicle
            // 
            this.btndeletevehicle.BackColor = System.Drawing.Color.Black;
            this.btndeletevehicle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletevehicle.ForeColor = System.Drawing.Color.White;
            this.btndeletevehicle.Location = new System.Drawing.Point(525, 442);
            this.btndeletevehicle.Name = "btndeletevehicle";
            this.btndeletevehicle.Size = new System.Drawing.Size(102, 45);
            this.btndeletevehicle.TabIndex = 19;
            this.btndeletevehicle.Text = "Delete Vehicle";
            this.btndeletevehicle.UseVisualStyleBackColor = false;
            this.btndeletevehicle.Click += new System.EventHandler(this.btndeletevehicle_Click);
            // 
            // btnmainmenu7
            // 
            this.btnmainmenu7.BackColor = System.Drawing.Color.Black;
            this.btnmainmenu7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmainmenu7.ForeColor = System.Drawing.Color.White;
            this.btnmainmenu7.Location = new System.Drawing.Point(633, 442);
            this.btnmainmenu7.Name = "btnmainmenu7";
            this.btnmainmenu7.Size = new System.Drawing.Size(103, 45);
            this.btnmainmenu7.TabIndex = 20;
            this.btnmainmenu7.Text = "Main Menu";
            this.btnmainmenu7.UseVisualStyleBackColor = false;
            this.btnmainmenu7.Click += new System.EventHandler(this.btnmainmenu7_Click);
            // 
            // btnclose7
            // 
            this.btnclose7.BackColor = System.Drawing.Color.Red;
            this.btnclose7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose7.ForeColor = System.Drawing.Color.White;
            this.btnclose7.Location = new System.Drawing.Point(850, 442);
            this.btnclose7.Name = "btnclose7";
            this.btnclose7.Size = new System.Drawing.Size(103, 45);
            this.btnclose7.TabIndex = 21;
            this.btnclose7.Text = "Close";
            this.btnclose7.UseVisualStyleBackColor = false;
            this.btnclose7.Click += new System.EventHandler(this.btnclose7_Click);
            // 
            // btnsearchvehicle
            // 
            this.btnsearchvehicle.BackColor = System.Drawing.Color.Black;
            this.btnsearchvehicle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchvehicle.ForeColor = System.Drawing.Color.White;
            this.btnsearchvehicle.Location = new System.Drawing.Point(14, 442);
            this.btnsearchvehicle.Name = "btnsearchvehicle";
            this.btnsearchvehicle.Size = new System.Drawing.Size(257, 45);
            this.btnsearchvehicle.TabIndex = 22;
            this.btnsearchvehicle.Text = "Search Vehicle";
            this.btnsearchvehicle.UseVisualStyleBackColor = false;
            this.btnsearchvehicle.Click += new System.EventHandler(this.btnsearchvehicle_Click);
            // 
            // btnclear7
            // 
            this.btnclear7.BackColor = System.Drawing.Color.Black;
            this.btnclear7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear7.ForeColor = System.Drawing.Color.White;
            this.btnclear7.Location = new System.Drawing.Point(742, 442);
            this.btnclear7.Name = "btnclear7";
            this.btnclear7.Size = new System.Drawing.Size(102, 45);
            this.btnclear7.TabIndex = 23;
            this.btnclear7.Text = "Clear";
            this.btnclear7.UseVisualStyleBackColor = false;
            this.btnclear7.Click += new System.EventHandler(this.btnclear7_Click);
            // 
            // btnupdatevehicle
            // 
            this.btnupdatevehicle.BackColor = System.Drawing.Color.Black;
            this.btnupdatevehicle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatevehicle.ForeColor = System.Drawing.Color.White;
            this.btnupdatevehicle.Location = new System.Drawing.Point(416, 442);
            this.btnupdatevehicle.Name = "btnupdatevehicle";
            this.btnupdatevehicle.Size = new System.Drawing.Size(103, 45);
            this.btnupdatevehicle.TabIndex = 24;
            this.btnupdatevehicle.Text = "Update Vehicle";
            this.btnupdatevehicle.UseVisualStyleBackColor = false;
            this.btnupdatevehicle.Click += new System.EventHandler(this.btnupdatevehicle_Click);
            // 
            // btnaddvehicle
            // 
            this.btnaddvehicle.BackColor = System.Drawing.Color.Black;
            this.btnaddvehicle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddvehicle.ForeColor = System.Drawing.Color.White;
            this.btnaddvehicle.Location = new System.Drawing.Point(308, 442);
            this.btnaddvehicle.Name = "btnaddvehicle";
            this.btnaddvehicle.Size = new System.Drawing.Size(102, 45);
            this.btnaddvehicle.TabIndex = 25;
            this.btnaddvehicle.Text = "Add Vehicle";
            this.btnaddvehicle.UseVisualStyleBackColor = false;
            this.btnaddvehicle.Click += new System.EventHandler(this.btnaddvehicle_Click);
            // 
            // lblvehicleregno
            // 
            this.lblvehicleregno.AutoSize = true;
            this.lblvehicleregno.BackColor = System.Drawing.Color.Black;
            this.lblvehicleregno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehicleregno.ForeColor = System.Drawing.Color.White;
            this.lblvehicleregno.Location = new System.Drawing.Point(11, 311);
            this.lblvehicleregno.Name = "lblvehicleregno";
            this.lblvehicleregno.Size = new System.Drawing.Size(129, 17);
            this.lblvehicleregno.TabIndex = 74;
            this.lblvehicleregno.Text = "Vehicle Register No :";
            this.lblvehicleregno.Click += new System.EventHandler(this.lblvehicleregno_Click);
            // 
            // lblchassisno
            // 
            this.lblchassisno.AutoSize = true;
            this.lblchassisno.BackColor = System.Drawing.Color.Black;
            this.lblchassisno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchassisno.ForeColor = System.Drawing.Color.White;
            this.lblchassisno.Location = new System.Drawing.Point(11, 337);
            this.lblchassisno.Name = "lblchassisno";
            this.lblchassisno.Size = new System.Drawing.Size(80, 17);
            this.lblchassisno.TabIndex = 74;
            this.lblchassisno.Text = "Chassis No :";
            this.lblchassisno.Click += new System.EventHandler(this.lblchassisno_Click);
            // 
            // lblenginecapacity
            // 
            this.lblenginecapacity.AutoSize = true;
            this.lblenginecapacity.BackColor = System.Drawing.Color.Black;
            this.lblenginecapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenginecapacity.ForeColor = System.Drawing.Color.White;
            this.lblenginecapacity.Location = new System.Drawing.Point(12, 363);
            this.lblenginecapacity.Name = "lblenginecapacity";
            this.lblenginecapacity.Size = new System.Drawing.Size(107, 17);
            this.lblenginecapacity.TabIndex = 74;
            this.lblenginecapacity.Text = "Engine Capacity :";
            this.lblenginecapacity.Click += new System.EventHandler(this.lblenginecapacity_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Black;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.White;
            this.lblprice.Location = new System.Drawing.Point(13, 389);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(43, 17);
            this.lblprice.TabIndex = 74;
            this.lblprice.Text = "Price :";
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // txtvehicleregno
            // 
            this.txtvehicleregno.Location = new System.Drawing.Point(150, 307);
            this.txtvehicleregno.Name = "txtvehicleregno";
            this.txtvehicleregno.Size = new System.Drawing.Size(121, 20);
            this.txtvehicleregno.TabIndex = 75;
            this.txtvehicleregno.TextChanged += new System.EventHandler(this.txtvehicleregno_TextChanged);
            // 
            // txtchassisno
            // 
            this.txtchassisno.Location = new System.Drawing.Point(150, 333);
            this.txtchassisno.Name = "txtchassisno";
            this.txtchassisno.Size = new System.Drawing.Size(121, 20);
            this.txtchassisno.TabIndex = 75;
            this.txtchassisno.TextChanged += new System.EventHandler(this.txtchassisno_TextChanged);
            // 
            // txtenginecapacity
            // 
            this.txtenginecapacity.Location = new System.Drawing.Point(150, 359);
            this.txtenginecapacity.Name = "txtenginecapacity";
            this.txtenginecapacity.Size = new System.Drawing.Size(121, 20);
            this.txtenginecapacity.TabIndex = 75;
            this.txtenginecapacity.TextChanged += new System.EventHandler(this.txtenginecapacity_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(150, 385);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(121, 20);
            this.txtprice.TabIndex = 75;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // lbladdoreditvehicle
            // 
            this.lbladdoreditvehicle.AutoSize = true;
            this.lbladdoreditvehicle.BackColor = System.Drawing.Color.Black;
            this.lbladdoreditvehicle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdoreditvehicle.ForeColor = System.Drawing.Color.White;
            this.lbladdoreditvehicle.Location = new System.Drawing.Point(271, 11);
            this.lbladdoreditvehicle.Name = "lbladdoreditvehicle";
            this.lbladdoreditvehicle.Size = new System.Drawing.Size(445, 54);
            this.lbladdoreditvehicle.TabIndex = 76;
            this.lbladdoreditvehicle.Text = "ADD OR EDIT VEHICLE";
            this.lbladdoreditvehicle.Click += new System.EventHandler(this.lbladdoreditvehicle_Click);
            // 
            // cbxcondition
            // 
            this.cbxcondition.FormattingEnabled = true;
            this.cbxcondition.Location = new System.Drawing.Point(151, 172);
            this.cbxcondition.Name = "cbxcondition";
            this.cbxcondition.Size = new System.Drawing.Size(121, 21);
            this.cbxcondition.TabIndex = 85;
            this.cbxcondition.SelectedIndexChanged += new System.EventHandler(this.cbxcondition_SelectedIndexChanged);
            // 
            // cbxbrand
            // 
            this.cbxbrand.FormattingEnabled = true;
            this.cbxbrand.Location = new System.Drawing.Point(153, 118);
            this.cbxbrand.Name = "cbxbrand";
            this.cbxbrand.Size = new System.Drawing.Size(121, 21);
            this.cbxbrand.TabIndex = 87;
            this.cbxbrand.SelectedIndexChanged += new System.EventHandler(this.cbxbrand_SelectedIndexChanged);
            // 
            // cbxbranch
            // 
            this.cbxbranch.FormattingEnabled = true;
            this.cbxbranch.Location = new System.Drawing.Point(153, 91);
            this.cbxbranch.Name = "cbxbranch";
            this.cbxbranch.Size = new System.Drawing.Size(121, 21);
            this.cbxbranch.TabIndex = 88;
            this.cbxbranch.SelectedIndexChanged += new System.EventHandler(this.cbxbranch_SelectedIndexChanged);
            // 
            // cbxbodytype
            // 
            this.cbxbodytype.FormattingEnabled = true;
            this.cbxbodytype.Location = new System.Drawing.Point(150, 280);
            this.cbxbodytype.Name = "cbxbodytype";
            this.cbxbodytype.Size = new System.Drawing.Size(121, 21);
            this.cbxbodytype.TabIndex = 89;
            this.cbxbodytype.SelectedIndexChanged += new System.EventHandler(this.cbxbodytype_SelectedIndexChanged);
            // 
            // cbxtransmission
            // 
            this.cbxtransmission.FormattingEnabled = true;
            this.cbxtransmission.Location = new System.Drawing.Point(150, 225);
            this.cbxtransmission.Name = "cbxtransmission";
            this.cbxtransmission.Size = new System.Drawing.Size(121, 21);
            this.cbxtransmission.TabIndex = 90;
            this.cbxtransmission.SelectedIndexChanged += new System.EventHandler(this.cbxtransmission_SelectedIndexChanged);
            // 
            // cbxfueltype
            // 
            this.cbxfueltype.FormattingEnabled = true;
            this.cbxfueltype.Location = new System.Drawing.Point(150, 253);
            this.cbxfueltype.Name = "cbxfueltype";
            this.cbxfueltype.Size = new System.Drawing.Size(121, 21);
            this.cbxfueltype.TabIndex = 91;
            this.cbxfueltype.SelectedIndexChanged += new System.EventHandler(this.cbxfueltype_SelectedIndexChanged);
            // 
            // cbxvehicletype
            // 
            this.cbxvehicletype.FormattingEnabled = true;
            this.cbxvehicletype.Location = new System.Drawing.Point(152, 145);
            this.cbxvehicletype.Name = "cbxvehicletype";
            this.cbxvehicletype.Size = new System.Drawing.Size(121, 21);
            this.cbxvehicletype.TabIndex = 92;
            this.cbxvehicletype.SelectedIndexChanged += new System.EventHandler(this.cbxvehicletype_SelectedIndexChanged);
            // 
            // lblfueltype
            // 
            this.lblfueltype.AutoSize = true;
            this.lblfueltype.BackColor = System.Drawing.Color.Black;
            this.lblfueltype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfueltype.ForeColor = System.Drawing.Color.White;
            this.lblfueltype.Location = new System.Drawing.Point(13, 258);
            this.lblfueltype.Name = "lblfueltype";
            this.lblfueltype.Size = new System.Drawing.Size(69, 17);
            this.lblfueltype.TabIndex = 84;
            this.lblfueltype.Text = "Fuel Type :";
            this.lblfueltype.Click += new System.EventHandler(this.lblfueltype_Click);
            // 
            // lblcondition
            // 
            this.lblcondition.AutoSize = true;
            this.lblcondition.BackColor = System.Drawing.Color.Black;
            this.lblcondition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondition.ForeColor = System.Drawing.Color.White;
            this.lblcondition.Location = new System.Drawing.Point(12, 177);
            this.lblcondition.Name = "lblcondition";
            this.lblcondition.Size = new System.Drawing.Size(71, 17);
            this.lblcondition.TabIndex = 79;
            this.lblcondition.Text = "Condition :";
            this.lblcondition.Click += new System.EventHandler(this.lblcondition_Click);
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.BackColor = System.Drawing.Color.Black;
            this.lblbranch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranch.ForeColor = System.Drawing.Color.White;
            this.lblbranch.Location = new System.Drawing.Point(13, 96);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(54, 17);
            this.lblbranch.TabIndex = 77;
            this.lblbranch.Text = "Branch :";
            this.lblbranch.Click += new System.EventHandler(this.lblbranch_Click);
            // 
            // lblbodytype
            // 
            this.lblbodytype.AutoSize = true;
            this.lblbodytype.BackColor = System.Drawing.Color.Black;
            this.lblbodytype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbodytype.ForeColor = System.Drawing.Color.White;
            this.lblbodytype.Location = new System.Drawing.Point(11, 285);
            this.lblbodytype.Name = "lblbodytype";
            this.lblbodytype.Size = new System.Drawing.Size(75, 17);
            this.lblbodytype.TabIndex = 78;
            this.lblbodytype.Text = "Body Type :";
            this.lblbodytype.Click += new System.EventHandler(this.lblbodytype_Click);
            // 
            // lbltransmission
            // 
            this.lbltransmission.AutoSize = true;
            this.lbltransmission.BackColor = System.Drawing.Color.Black;
            this.lbltransmission.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransmission.ForeColor = System.Drawing.Color.White;
            this.lbltransmission.Location = new System.Drawing.Point(13, 230);
            this.lbltransmission.Name = "lbltransmission";
            this.lbltransmission.Size = new System.Drawing.Size(90, 17);
            this.lbltransmission.TabIndex = 81;
            this.lbltransmission.Text = "Transmission :";
            this.lbltransmission.Click += new System.EventHandler(this.lbltransmission_Click);
            // 
            // lblmanufactureyear
            // 
            this.lblmanufactureyear.AutoSize = true;
            this.lblmanufactureyear.BackColor = System.Drawing.Color.Black;
            this.lblmanufactureyear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanufactureyear.ForeColor = System.Drawing.Color.White;
            this.lblmanufactureyear.Location = new System.Drawing.Point(13, 203);
            this.lblmanufactureyear.Name = "lblmanufactureyear";
            this.lblmanufactureyear.Size = new System.Drawing.Size(135, 17);
            this.lblmanufactureyear.TabIndex = 80;
            this.lblmanufactureyear.Text = "Year Of Manufacture :";
            this.lblmanufactureyear.Click += new System.EventHandler(this.lblmanufactureyear_Click);
            // 
            // lblvehicletype
            // 
            this.lblvehicletype.AutoSize = true;
            this.lblvehicletype.BackColor = System.Drawing.Color.Black;
            this.lblvehicletype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehicletype.ForeColor = System.Drawing.Color.White;
            this.lblvehicletype.Location = new System.Drawing.Point(12, 150);
            this.lblvehicletype.Name = "lblvehicletype";
            this.lblvehicletype.Size = new System.Drawing.Size(86, 17);
            this.lblvehicletype.TabIndex = 82;
            this.lblvehicletype.Text = "Vehicle Type :";
            this.lblvehicletype.Click += new System.EventHandler(this.lblvehicletype_Click);
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.Color.Black;
            this.lblbrand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.ForeColor = System.Drawing.Color.White;
            this.lblbrand.Location = new System.Drawing.Point(12, 123);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(49, 17);
            this.lblbrand.TabIndex = 83;
            this.lblbrand.Text = "Brand :";
            this.lblbrand.Click += new System.EventHandler(this.lblbrand_Click);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(151, 199);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(120, 20);
            this.txtyear.TabIndex = 75;
            this.txtyear.TextChanged += new System.EventHandler(this.txtyear_TextChanged);
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.Black;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.White;
            this.lblqty.Location = new System.Drawing.Point(12, 415);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(63, 17);
            this.lblqty.TabIndex = 74;
            this.lblqty.Text = "Quantity :";
            this.lblqty.Click += new System.EventHandler(this.lblqty_Click);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(150, 411);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(121, 20);
            this.txtqty.TabIndex = 75;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.vtypeDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.transmissionDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.ftypeDataGridViewTextBoxColumn,
            this.btypeDataGridViewTextBoxColumn,
            this.vregnoDataGridViewTextBoxColumn,
            this.chassisnoDataGridViewTextBoxColumn,
            this.ecapacityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.dataGridView7.DataSource = this.inventoryBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(280, 92);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(688, 338);
            this.dataGridView7.TabIndex = 93;
            this.dataGridView7.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView7_CellClick);
            this.dataGridView7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView7_CellContentClick);
            // 
            // group19DataSet
            // 
            this.group19DataSet.DataSetName = "Group19DataSet";
            this.group19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.group19DataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
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
            // vregnoDataGridViewTextBoxColumn
            // 
            this.vregnoDataGridViewTextBoxColumn.DataPropertyName = "vregno";
            this.vregnoDataGridViewTextBoxColumn.HeaderText = "vregno";
            this.vregnoDataGridViewTextBoxColumn.Name = "vregnoDataGridViewTextBoxColumn";
            // 
            // chassisnoDataGridViewTextBoxColumn
            // 
            this.chassisnoDataGridViewTextBoxColumn.DataPropertyName = "chassisno";
            this.chassisnoDataGridViewTextBoxColumn.HeaderText = "chassisno";
            this.chassisnoDataGridViewTextBoxColumn.Name = "chassisnoDataGridViewTextBoxColumn";
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
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // frm7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 512);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.cbxcondition);
            this.Controls.Add(this.cbxbrand);
            this.Controls.Add(this.cbxbranch);
            this.Controls.Add(this.cbxbodytype);
            this.Controls.Add(this.cbxtransmission);
            this.Controls.Add(this.cbxfueltype);
            this.Controls.Add(this.cbxvehicletype);
            this.Controls.Add(this.lblfueltype);
            this.Controls.Add(this.lblcondition);
            this.Controls.Add(this.lblbranch);
            this.Controls.Add(this.lblbodytype);
            this.Controls.Add(this.lbltransmission);
            this.Controls.Add(this.lblmanufactureyear);
            this.Controls.Add(this.lblvehicletype);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.lbladdoreditvehicle);
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
            this.Controls.Add(this.btndeletevehicle);
            this.Controls.Add(this.btnmainmenu7);
            this.Controls.Add(this.btnclose7);
            this.Controls.Add(this.btnsearchvehicle);
            this.Controls.Add(this.btnclear7);
            this.Controls.Add(this.btnupdatevehicle);
            this.Controls.Add(this.btnaddvehicle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm7";
            this.Text = "Add or Edit Vehicle";
            this.Load += new System.EventHandler(this.frm7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group19DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndeletevehicle;
        private System.Windows.Forms.Button btnmainmenu7;
        private System.Windows.Forms.Button btnclose7;
        private System.Windows.Forms.Button btnsearchvehicle;
        private System.Windows.Forms.Button btnclear7;
        private System.Windows.Forms.Button btnupdatevehicle;
        private System.Windows.Forms.Button btnaddvehicle;
        private System.Windows.Forms.Label lblvehicleregno;
        private System.Windows.Forms.Label lblchassisno;
        private System.Windows.Forms.Label lblenginecapacity;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtvehicleregno;
        private System.Windows.Forms.TextBox txtchassisno;
        private System.Windows.Forms.TextBox txtenginecapacity;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lbladdoreditvehicle;
        private System.Windows.Forms.ComboBox cbxcondition;
        private System.Windows.Forms.ComboBox cbxbrand;
        private System.Windows.Forms.ComboBox cbxbranch;
        private System.Windows.Forms.ComboBox cbxbodytype;
        private System.Windows.Forms.ComboBox cbxtransmission;
        private System.Windows.Forms.ComboBox cbxfueltype;
        private System.Windows.Forms.ComboBox cbxvehicletype;
        private System.Windows.Forms.Label lblfueltype;
        private System.Windows.Forms.Label lblcondition;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lblbodytype;
        private System.Windows.Forms.Label lbltransmission;
        private System.Windows.Forms.Label lblmanufactureyear;
        private System.Windows.Forms.Label lblvehicletype;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.DataGridView dataGridView7;
        private Group19DataSet group19DataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Group19DataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vregnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassisnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
    }
}
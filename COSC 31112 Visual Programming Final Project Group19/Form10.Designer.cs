﻿namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    partial class frm10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm10));
            this.cbxbranch = new System.Windows.Forms.ComboBox();
            this.lblappointment = new System.Windows.Forms.Label();
            this.txtcontactnumber = new System.Windows.Forms.TextBox();
            this.lblcontactnumber = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.time4 = new System.Windows.Forms.DateTimePicker();
            this.date4 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group19DataSet = new COSC_31112_Visual_Programming_Final_Project_Group19.Group19DataSet();
            this.btndeleteappointment = new System.Windows.Forms.Button();
            this.btnmainmenu4 = new System.Windows.Forms.Button();
            this.btnclose4 = new System.Windows.Forms.Button();
            this.btnsearchappointment = new System.Windows.Forms.Button();
            this.btnclear4 = new System.Windows.Forms.Button();
            this.btnupdateappointment = new System.Windows.Forms.Button();
            this.btnaddappointment = new System.Windows.Forms.Button();
            this.appointmentTableAdapter = new COSC_31112_Visual_Programming_Final_Project_Group19.Group19DataSetTableAdapters.AppointmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group19DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxbranch
            // 
            this.cbxbranch.FormattingEnabled = true;
            this.cbxbranch.Location = new System.Drawing.Point(740, 224);
            this.cbxbranch.Name = "cbxbranch";
            this.cbxbranch.Size = new System.Drawing.Size(162, 21);
            this.cbxbranch.TabIndex = 98;
            // 
            // lblappointment
            // 
            this.lblappointment.AutoSize = true;
            this.lblappointment.BackColor = System.Drawing.Color.Black;
            this.lblappointment.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappointment.ForeColor = System.Drawing.Color.White;
            this.lblappointment.Location = new System.Drawing.Point(303, 10);
            this.lblappointment.Name = "lblappointment";
            this.lblappointment.Size = new System.Drawing.Size(313, 54);
            this.lblappointment.TabIndex = 97;
            this.lblappointment.Text = "APPOINTMENT";
            // 
            // txtcontactnumber
            // 
            this.txtcontactnumber.Location = new System.Drawing.Point(738, 362);
            this.txtcontactnumber.Name = "txtcontactnumber";
            this.txtcontactnumber.Size = new System.Drawing.Size(159, 20);
            this.txtcontactnumber.TabIndex = 95;
            // 
            // lblcontactnumber
            // 
            this.lblcontactnumber.AutoSize = true;
            this.lblcontactnumber.BackColor = System.Drawing.Color.Black;
            this.lblcontactnumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactnumber.ForeColor = System.Drawing.Color.White;
            this.lblcontactnumber.Location = new System.Drawing.Point(658, 367);
            this.lblcontactnumber.Name = "lblcontactnumber";
            this.lblcontactnumber.Size = new System.Drawing.Size(74, 15);
            this.lblcontactnumber.TabIndex = 93;
            this.lblcontactnumber.Text = "Contact No :";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Black;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(663, 174);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(23, 15);
            this.lblid.TabIndex = 92;
            this.lblid.Text = "Id :";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Black;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(663, 272);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(39, 15);
            this.lbltime.TabIndex = 91;
            this.lbltime.Text = "Time :";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.BackColor = System.Drawing.Color.Black;
            this.lblbranch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranch.ForeColor = System.Drawing.Color.White;
            this.lblbranch.Location = new System.Drawing.Point(663, 225);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(50, 15);
            this.lblbranch.TabIndex = 90;
            this.lblbranch.Text = "Branch :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(740, 174);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(162, 20);
            this.txtid.TabIndex = 94;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(740, 315);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(162, 20);
            this.txtdescription.TabIndex = 96;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.BackColor = System.Drawing.Color.Black;
            this.lbldescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.ForeColor = System.Drawing.Color.White;
            this.lbldescription.Location = new System.Drawing.Point(663, 320);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(73, 15);
            this.lbldescription.TabIndex = 89;
            this.lbldescription.Text = "Description :";
            // 
            // time4
            // 
            this.time4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time4.Location = new System.Drawing.Point(740, 267);
            this.time4.Name = "time4";
            this.time4.ShowUpDown = true;
            this.time4.Size = new System.Drawing.Size(164, 20);
            this.time4.TabIndex = 88;
            // 
            // date4
            // 
            this.date4.Location = new System.Drawing.Point(673, 83);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(229, 20);
            this.date4.TabIndex = 87;
            // 
            // dataGridView10
            // 
            this.dataGridView10.AutoGenerateColumns = false;
            this.dataGridView10.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn});
            this.dataGridView10.DataSource = this.appointmentBindingSource;
            this.dataGridView10.GridColor = System.Drawing.Color.Black;
            this.dataGridView10.Location = new System.Drawing.Point(11, 83);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.Size = new System.Drawing.Size(640, 299);
            this.dataGridView10.TabIndex = 86;
            this.dataGridView10.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView10_CellClick);
            this.dataGridView10.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView10_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contactno";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "contactno";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.group19DataSet;
            // 
            // group19DataSet
            // 
            this.group19DataSet.DataSetName = "Group19DataSet";
            this.group19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndeleteappointment
            // 
            this.btndeleteappointment.BackColor = System.Drawing.Color.Black;
            this.btndeleteappointment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteappointment.ForeColor = System.Drawing.Color.White;
            this.btndeleteappointment.Location = new System.Drawing.Point(484, 408);
            this.btndeleteappointment.Name = "btndeleteappointment";
            this.btndeleteappointment.Size = new System.Drawing.Size(127, 45);
            this.btndeleteappointment.TabIndex = 84;
            this.btndeleteappointment.Text = "Delete Appointment";
            this.btndeleteappointment.UseVisualStyleBackColor = false;
            this.btndeleteappointment.Click += new System.EventHandler(this.btndeleteappointment_Click);
            // 
            // btnmainmenu4
            // 
            this.btnmainmenu4.BackColor = System.Drawing.Color.Black;
            this.btnmainmenu4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmainmenu4.ForeColor = System.Drawing.Color.White;
            this.btnmainmenu4.Location = new System.Drawing.Point(312, 474);
            this.btnmainmenu4.Name = "btnmainmenu4";
            this.btnmainmenu4.Size = new System.Drawing.Size(127, 45);
            this.btnmainmenu4.TabIndex = 83;
            this.btnmainmenu4.Text = "Main Menu";
            this.btnmainmenu4.UseVisualStyleBackColor = false;
            this.btnmainmenu4.Click += new System.EventHandler(this.btnmainmenu4_Click);
            // 
            // btnclose4
            // 
            this.btnclose4.BackColor = System.Drawing.Color.Red;
            this.btnclose4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose4.ForeColor = System.Drawing.Color.White;
            this.btnclose4.Location = new System.Drawing.Point(484, 474);
            this.btnclose4.Name = "btnclose4";
            this.btnclose4.Size = new System.Drawing.Size(127, 45);
            this.btnclose4.TabIndex = 82;
            this.btnclose4.Text = "Close";
            this.btnclose4.UseVisualStyleBackColor = false;
            this.btnclose4.Click += new System.EventHandler(this.btnclose4_Click);
            // 
            // btnsearchappointment
            // 
            this.btnsearchappointment.BackColor = System.Drawing.Color.Red;
            this.btnsearchappointment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchappointment.ForeColor = System.Drawing.Color.White;
            this.btnsearchappointment.Location = new System.Drawing.Point(717, 118);
            this.btnsearchappointment.Name = "btnsearchappointment";
            this.btnsearchappointment.Size = new System.Drawing.Size(152, 36);
            this.btnsearchappointment.TabIndex = 81;
            this.btnsearchappointment.Text = "Search Appointments";
            this.btnsearchappointment.UseVisualStyleBackColor = false;
            this.btnsearchappointment.Click += new System.EventHandler(this.btnsearchappointment_Click);
            // 
            // btnclear4
            // 
            this.btnclear4.BackColor = System.Drawing.Color.Black;
            this.btnclear4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear4.ForeColor = System.Drawing.Color.White;
            this.btnclear4.Location = new System.Drawing.Point(654, 408);
            this.btnclear4.Name = "btnclear4";
            this.btnclear4.Size = new System.Drawing.Size(127, 45);
            this.btnclear4.TabIndex = 80;
            this.btnclear4.Text = "Clear";
            this.btnclear4.UseVisualStyleBackColor = false;
            this.btnclear4.Click += new System.EventHandler(this.btnclear4_Click);
            // 
            // btnupdateappointment
            // 
            this.btnupdateappointment.BackColor = System.Drawing.Color.Black;
            this.btnupdateappointment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateappointment.ForeColor = System.Drawing.Color.White;
            this.btnupdateappointment.Location = new System.Drawing.Point(312, 408);
            this.btnupdateappointment.Name = "btnupdateappointment";
            this.btnupdateappointment.Size = new System.Drawing.Size(127, 45);
            this.btnupdateappointment.TabIndex = 85;
            this.btnupdateappointment.Text = "Update Appointment";
            this.btnupdateappointment.UseVisualStyleBackColor = false;
            this.btnupdateappointment.Click += new System.EventHandler(this.btnupdateappointment_Click);
            // 
            // btnaddappointment
            // 
            this.btnaddappointment.BackColor = System.Drawing.Color.Black;
            this.btnaddappointment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddappointment.ForeColor = System.Drawing.Color.White;
            this.btnaddappointment.Location = new System.Drawing.Point(141, 408);
            this.btnaddappointment.Name = "btnaddappointment";
            this.btnaddappointment.Size = new System.Drawing.Size(127, 45);
            this.btnaddappointment.TabIndex = 79;
            this.btnaddappointment.Text = "Add     Appointment";
            this.btnaddappointment.UseVisualStyleBackColor = false;
            this.btnaddappointment.Click += new System.EventHandler(this.btnaddappointment_Click);
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // frm10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 529);
            this.Controls.Add(this.cbxbranch);
            this.Controls.Add(this.lblappointment);
            this.Controls.Add(this.txtcontactnumber);
            this.Controls.Add(this.lblcontactnumber);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblbranch);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.time4);
            this.Controls.Add(this.date4);
            this.Controls.Add(this.dataGridView10);
            this.Controls.Add(this.btndeleteappointment);
            this.Controls.Add(this.btnmainmenu4);
            this.Controls.Add(this.btnclose4);
            this.Controls.Add(this.btnsearchappointment);
            this.Controls.Add(this.btnclear4);
            this.Controls.Add(this.btnupdateappointment);
            this.Controls.Add(this.btnaddappointment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm10";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.frm10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group19DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxbranch;
        private System.Windows.Forms.Label lblappointment;
        private System.Windows.Forms.TextBox txtcontactnumber;
        private System.Windows.Forms.Label lblcontactnumber;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.DateTimePicker time4;
        private System.Windows.Forms.DateTimePicker date4;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.Button btndeleteappointment;
        private System.Windows.Forms.Button btnmainmenu4;
        private System.Windows.Forms.Button btnclose4;
        private System.Windows.Forms.Button btnsearchappointment;
        private System.Windows.Forms.Button btnclear4;
        private System.Windows.Forms.Button btnupdateappointment;
        private System.Windows.Forms.Button btnaddappointment;
        private Group19DataSet group19DataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private Group19DataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
    }
}
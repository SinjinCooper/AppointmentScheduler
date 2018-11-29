namespace c969
{
    partial class MainForm
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
            this.reportsBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.apptGridView = new System.Windows.Forms.DataGridView();
            this.apptCalendar = new System.Windows.Forms.MonthCalendar();
            this.apptDetailsLbl = new System.Windows.Forms.Label();
            this.apptIdLbl = new System.Windows.Forms.Label();
            this.customerIdLbl = new System.Windows.Forms.Label();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.contactLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.apptIdDetails = new System.Windows.Forms.Label();
            this.customerIdDetails = new System.Windows.Forms.Label();
            this.userIdDetails = new System.Windows.Forms.Label();
            this.titleDetails = new System.Windows.Forms.Label();
            this.locationDetails = new System.Windows.Forms.Label();
            this.contactDetails = new System.Windows.Forms.Label();
            this.typeDetails = new System.Windows.Forms.Label();
            this.descriptionDetails = new System.Windows.Forms.Label();
            this.viewLbl = new System.Windows.Forms.Label();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.apptGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsBtn
            // 
            this.reportsBtn.Location = new System.Drawing.Point(781, 570);
            this.reportsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(100, 28);
            this.reportsBtn.TabIndex = 0;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // customersBtn
            // 
            this.customersBtn.Location = new System.Drawing.Point(640, 570);
            this.customersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(100, 28);
            this.customersBtn.TabIndex = 1;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = true;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // apptGridView
            // 
            this.apptGridView.AllowUserToAddRows = false;
            this.apptGridView.AllowUserToDeleteRows = false;
            this.apptGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptGridView.Location = new System.Drawing.Point(24, 298);
            this.apptGridView.Margin = new System.Windows.Forms.Padding(4);
            this.apptGridView.Name = "apptGridView";
            this.apptGridView.RowHeadersVisible = false;
            this.apptGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apptGridView.Size = new System.Drawing.Size(445, 246);
            this.apptGridView.TabIndex = 2;
            // 
            // apptCalendar
            // 
            this.apptCalendar.Location = new System.Drawing.Point(92, 22);
            this.apptCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.apptCalendar.MaxSelectionCount = 1;
            this.apptCalendar.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.apptCalendar.Name = "apptCalendar";
            this.apptCalendar.ShowToday = false;
            this.apptCalendar.TabIndex = 3;
            this.apptCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.apptCalendar_DateSelected);
            // 
            // apptDetailsLbl
            // 
            this.apptDetailsLbl.AutoSize = true;
            this.apptDetailsLbl.Location = new System.Drawing.Point(747, 39);
            this.apptDetailsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apptDetailsLbl.Name = "apptDetailsLbl";
            this.apptDetailsLbl.Size = new System.Drawing.Size(134, 17);
            this.apptDetailsLbl.TabIndex = 4;
            this.apptDetailsLbl.Text = "Appointment Details";
            // 
            // apptIdLbl
            // 
            this.apptIdLbl.AutoSize = true;
            this.apptIdLbl.Location = new System.Drawing.Point(588, 98);
            this.apptIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apptIdLbl.Name = "apptIdLbl";
            this.apptIdLbl.Size = new System.Drawing.Size(108, 17);
            this.apptIdLbl.TabIndex = 5;
            this.apptIdLbl.Text = "Appointment ID:";
            // 
            // customerIdLbl
            // 
            this.customerIdLbl.AutoSize = true;
            this.customerIdLbl.Location = new System.Drawing.Point(588, 137);
            this.customerIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerIdLbl.Name = "customerIdLbl";
            this.customerIdLbl.Size = new System.Drawing.Size(89, 17);
            this.customerIdLbl.TabIndex = 6;
            this.customerIdLbl.Text = "Customer ID:";
            // 
            // userIdLbl
            // 
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Location = new System.Drawing.Point(588, 176);
            this.userIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(59, 17);
            this.userIdLbl.TabIndex = 7;
            this.userIdLbl.Text = "User ID:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(588, 217);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(39, 17);
            this.titleLbl.TabIndex = 8;
            this.titleLbl.Text = "Title:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(588, 375);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(83, 17);
            this.descriptionLbl.TabIndex = 9;
            this.descriptionLbl.Text = "Description:";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(588, 256);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(66, 17);
            this.locationLbl.TabIndex = 10;
            this.locationLbl.Text = "Location:";
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Location = new System.Drawing.Point(588, 298);
            this.contactLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(60, 17);
            this.contactLbl.TabIndex = 11;
            this.contactLbl.Text = "Contact:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(588, 336);
            this.typeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(44, 17);
            this.typeLbl.TabIndex = 12;
            this.typeLbl.Text = "Type:";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(919, 570);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 28);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(24, 570);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 28);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add New";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(152, 570);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 28);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Edit";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(369, 570);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // apptIdDetails
            // 
            this.apptIdDetails.AutoSize = true;
            this.apptIdDetails.Location = new System.Drawing.Point(747, 98);
            this.apptIdDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apptIdDetails.Name = "apptIdDetails";
            this.apptIdDetails.Size = new System.Drawing.Size(20, 17);
            this.apptIdDetails.TabIndex = 17;
            this.apptIdDetails.Text = "...";
            // 
            // customerIdDetails
            // 
            this.customerIdDetails.AutoSize = true;
            this.customerIdDetails.Location = new System.Drawing.Point(747, 137);
            this.customerIdDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerIdDetails.Name = "customerIdDetails";
            this.customerIdDetails.Size = new System.Drawing.Size(20, 17);
            this.customerIdDetails.TabIndex = 18;
            this.customerIdDetails.Text = "...";
            // 
            // userIdDetails
            // 
            this.userIdDetails.AutoSize = true;
            this.userIdDetails.Location = new System.Drawing.Point(747, 176);
            this.userIdDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdDetails.Name = "userIdDetails";
            this.userIdDetails.Size = new System.Drawing.Size(20, 17);
            this.userIdDetails.TabIndex = 19;
            this.userIdDetails.Text = "...";
            // 
            // titleDetails
            // 
            this.titleDetails.AutoSize = true;
            this.titleDetails.Location = new System.Drawing.Point(747, 217);
            this.titleDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleDetails.Name = "titleDetails";
            this.titleDetails.Size = new System.Drawing.Size(20, 17);
            this.titleDetails.TabIndex = 20;
            this.titleDetails.Text = "...";
            // 
            // locationDetails
            // 
            this.locationDetails.AutoSize = true;
            this.locationDetails.Location = new System.Drawing.Point(747, 256);
            this.locationDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationDetails.Name = "locationDetails";
            this.locationDetails.Size = new System.Drawing.Size(20, 17);
            this.locationDetails.TabIndex = 21;
            this.locationDetails.Text = "...";
            // 
            // contactDetails
            // 
            this.contactDetails.AutoSize = true;
            this.contactDetails.Location = new System.Drawing.Point(747, 298);
            this.contactDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactDetails.Name = "contactDetails";
            this.contactDetails.Size = new System.Drawing.Size(20, 17);
            this.contactDetails.TabIndex = 22;
            this.contactDetails.Text = "...";
            // 
            // typeDetails
            // 
            this.typeDetails.AutoSize = true;
            this.typeDetails.Location = new System.Drawing.Point(747, 336);
            this.typeDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeDetails.Name = "typeDetails";
            this.typeDetails.Size = new System.Drawing.Size(20, 17);
            this.typeDetails.TabIndex = 23;
            this.typeDetails.Text = "...";
            // 
            // descriptionDetails
            // 
            this.descriptionDetails.AutoSize = true;
            this.descriptionDetails.Location = new System.Drawing.Point(747, 375);
            this.descriptionDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionDetails.Name = "descriptionDetails";
            this.descriptionDetails.Size = new System.Drawing.Size(20, 17);
            this.descriptionDetails.TabIndex = 24;
            this.descriptionDetails.Text = "...";
            // 
            // viewLbl
            // 
            this.viewLbl.AutoSize = true;
            this.viewLbl.Location = new System.Drawing.Point(20, 273);
            this.viewLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewLbl.Name = "viewLbl";
            this.viewLbl.Size = new System.Drawing.Size(168, 17);
            this.viewLbl.TabIndex = 25;
            this.viewLbl.Text = "Viewing appointments by:";
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Checked = true;
            this.weekRadio.Location = new System.Drawing.Point(197, 268);
            this.weekRadio.Margin = new System.Windows.Forms.Padding(4);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(65, 21);
            this.weekRadio.TabIndex = 26;
            this.weekRadio.TabStop = true;
            this.weekRadio.Text = "Week";
            this.weekRadio.UseVisualStyleBackColor = true;
            this.weekRadio.CheckedChanged += new System.EventHandler(this.weekRadio_CheckedChanged);
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Location = new System.Drawing.Point(277, 268);
            this.monthRadio.Margin = new System.Windows.Forms.Padding(4);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(68, 21);
            this.monthRadio.TabIndex = 27;
            this.monthRadio.TabStop = true;
            this.monthRadio.Text = "Month";
            this.monthRadio.UseVisualStyleBackColor = true;
            this.monthRadio.CheckedChanged += new System.EventHandler(this.monthRadio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 613);
            this.Controls.Add(this.monthRadio);
            this.Controls.Add(this.weekRadio);
            this.Controls.Add(this.viewLbl);
            this.Controls.Add(this.descriptionDetails);
            this.Controls.Add(this.typeDetails);
            this.Controls.Add(this.contactDetails);
            this.Controls.Add(this.locationDetails);
            this.Controls.Add(this.titleDetails);
            this.Controls.Add(this.userIdDetails);
            this.Controls.Add(this.customerIdDetails);
            this.Controls.Add(this.apptIdDetails);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.contactLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.userIdLbl);
            this.Controls.Add(this.customerIdLbl);
            this.Controls.Add(this.apptIdLbl);
            this.Controls.Add(this.apptDetailsLbl);
            this.Controls.Add(this.apptCalendar);
            this.Controls.Add(this.apptGridView);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.reportsBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.apptGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.DataGridView apptGridView;
        private System.Windows.Forms.MonthCalendar apptCalendar;
        private System.Windows.Forms.Label apptDetailsLbl;
        private System.Windows.Forms.Label apptIdLbl;
        private System.Windows.Forms.Label customerIdLbl;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label apptIdDetails;
        private System.Windows.Forms.Label customerIdDetails;
        private System.Windows.Forms.Label userIdDetails;
        private System.Windows.Forms.Label titleDetails;
        private System.Windows.Forms.Label locationDetails;
        private System.Windows.Forms.Label contactDetails;
        private System.Windows.Forms.Label typeDetails;
        private System.Windows.Forms.Label descriptionDetails;
        private System.Windows.Forms.Label viewLbl;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.RadioButton monthRadio;
    }
}
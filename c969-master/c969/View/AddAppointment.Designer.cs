namespace c969.View
{
    partial class AddAppointment
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
            this.appointmentIdLbl = new System.Windows.Forms.Label();
            this.customerIdLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.contactLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.urlLbl = new System.Windows.Forms.Label();
            this.appointmentIdBox = new System.Windows.Forms.TextBox();
            this.customerIdBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.startLbl = new System.Windows.Forms.Label();
            this.endLbl = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // appointmentIdLbl
            // 
            this.appointmentIdLbl.AutoSize = true;
            this.appointmentIdLbl.Location = new System.Drawing.Point(24, 21);
            this.appointmentIdLbl.Name = "appointmentIdLbl";
            this.appointmentIdLbl.Size = new System.Drawing.Size(25, 17);
            this.appointmentIdLbl.TabIndex = 0;
            this.appointmentIdLbl.Text = "ID:";
            // 
            // customerIdLbl
            // 
            this.customerIdLbl.AutoSize = true;
            this.customerIdLbl.Location = new System.Drawing.Point(24, 49);
            this.customerIdLbl.Name = "customerIdLbl";
            this.customerIdLbl.Size = new System.Drawing.Size(89, 17);
            this.customerIdLbl.TabIndex = 1;
            this.customerIdLbl.Text = "Customer ID:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(24, 82);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(39, 17);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Title:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(24, 110);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(83, 17);
            this.descriptionLbl.TabIndex = 3;
            this.descriptionLbl.Text = "Description:";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(24, 146);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(66, 17);
            this.locationLbl.TabIndex = 4;
            this.locationLbl.Text = "Location:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(309, 289);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(432, 289);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Location = new System.Drawing.Point(24, 176);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(60, 17);
            this.contactLbl.TabIndex = 7;
            this.contactLbl.Text = "Contact:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(24, 206);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(44, 17);
            this.typeLbl.TabIndex = 8;
            this.typeLbl.Text = "Type:";
            // 
            // urlLbl
            // 
            this.urlLbl.AutoSize = true;
            this.urlLbl.Location = new System.Drawing.Point(24, 238);
            this.urlLbl.Name = "urlLbl";
            this.urlLbl.Size = new System.Drawing.Size(104, 17);
            this.urlLbl.TabIndex = 9;
            this.urlLbl.Text = "URL (optional):";
            // 
            // appointmentIdBox
            // 
            this.appointmentIdBox.Location = new System.Drawing.Point(134, 16);
            this.appointmentIdBox.Name = "appointmentIdBox";
            this.appointmentIdBox.ReadOnly = true;
            this.appointmentIdBox.Size = new System.Drawing.Size(132, 22);
            this.appointmentIdBox.TabIndex = 10;
            // 
            // customerIdBox
            // 
            this.customerIdBox.Location = new System.Drawing.Point(134, 49);
            this.customerIdBox.Name = "customerIdBox";
            this.customerIdBox.Size = new System.Drawing.Size(132, 22);
            this.customerIdBox.TabIndex = 0;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(134, 79);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(132, 22);
            this.titleBox.TabIndex = 1;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(134, 143);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(132, 22);
            this.locationBox.TabIndex = 3;
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(134, 173);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(132, 22);
            this.contactBox.TabIndex = 4;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(134, 238);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(236, 22);
            this.urlBox.TabIndex = 6;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Information",
            "Closing Contract",
            "Other"});
            this.typeComboBox.Location = new System.Drawing.Point(134, 203);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(132, 24);
            this.typeComboBox.TabIndex = 5;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(134, 110);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(381, 22);
            this.descriptionBox.TabIndex = 2;
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Location = new System.Drawing.Point(306, 52);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(42, 17);
            this.startLbl.TabIndex = 19;
            this.startLbl.Text = "Start:";
            // 
            // endLbl
            // 
            this.endLbl.AutoSize = true;
            this.endLbl.Location = new System.Drawing.Point(306, 82);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(37, 17);
            this.endLbl.TabIndex = 20;
            this.endLbl.Text = "End:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(372, 21);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(143, 22);
            this.datePicker.TabIndex = 21;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(306, 21);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(42, 17);
            this.dateLbl.TabIndex = 22;
            this.dateLbl.Text = "Date:";
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "HH:mm";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(372, 77);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(143, 22);
            this.endTimePicker.TabIndex = 24;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "HH:mm";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(372, 49);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(143, 22);
            this.startTimePicker.TabIndex = 23;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 329);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.endLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.customerIdBox);
            this.Controls.Add(this.appointmentIdBox);
            this.Controls.Add(this.urlLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.contactLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.customerIdLbl);
            this.Controls.Add(this.appointmentIdLbl);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointmentIdLbl;
        private System.Windows.Forms.Label customerIdLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.TextBox appointmentIdBox;
        private System.Windows.Forms.TextBox customerIdBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Label endLbl;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
    }
}
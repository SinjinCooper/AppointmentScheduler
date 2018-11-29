namespace c969
{
    partial class UpdateCustomer
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.customerIdBox = new System.Windows.Forms.TextBox();
            this.activeLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.zipLbl = new System.Windows.Forms.Label();
            this.countryLbl = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.activeChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(136, 60);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 0;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(136, 96);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(339, 22);
            this.addressBox.TabIndex = 1;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(136, 199);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(132, 22);
            this.phoneBox.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(35, 64);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 17);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(35, 96);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(64, 17);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Address:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(35, 203);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(53, 17);
            this.phoneLbl.TabIndex = 5;
            this.phoneLbl.Text = "Phone:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(235, 265);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(376, 265);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 28);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(35, 32);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(89, 17);
            this.idLbl.TabIndex = 8;
            this.idLbl.Text = "Customer ID:";
            // 
            // customerIdBox
            // 
            this.customerIdBox.Location = new System.Drawing.Point(136, 28);
            this.customerIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerIdBox.Name = "customerIdBox";
            this.customerIdBox.ReadOnly = true;
            this.customerIdBox.Size = new System.Drawing.Size(132, 22);
            this.customerIdBox.TabIndex = 9;
            // 
            // activeLbl
            // 
            this.activeLbl.AutoSize = true;
            this.activeLbl.Location = new System.Drawing.Point(35, 271);
            this.activeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeLbl.Name = "activeLbl";
            this.activeLbl.Size = new System.Drawing.Size(50, 17);
            this.activeLbl.TabIndex = 10;
            this.activeLbl.Text = "Active:";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(35, 133);
            this.cityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(35, 17);
            this.cityLbl.TabIndex = 11;
            this.cityLbl.Text = "City:";
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Location = new System.Drawing.Point(309, 132);
            this.zipLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(32, 17);
            this.zipLbl.TabIndex = 12;
            this.zipLbl.Text = "Zip:";
            // 
            // countryLbl
            // 
            this.countryLbl.AutoSize = true;
            this.countryLbl.Location = new System.Drawing.Point(35, 172);
            this.countryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.Size = new System.Drawing.Size(61, 17);
            this.countryLbl.TabIndex = 13;
            this.countryLbl.Text = "Country:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(136, 129);
            this.cityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(132, 22);
            this.cityBox.TabIndex = 14;
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(352, 128);
            this.zipBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(123, 22);
            this.zipBox.TabIndex = 15;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(136, 167);
            this.countryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(132, 22);
            this.countryBox.TabIndex = 16;
            // 
            // activeChk
            // 
            this.activeChk.AutoSize = true;
            this.activeChk.Location = new System.Drawing.Point(105, 270);
            this.activeChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activeChk.Name = "activeChk";
            this.activeChk.Size = new System.Drawing.Size(18, 17);
            this.activeChk.TabIndex = 17;
            this.activeChk.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 321);
            this.Controls.Add(this.activeChk);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryLbl);
            this.Controls.Add(this.zipLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.activeLbl);
            this.Controls.Add(this.customerIdBox);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox customerIdBox;
        private System.Windows.Forms.Label activeLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label zipLbl;
        private System.Windows.Forms.Label countryLbl;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.CheckBox activeChk;
    }
}
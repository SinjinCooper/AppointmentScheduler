using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c969
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Test this validation
            if (nameBox.Text == "" || addressBox.Text == "" || phoneBox.Text == "")
            {
                MessageBox.Show("Please enter information for all fields before saving.");
                return;
            }

            string country = "";

            switch(cityComboBox.Text)
            {
                case "Phoenix":
                    country = "USA";
                    break;
                case "New York":
                    country = "USA";
                    break;
                case "London":
                    country = "England";
                    break;
            }

            Customer newCust = new Customer()
            {
                CustomerId = 1,
                Name = nameBox.Text,
                Address = addressBox.Text,
                City = cityComboBox.Text,
                CityId = Database.GetCityIdByCity(cityComboBox.Text),
                Phone = phoneBox.Text,
                Country = country,
                Active = activeChk.Checked,
            };
            
            Database.AddNewCustomer(newCust);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

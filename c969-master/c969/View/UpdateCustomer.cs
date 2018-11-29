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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer(Customer customer)
        {
            InitializeComponent();

            // Populate fields with selected customer's data.
            customerIdBox.Text = customer.CustomerId.ToString();
            nameBox.Text = customer.Name;
            addressBox.Text = customer.Address;
            phoneBox.Text = customer.Phone;
            cityBox.Text = customer.City;
            zipBox.Text = customer.Zip;
            countryBox.Text = customer.Country;
            activeChk.Checked = customer.Active;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Test this validation
            if (nameBox.Text == "" || addressBox.Text == "" || phoneBox.Text == "" ||
                cityBox.Text == "" || zipBox.Text == "" || countryBox.Text == "")
            {
                MessageBox.Show("Please fill all required fields before saving.");
                return;
            }

            Customer updatedCustomer = new c969.Customer(Convert.ToInt32(customerIdBox.Text), nameBox.Text, addressBox.Text, phoneBox.Text,
                                                        cityBox.Text, zipBox.Text, countryBox.Text, activeChk.Checked, DateTime.Now);
            updatedCustomer.AddressId = updatedCustomer.CustomerId;
            Database.UpdateCustomer(updatedCustomer);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

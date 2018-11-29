using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c969.View
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            FillCustGridView();
        }

        private void FillCustGridView()
        {
            DataTable table = Database.FillCustomerView();
            customersGridView.DataSource = table;
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            new AddCustomer().ShowDialog();
        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            int custId = Convert.ToInt32(customersGridView.CurrentRow.Cells["customerId"].Value);
            Customer selectedCustomer = Database.GetCustomerForUpdate(custId);
            new UpdateCustomer(selectedCustomer).ShowDialog();
            FillCustGridView();
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            // OPTIONAL: add warning message box for customer deletion
            int custId = Convert.ToInt32(customersGridView.CurrentRow.Cells["customerId"].Value);
            int addrId = Convert.ToInt32(customersGridView.CurrentRow.Cells["addressId"].Value);
            Database.DeleteCustomer(custId, addrId);

            FillCustGridView();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

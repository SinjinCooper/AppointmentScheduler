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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Test this validation
            if (customerIdBox.Text == "" || titleBox.Text == "" || descriptionBox.Text == "" ||
                locationBox.Text == "" || contactBox.Text == "")
            {
                MessageBox.Show("Please fill all required fields before saving.");
                return;
            }

            Appointment newAppt = new Appointment()
            {
                AppointmentId = Convert.ToInt32(appointmentIdBox.Text),
                CustomerId = Convert.ToInt32(customerIdBox.Text),
                //UserId = Database.GetCurrentUserId(),
                Title = titleBox.Text,
                Description = descriptionBox.Text,
                Location = locationBox.Text,
                Type = typeComboBox.SelectedText,
                Url = urlBox.Text,
                Start = datePicker.Value.Date.Add(startTimePicker.Value.TimeOfDay),
                End = datePicker.Value.Date.Add(endTimePicker.Value.TimeOfDay)
            };

            Database.AddNewAppointment(newAppt);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

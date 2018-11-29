using c969.View;
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
    public partial class MainForm : Form
    {
        DateTime selectedDate;
        DataTable table;

        public MainForm()
        {
            // Appointment view table initialized to show appts for today.
            InitializeComponent();
            FillApptGridView();
            //DateTime today = apptCalendar.SelectionRange.Start.Date;
            //table = Database.FillAppointmentView(today, weekRadio.Checked);
            //apptGridView.DataSource = table;
        }

        private void FillApptGridView()
        {
            DateTime today = apptCalendar.SelectionRange.Start.Date;
            table = Database.FillAppointmentView(today, weekRadio.Checked);
            apptGridView.DataSource = table;
        }

        private void apptCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Show the appts for the selected date.
            FillApptGridView();
            //selectedDate = apptCalendar.SelectionRange.Start.Date;
            //table = Database.FillAppointmentView(selectedDate, weekRadio.Checked);
            //apptGridView.DataSource = table;
        }


        
        private void addBtn_Click(object sender, EventArgs e)
        {
            new AddAppointment().ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Appointment appt = (Appointment)apptGridView.CurrentRow.DataBoundItem;
            new EditAppointment(appt).ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // OPTIONAL: Create pop-up to confirm deletion of selected appt
            int apptId = Convert.ToInt32(apptGridView.CurrentRow.Cells[0].Value);
            Database.DeleteAppointment(apptId);
            FillApptGridView();
        }


        private void customersBtn_Click(object sender, EventArgs e)
        {
            new CustomersForm().ShowDialog();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            new ReportsForm().ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // OPTIONAL: Confirm log out and exit?
            this.Close();
        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e)
        {
            selectedDate = apptCalendar.SelectionRange.Start.Date;
            table = Database.FillAppointmentView(selectedDate, true);
            apptGridView.DataSource = table;
            // Refresh bindings?
        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e)
        {
            selectedDate = apptCalendar.SelectionRange.Start.Date;
            table = Database.FillAppointmentView(selectedDate, false);
            apptGridView.DataSource = table;
            // Refresh Bindings?
        }
    }
}

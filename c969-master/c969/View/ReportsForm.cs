using c969.Model;
using MySql.Data.MySqlClient;
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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        public void GetUserSchedules()
        {
            DataTable table = new DataTable();
            string query = "SELECT userId, appointmentId, start FROM appointment ORDER BY userId;";
            MySqlCommand command = new MySqlCommand(query, Database.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);
            reportsGrid.DataSource = table;
        }

        public void GetAppointmentTypeReport()
        {
            DataTable table = new DataTable();

            // for typeQuery include month start and end parameters.
            string typeQuery = "SELECT DISTINCT type, COUNT(type) FROM appointment WHERE (start > @start && end < @end) GROUP BY type;";
            MySqlCommand command = new MySqlCommand(typeQuery, Database.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);
            reportsGrid.DataSource = table;
        }

        // THIRD REPORT
        // possibly showing the number of morning appts vs afternoon appts?
    }
}

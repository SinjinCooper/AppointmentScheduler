using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using c969.View;

namespace c969
{
    class Database
    {
        public static MySqlConnection connection = new MySqlConnection("server=52.206.157.109;database=U04saS;user id=U04saS;password=53688333038");
        static MySqlCommand command;
        static MySqlDataAdapter adapter;

        public static void OpenDatabase()
        {
            connection.Close();
            connection.Open();
        }

        public static DataTable FillCustomerView()
        {
            string fillQuery = "SELECT customerId, addressId, customerName, active FROM customer;";
            command = new MySqlCommand(fillQuery, connection);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable FillAppointmentView(DateTime date, bool isWeekView)
        {
            DateTime start;
            DateTime end;
            if (isWeekView)
            {
                start = FirstDayOfWeek(date);
                end = LastDayOfWeek(date);
            }
            else
            {
                start = FirstDayOfMonth(date);
                end = LastDayOfMonth(date);
            }

            // Fill the table with data between the two above dates.
            string fillQuery = "SELECT appointmentId, customerId, userId, title, appointmentType FROM appointment WHERE start > @start AND end < @end;";
            command = new MySqlCommand(fillQuery, connection);
            command.Parameters.AddWithValue("@start", start);
            command.Parameters.AddWithValue("@end", end);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static Customer GetCustomerForUpdate(int customerId)
        {
            string customerQuery = "SELECT customerId, customerName, addressId, active FROM customer WHERE customerId = @customerId;";
            command = new MySqlCommand(customerQuery, connection);
            command.Parameters.AddWithValue("@customerId", customerId);
            adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow row = table.Rows[0];

            Customer customer = new Customer()
            {
                CustomerId = customerId,
                AddressId = Convert.ToInt32(row["addressId"]),
                Name = row["customerName"].ToString(),
                Active = Convert.ToBoolean(row["active"].ToString())
            };

            string addressQuery = "SELECT address, postalCode, phone, cityId FROM address WHERE addressId = @addressId;";
            command = new MySqlCommand(addressQuery, connection);
            command.Parameters.AddWithValue("@addressId", Convert.ToInt32(row["addressId"]));
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            row = table.Rows[0];

            customer.Address = row["address"].ToString();
            customer.Zip = row["postalCode"].ToString();
            customer.Phone = row["phone"].ToString();
            customer.City = GetCityByCityId(Convert.ToInt32(row["cityId"]));
            if (customer.City == "London")
                customer.Country = "England";
            else
                customer.Country = "USA";

            return customer;
        }

        public static DateTime FirstDayOfWeek(DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-diff).Date;
        }

        public static DateTime LastDayOfWeek(DateTime dt)
        {
            return FirstDayOfWeek(dt).AddDays(6);
        }

        public static DateTime FirstDayOfMonth(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }

        public static DateTime LastDayOfMonth(DateTime dt)
        {
            return FirstDayOfMonth(dt).AddMonths(1).AddDays(-1);
        }

        public static int GetCityIdByCity(string city)
        {
            if (city == "London")
                return 0;
            else if (city == "New York")
                return 1;
            else
                return 2;
        }

        public static string GetCityByCityId(int cityId)
        {
            if (cityId == 2)
                return "Phoenix";
            else if (cityId == 1)
                return "New York";
            else
                return "London";
        }

        // I don't know whether this is needed
        //public static int GetCurrentUserId()
        //{
        //    string selectQuery = "SELECT userId FROM user where userName = @userName;";
        //    command = new MySqlCommand(selectQuery, connection);
        //    command.Parameters.AddWithValue("@userName", Database.username);
        //    int currentUserId = Convert.ToInt32(command.ExecuteScalar());
        //    return currentUserId;
        //}


        //For these three functions, update the parameters to what is needed. Change parameters to SqlParameters
        public static void AddNewCustomer(Customer customer)
        {
            string insertQuery = "INSERT INTO customer (customerName, addressId, active)" +
                " VALUES (@customerName, @addressId, @active);";
            command = new MySqlCommand(insertQuery, connection);
            //command.Parameters.AddWithValue("@customerId", customer.CustomerId + 1);
            command.Parameters.AddWithValue("@customerName", customer.Name);
            command.Parameters.AddWithValue("@addressId", customer.AddressId);
            command.Parameters.AddWithValue("@active", customer.Active);
            //connection.Open();
            command.ExecuteNonQuery();

            insertQuery = "INSERT INTO address (address, cityId, postalCode, phone)" +
                " VALUES (@address, @cityId, @postalCode, @phone);";
            //command.Parameters.AddWithValue("@addressId", customer.AddressId);
            command.Parameters.AddWithValue("@address", customer.Address);
            command.Parameters.AddWithValue("@cityId", customer.CityId);
            command.Parameters.AddWithValue("@postalCode", customer.Zip);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.ExecuteNonQuery();

            //command.Connection.Close();
        }

        public static void UpdateCustomer(Customer customer)
        {
            // Add mmore fields to be updated, e.g. phone
            string updateCustomerQuery = "UPDATE customer SET customerName = @customerName, addressId = @addressId, active = @active WHERE customerId = @customerId;";
            command = new MySqlCommand(updateCustomerQuery, connection);
            command.Parameters.AddWithValue("@customerId", customer.CustomerId);
            command.Parameters.AddWithValue("@customerName", customer.Name);
            command.Parameters.AddWithValue("@addressId", customer.AddressId);
            command.Parameters.AddWithValue("@active", customer.Active);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();

            string updateAddressQuery = "UPDATE address SET address = @address, cityId = @cityId, postalCode = @postalCode, phone = @phone WHERE addressId = @addressId;";
            command = new MySqlCommand(updateAddressQuery, connection);
            command.Parameters.AddWithValue("@addressId", customer.AddressId);
            command.Parameters.AddWithValue("@address", customer.Address);
            command.Parameters.AddWithValue("@cityId", GetCityIdByCity(customer.City));
            command.Parameters.AddWithValue("@postalCode", customer.Zip);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void DeleteCustomer(int customerId, int addressId)
        {
            string deleteCustomerQuery = "DELETE FROM customer WHERE customerId = @customerId;";
            command = new MySqlCommand(deleteCustomerQuery, connection);
            command.Parameters.AddWithValue("@customerId", customerId);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();

            string deleteAddressQuery = "DELETE FROM address WHERE addressId = @addressId;";
            command = new MySqlCommand(deleteAddressQuery, connection);
            command.Parameters.AddWithValue("@addressId", addressId);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void AddNewAppointment(Appointment appt)
        {
            string insertQuery = "INSERT INTO appointment (appointmentId, customerId, userId, title, description, location, contact, appointmentType, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                " VALUES (@appointmentId, @customerId, @userId, @title, @description, @location, @contact, @appointmentType, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy);";
            command = new MySqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@appointmentId", appt.AppointmentId);
            command.Parameters.AddWithValue("@customerId", appt.CustomerId);
            command.Parameters.AddWithValue("@userId", appt.UserId);
            command.Parameters.AddWithValue("@title", appt.Title);
            command.Parameters.AddWithValue("@description", appt.Description);
            command.Parameters.AddWithValue("@location", appt.Location);
            command.Parameters.AddWithValue("@contact", appt.Contact);
            command.Parameters.AddWithValue("@appointmentType", appt.Type);
            command.Parameters.AddWithValue("@url", appt.Url);
            command.Parameters.AddWithValue("@start", appt.Start);
            command.Parameters.AddWithValue("@end", appt.End);
            command.Parameters.AddWithValue("@createDate", DateTime.Now);
            //command.Parameters.AddWithValue("@createdBy", Database.GetCurrentUser());
            //command.Parameters.AddWithValue("@lastUpdate", appt.LastUpdate);
            //command.Parameters.AddWithValue("@lastUpdatedBy", appt.LastUpdatedBy);
            connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public static void UpdateAppointment(Appointment appt)
        {
            string updateQuery = "UPDATE appointment SET appointmentId = @appointmentId, customerId = @customerId, userId = @userId, title = @title, description = @description," +
                " location = @location, contact = @contact, appointmentType = @appointmentType, url = @url, start = @start, end = @end WHERE appointmentId = @appointmentId;";
            command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@appointmentId", appt.AppointmentId);
            command.Parameters.AddWithValue("@customerId", appt.CustomerId);
            command.Parameters.AddWithValue("@userId", appt.UserId);
            command.Parameters.AddWithValue("@title", appt.Title);
            command.Parameters.AddWithValue("@description", appt.Description);
            command.Parameters.AddWithValue("@location", appt.Location);
            command.Parameters.AddWithValue("@contact", appt.Contact);
            command.Parameters.AddWithValue("@appointmentType", appt.Type);
            command.Parameters.AddWithValue("@url", appt.Url);
            command.Parameters.AddWithValue("@start", appt.Start);
            command.Parameters.AddWithValue("@end", appt.End);
            connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public static void DeleteAppointment(int appointmentId)
        {
            string deleteQuery = "DELETE FROM appointment WHERE appointmentId = @appointmentId;";
            command = new MySqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@appointmentId", appointmentId);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void GetTypeReportData()
        {
            string typeQuery = "SELECT DISTINCT type FROM appointment";
            command = new MySqlCommand(typeQuery, connection);
            string countQuery = "";
        }
    }
}

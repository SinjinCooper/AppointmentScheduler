using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c969
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public User CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public User LastUpdatedBy { get; set; }

        //Default Constructor
        public Customer() { }

        public Customer(int id, string name, int addressId, bool active, DateTime createDate, User createdBy, DateTime lastUpdate, User lastUpdatedBy)
        {
            CustomerId = id;
            Name = name;
            AddressId = addressId;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;
        }
        public Customer(int id, string name, string address, string phone, string city, string zip, string country, bool active, DateTime createDate)
        {
            CustomerId = id;
            Name = name;
            Address = address;
            Phone = phone;
            City = city;
            Zip = zip;
            Country = country;
            Active = active;
            CreateDate = createDate;
        }
    }
}

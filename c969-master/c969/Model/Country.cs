using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c969.Model
{
    class Country
    {
        public List<City> ListOfCities = new List<City>();
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public Country()
        {

        }
    }
}

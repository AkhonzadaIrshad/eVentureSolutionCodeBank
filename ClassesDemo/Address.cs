using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public class Address
    {

        private City city;

        public City City
        {
            get { return city; }
            set { city = value; }
        }

        public Address()
        {
            City = new City(null);
        }

    }
}

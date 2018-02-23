using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSiteApplicationEntitiesDemo.General
{
    public class Address
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        private City city;

        public City City
        {
            get { return city; }
            set { city = value; }
        }

    }
}

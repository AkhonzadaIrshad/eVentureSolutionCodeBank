using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public class City
    {
        private Country country;

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }

        public City(Country country)
        {
            this.country = country;
        }


    }
}

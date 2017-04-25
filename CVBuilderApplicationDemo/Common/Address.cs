using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilderApplicationDemo.Common
{
  public class Address
    {
        public Address()
        {
            City=new City();
        }
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

        public virtual City City
        {
            get { return city; }
            set { city = value; }
        }

    }
}

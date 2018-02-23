using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingSiteApplicationEntitiesDemo.General;

namespace ShoppingSiteApplicationEntitiesDemo.Users
{
    public class Person
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }


    }
}

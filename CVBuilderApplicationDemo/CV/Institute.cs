using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVBuilderApplicationDemo.Common;

namespace CVBuilderApplicationDemo.CV
{
    public class Institute
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }


    }
}

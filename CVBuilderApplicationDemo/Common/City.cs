using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilderApplicationDemo.Common
{
   public class City
    {
        public City()
        {
            Country=new Country();
        }


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
        private int code;
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        private  Country country;

        public virtual Country Country
        {
            get { return country; }
            set { country = value; }
        }


    }
}

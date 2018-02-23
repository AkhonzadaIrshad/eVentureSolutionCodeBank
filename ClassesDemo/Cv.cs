using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public class Cv
    {
        private PersonalInforamtion pi;

        public PersonalInforamtion Pi
        {
            get { return pi; }
            set { pi = value; }
        }

        public Cv()
        {
            Pi = new PersonalInforamtion();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVBuilderApplicationDemo.CV
{
    public class ExperienceInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime joiningDate;

        public DateTime JoiningDate
        {
            get { return joiningDate; }
            set { joiningDate = value; }
        }
        private DateTime? endingDate;

        public DateTime? EndingDate
        {
            get { return endingDate; }
            set { endingDate = value; }
        }


        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        private Firm firm;
        public Firm Firm
        {
            get { return firm; }
            set { firm = value; }
        }



    }
}
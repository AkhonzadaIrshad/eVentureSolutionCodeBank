using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVBuilderApplicationDemo.CV
{
    public class EducationalInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string degree;

        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        private Institute institute;

        public virtual Institute Institute
        {
            get { return institute; }
            set { institute = value; }
        }



        private DateTime? enrollmentDate;

        public DateTime? EnrollmenDate
        {
            get { return enrollmentDate; }
            set { enrollmentDate = value; }
        }

        private DateTime? graduationDate;

        public DateTime? GraduationDate
        {
            get { return graduationDate; }
            set { graduationDate = value; }
        }

    }
}
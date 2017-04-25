using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CVBuilderApplicationDemo.Common;

namespace CVBuilderApplicationDemo.CV
{
    public class PersonalInfo
    {
        public PersonalInfo()
        {
            Image=new Image();
            Address=new Address();
        }


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Image image;

        public virtual Image Image
        {
            get { return image; }
            set { image = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string fatherName;

        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }
        

        private string objective;

        public string Objective
        {
            get { return objective; }
            set { objective = value; }
        }

        private List<string> phoneNumber;

        public List<string> PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber =value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        private Address address;

        public virtual Address Address
        {
            get { return address; }
            set { address = value; }
        }




    }
}
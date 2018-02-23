using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemos
{


 class Person
    {
        protected string Name { get; set; }
        public void Display()
        {
            Name = "SOMENAME";
        }
    }

    class Student:Person
    {
        public string RollNumber { get; set; }

        public void Display()
        {
            Name = "SOMENAME";
        }


    }

    class Teacher : Person
    {
        public void Display()
        {
            Name = "SOMENAME";
        }

    }

    class A:Student
    {
        public void Display()
        {
            Name = "SOMENAME";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            Student student=new Student();
            Teacher teacher=new Teacher();

            //Type

            //Type type = student.GetType();

            //Console.WriteLine(type.Assembly);
            //Console.WriteLine(type.FullName);
            //Console.WriteLine(type.GetProperty("Name"));





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.DelegateDemos
{
    internal partial class SimpleDemo
    {
        static string GetName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        delegate string MyMetod(string f, string l);




        //static void Main(string[] args)
        //{


        //    MyMetod m = GetName;


        //    //MyMetod m2 = (a, b) => a + b;


        //    Console.WriteLine(m("EVS", "Lahore"));



        //    // Console.WriteLine(GetName("Irshad", "Ahmed"));

            
        //    Console.WriteLine("Press Any Key To Continue...");
        //    Console.ReadKey();
        //}
    }
}

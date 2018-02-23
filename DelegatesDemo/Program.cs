using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program2
    {

        //public static float Add(int a, int b)
        //{
        //    return a + b;
        //}
        public static void Main(string[] args)
        {

            Calculator calculator=new Calculator();
            calculator.ValueOne = 12;
            calculator.ValueTwo = 1;

            Calculator.CustomLogic customLogic;
            //customLogic = (x, y) =>  x + y;
            customLogic = (x, y) =>  x - y;
            //customLogic += (x, y) =>  x * y;
            //customLogic += (x, y) =>  x / y;



            calculator.StartOperation(customLogic);

            Console.ReadKey();


        }

    }





    //class Program
    //{


    //    //public static void SomeMethod()
    //    //{
    //    //    Console.WriteLine("Hello Information");
    //    //}
    //    //public static void SomeMethod2()
    //    //{
    //    //    Console.WriteLine("Hello Information From Second Method");
    //    //}











    //   // public  delegate void FirstDelegate();

    //    static void Main(string[] args)
    //    {
    //        //FirstDelegate firstDelegate=SomeMethod;
    //        //firstDelegate+=SomeMethod2;


    //        //firstDelegate();
    //      //  firstDelegate.Invoke();


    //        Console.ReadKey();

    //    }
    //}
}

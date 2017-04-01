using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.DelegateDemos
{
    internal partial class MultipleMethodsInDelegate
    {

        delegate void MethodList(string data);




        //static void Main(string[] args)
        //{
        //    MethodList methods =MethodOne;
        //    methods += MethodTwo;
        //    methods += MethodThree;

        //    methods("Irshad");
        //    Console.ReadKey();
        //}


        static void MethodOne(string input)
        {
            Console.WriteLine("Hello I'm Method One and your data is : {0} ", input);
        }
        static void MethodTwo(string input)
        {
            Console.WriteLine("Hello I'm Method Two and your data is : {0} ", input);
        }
        static void MethodThree(string input)
        {
            Console.WriteLine("Hello I'm Method Three and your data is : {0} ", input);
        }



    }
}

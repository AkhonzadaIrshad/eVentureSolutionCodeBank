using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordsIn_C_Sharp_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object 
            //Partial classes object treat as single object 
            @class @class=new @class();
            //Setting Value
            @class.@string = "This is string";
            @class.@int = 123;
            @class.@float = 0.00f;
            //Getting Value
            Console.WriteLine(@class.@string);
            Console.WriteLine(@class.@int);
            Console.WriteLine(@class.@float);
            Console.ReadKey();
        }
    }

    //using same name of class as the same class identifier
    //using partial keyword to create two classes with the same name 
    public partial class @class
    {
        //using same of property name as the string identifier 
        public string @string { get; set; }

        public int @int { get; set; }
    }

    public partial class @class
    {
        public float @float { get; set; }
    }
}

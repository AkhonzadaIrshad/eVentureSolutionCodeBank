using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.EventDemo
{
  internal  partial class Program
    {




        static void Main(string[] args)
        {
            DummyClass dummyObj=new DummyClass();
            dummyObj.OnPropertyChange += DummyObj_OnPropertyChange;
            dummyObj.DummyName = "Irshad";
            Console.ReadKey();

        }

        private static void DummyObj_OnPropertyChange(object sender, EventArgs e)
        {
            Console.WriteLine("Property is Just Changed to {0}",((DummyClass)sender).DummyName);
            //Console.WriteLine("Property is Just Changed to {0}",sender is DummyClass);
        }
    }
}

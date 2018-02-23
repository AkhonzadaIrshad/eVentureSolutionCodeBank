using System;

namespace DelegatesDemo
{
    class Calculator
    {

        public delegate float CustomLogic(int one, int two);
        public int ValueOne { get; set; }
        public int ValueTwo { get; set; }

        public void StartOperation(CustomLogic customLogic) 
        {
            Console.WriteLine($"Your Result : {customLogic(ValueOne, ValueTwo)}");
        }
    }
}
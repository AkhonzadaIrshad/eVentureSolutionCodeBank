using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremaxChallengesSolution
{
    public class SecondTask
    {

        public int GetMin(int[] X)
        {
            int min = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (min > X[i])
                {
                    min = X[i];
                }
            }
            return min;
        }

        public bool Contains(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int solution(int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int minA = GetMin(A);
            int minB = GetMin(B);
            if (minA == minB)
            {
                return minA;
            }
            else
            {
                return -1;
            }


        }

        static void Main2(string[] args)
        {



            Console.ReadKey();
        }
    }
}

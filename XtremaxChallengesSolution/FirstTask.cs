using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremaxChallengesSolution
{
    class SolutionWithReverseMethod
    {
        public string solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string reversed = string.Empty;
            foreach (string word in S.Split(' '))
            {
                foreach (char _char in word.Reverse())
                {
                    reversed += _char;
                }

                reversed += " ";

            }
            return reversed;

        }
    }
    class SolutionWithoutReverseMethod
    {
        public string solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string reversed = string.Empty;
            foreach (string word in S.Split(' '))
            {
                for (int i = word.Length - 1; i >= 0; i--)
                    reversed += word[i];
                reversed += " ";
            }
            return reversed.TrimEnd();
        }
    }

    class FirstTask
    {
        static void Main1(string[] args)
        {

            // Console.WriteLine(new SolutionWithReverse().solution("This is EVS Lahore"));
            Console.WriteLine(new SolutionWithoutReverseMethod().solution("This is EVS Lahore"));
            Console.ReadKey();
        }
    }
}

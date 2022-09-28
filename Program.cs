using System.Numerics;
using System;
using System.Linq;
using System.Collections.Generic;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do Console.WriteLine("How many numbers would you like to see in the sequence?");
            while (!int.TryParse(Console.ReadLine(), out n) || n >= 1000);

            Console.Write(FibonacciCalculator(n));


        }
            static string FibonacciCalculator(int n)
            {

                List<BigInteger> fnList = new List<BigInteger>();

                fnList.Add(1); //0th position is replaced by 0 later

                for (int i = 0; i < n - 2; i++) // n -2 because the first 2 of the sequence are hard-coded
                {

                    if (i == 0) //handle out of range exceptions
                    {

                        fnList.Add(1);
                    }

                    if (i > 0)
                    {
                        BigInteger sum = fnList[i - 1] + fnList[i];

                        fnList.Add(sum);
                    }

                }

                fnList.Insert(0, 0); // do all the calculations first and then add 0 in the 0th position (cheating but whatever)
                return string.Join($"\n", fnList); //return the list
            }



    }
}

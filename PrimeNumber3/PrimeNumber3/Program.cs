using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber3
{
    class Program
    {
        static bool check (string x) // function that checks whather the number is prime or not 
        {
            int count = 0; // counter that count the number of divided numbers
            int a = int.Parse(x);
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }
            if (count == 2) return true;
            return false;

        }

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (check (args[i]))
                {
                    Console.WriteLine(args[i]);
                }

            }
            Console.ReadKey();
        }
    }
}
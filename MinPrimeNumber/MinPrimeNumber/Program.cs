using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinPrimeNumber
{
    class Program
    {
        static bool check(int a) //function that checks whather the number prime or not
        {
            int count = 0; //counter that counts the number of divided numbers
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    count++;
            }
            if (count == 2) return true;
            return false;
        }


        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Андрей\lab2_new\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Андрей\lab2_new\output.txt");
            string s = sr.ReadLine();
            string[] arr = s.Split();

            bool pf = false;
            int min=0;
            for (int i = 0; i < arr.Length; i++)
            {
              
                int q = int.Parse(arr[i]);
                 if (check(q))
            {
                if (pf == false || q < min)
                {
                    min = q;
                    pf = true;

                }
            }
            }
            sw.WriteLine("MinPrimeNumber:" + min);
            sr.Close();
            sw.Close();
        }
    }
}

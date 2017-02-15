using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxMinFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Андрей\lab2_new\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Андрей\lab2_new\output.txt");
            string s = sr.ReadLine(); // 7 45 18 2 10
            string[] arr = s.Split(); //"7" "45" "18" "2" "10"
            int max = 0;
            int min = int.Parse(arr[0]);
            for (int i = 0; i < arr.Length; i++)
            {
                int q = int.Parse(arr[i]);
                if (q > max)
                {
                    max = q;
                }
                if (q < min)
                {
                    min = q;
                }
            }
            sw.WriteLine("max:" + max);
            sw.WriteLine("min:" + min);
            sw.Close();
            sr.Close();
        }
    }
}

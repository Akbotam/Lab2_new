using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinPrime
{
    class Program
    {
            static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Андрей\lab2_new\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Андрей\lab2_new\output.txt");
            string s = sr.ReadLine();
            string[] ss = s.Split();
            int n = ss.Length;
            int[] na = new int[n];
            for (int i = 0; i < n; i++)
            {
                na[i] = int.Parse(ss[i]);
            }
            Array.Sort(na);

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 1; j <= na[i]; j++)
                {
                    if (na[i] % j == 0)
                    {
                        count++;
                    }
                }
                if (count==2)
                {
                    sw.WriteLine(na[i]);
                    break;
                }
            }
            sw.Close();
            sr.Close();
                
        }
    }
}

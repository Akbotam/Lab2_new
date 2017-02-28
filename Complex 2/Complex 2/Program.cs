using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_2
{
    class Program
    {
        class Complex
        {
            public int a;
            public int b;

            public Complex(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public static void crt(int a1, int b1)
            {
                if (a1 > b1)
                {
                    for (int d = b1; d > 0; d--)
                    {
                        if (a1 % d == 0 && b1 % d == 0)
                        {
                            int nod = d;
                            a1 = a1 / nod;
                            b1 = b1/ nod;
                            break;
                        }
                    }
                }
                else
                {
                    for (int d = a1; d > 0; d--)
                    {
                        if (a1 % d == 0 && b1 % d == 0)
                        {
                            int nod = d;
                            a1 = a1 / nod;
                            b1 = b1/ nod;
                            break;
                        }
                    }

                }
                Console.WriteLine(a1+ "/" + b1);
            }
            public static Complex operator + (Complex c1, Complex c2)
            {
                Complex c3 = new Complex(0, 0);
                c3.a = c1.a * c2.b + c2.a * c1.b;
                c3.b = c1.b * c2.b;
                crt(c3.a, c3.b);
                return c3;

            }
            public static Complex operator -(Complex c1, Complex c2)
            {
                Complex c4 = new Complex(0, 0);
                c4.a = c1.a * c2.b - c2.a * c1.b;
                c4.b = c1.b * c2.b;
                crt(c4.a, c4.b);
                return c4;

            }
            public static Complex operator * (Complex c1, Complex c2)
            {
                Complex c5 = new Complex(0, 0);
                c5.a = c1.a * c2.a;
                c5.b = c1.b * c2.b;
                crt(c5.a, c5.b);
                return c5;

            }
            public static Complex operator / (Complex c1, Complex c2)
            {
                Complex c6 = new Complex(0, 0);
                c6.a = c1.a * c2.b;
                c6.b = c1.b * c2.a;
                crt(c6.a, c6.b);
                return c6;

            }


        }





             static void Main(string[] args)
        {
            Complex c1 = new Complex(5, 2);
            Complex c2 = new Complex(4, 4);
            Complex c3 = c1 + c2;
            Complex c4 = c1 - c2;
            Complex c5 = c1 * c2;
            Complex c6 = c1 / c2; 
            Console.WriteLine(c3.a + "/" + c3.b);
            Console.WriteLine(c4.a + "/" + c4.b);
            Console.WriteLine(c5.a + "/" + c5.b);
            Console.WriteLine(c6.a + "/" + c6.b);
            Console.ReadKey(); 

        }
    }
}

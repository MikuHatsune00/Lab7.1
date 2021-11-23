using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину 1 первого треугольика:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 2 первого треугольника:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 3 первого треугольника:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            double S1;
            STriangle(a1, b1, c1,out  S1);
            Console.WriteLine("{0:0.00}", S1);
            Console.WriteLine("Введите длину 1 второго треугольника:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 2 первого треугольника:");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 3 первого треугольника:");
            int c2 = Convert.ToInt32(Console.ReadLine());
            double S2;
            STriangle(a2, b2, c2,out S2);
            Console.WriteLine("{0:0.00}", S2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше второго");
                            }
          else
            {
                Console.WriteLine("Площадь второго треугольника больше первого");

            }
            Console.ReadKey();
        }
        static void STriangle(int a,int b, int c, out double S)
        {
            double P = Convert.ToDouble((a + b + c) / 2);
            double A = Convert.ToDouble(a);
            double B = Convert.ToDouble(b);
            double C = Convert.ToDouble(c);
            S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
           
        }

       

    }
}

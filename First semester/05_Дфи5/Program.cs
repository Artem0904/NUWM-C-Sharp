using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lab5
{
    internal class Program
    {

        static double x, y;
        static double a, b, c;
        static void Main()
        {
            //Do while

            //string buf;
            //Console.WriteLine("Введіть значення m=");
            //buf = Console.ReadLine();
            //int m = Convert.ToInt32(buf);
            //int m1 = m;
            //Console.WriteLine("Введіть значення n=");
            //buf = Console.ReadLine();
            //int n = Convert.ToInt32(buf);
            //int P = 1;
            //do
            //{
            //    if (m % 2 != 0)
            //        P *= m * m;
            //    m++;
            //} while (m < n);

            ////while (m < n)
            ////{
            ////    if (m % 2 != 0)
            ////        P *= m * m;
            ////    m++;
            ////}

            //Console.WriteLine("m= {0} n={1} P={2}", m1, n, P);
            //Console.Read();

            //Завдання 8 (Варіант 24)

            Console.WriteLine("Введіть значення m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть значення n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int current = m;

            while (current <= n)
            {
                sum += current * current;
                current++;
            }

            Console.WriteLine("Сума квадратів чисел від {0} до {1} дорівнює {2}", m, n, sum);
            Console.ReadLine();
        }
    }
}

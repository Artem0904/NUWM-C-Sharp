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
            Console.WriteLine("Введіть значення m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть значення n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int current = m;

            do
            {
                sum += current * current;
                current++;
            } while (current <= n);

            Console.WriteLine("Сума квадратів чисел від {0} до {1} дорівнює {2}", m, n, sum);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static double x, y;
        static double a, b, c;
        static void Main(string[] args)
        {
           

            ////////// Завдання 5, В-8


            a = 0; b = 0; c = 0;
            string buf;

            Console.WriteLine("Введіть номер варіанту (1-3):");
            buf = Console.ReadLine();
            int variant = Convert.ToInt32(buf);

            switch (variant)
            {
                case 1:
                    a = 3; b = 3.5; c = 1.1;
                    break;
                case 2:
                    a = 3; b = 6.55; c = 6.55;
                    break;
                case 3:
                    a = 0.9; b = 0.9; c = 0.9;
                    break;
                default:
                    Console.WriteLine("Невірний варіант");
                    return;
            }

            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Трикутник є рівнобедреним.");
            }
            else
            {
                Console.WriteLine("Трикутник не є рівнобедреним.");
            }
        }

    }
}

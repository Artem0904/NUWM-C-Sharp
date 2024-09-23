using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1.2.1 

            //double P, x, y, t;
            //string buf;
            //Console.WriteLine("Enter x = ");
            //buf = Console.ReadLine();
            //x = Convert.ToDouble(buf);
            //Console.WriteLine("Enter y = ");
            //buf = Console.ReadLine();
            //y = Convert.ToDouble(buf);
            //Console.WriteLine("Enter t = ");
            //buf = Console.ReadLine();
            //t = Convert.ToDouble(buf);
            //P = (Math.Pow(Math.Sin(x), 3) + Math.Log(2 * y + 3 * x)) / (Math.Pow(t, Math.E) + Math.Sqrt(x));
            //Console.WriteLine($"x = {x}\n y = {y}\n t = {t}\n P = {P}");


            //#1.2.2

            //double y, x, a, b, c = 9;
            //string buf;
            //Console.WriteLine("Enter x=");
            //buf = Console.ReadLine();
            //x = Convert.ToDouble(buf);
            //b = x + c * c;
            //a = Math.Pow(Math.Abs(b + c), 1.0 / 3);
            //y = Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(a * a), 4);
            //Console.WriteLine("x = {0} \n a = {1}\n b = {2} \n c ={3} \n y ={4}", x, a, b, c, y);

            //#1.2.3

            //bool A = true, B = false, C = false, D;

            //D = (A | !A & B) | C;
            //Console.WriteLine("D = ({0} | !{1} & {2}) | {3} = {4}", A, A, B, C, D);

            //D = !A | A & (B | C);
            //Console.WriteLine("D = !{0} | {1} & ({2} | {3}) = {4}", A, A, B, C, D);

            //D = (A | B & !C) & C;
            //Console.WriteLine("D = ({0} | {1} & !{2}) & {3} = {4}", A, B, C, C, D);

            //Console.Read();


            //Завдання 1
            //#24

            //Console.Write("Enter a = ");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x = ");
            //double x = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y = ");
            //double y = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter c = ");
            //double c = Convert.ToDouble(Console.ReadLine());

            //double P = (Math.Pow(a, 5) + Math.Acos(a + Math.Pow(x, 3)) - Math.Pow(Math.Sin(y - c), 4)) /
            //    (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y));

            //Console.WriteLine($"P = {P}");


            //Завдання 2
            //#8

            //Console.WriteLine("Enter x = ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //const double b = 2.2;
            //const double c = 3.7;

            //double y = (7 * (Math.Pow(Math.E, (Math.Sqrt(Math.Abs(x)))))) + (Math.Pow(Math.Cos(x), 4));
            //double a = Math.Sin(b);
            //x = a + Math.Pow((b + c), 3);

            //Console.WriteLine($"y = {y}\n a = {a}\n x = {x}");

            //Завдання 3
            //#8

            ////A
            //int x1 = 1;
            //int y1 = 2;
            //bool A = (x1 >= 0) && (y1 * 2 != 4);
            //Console.WriteLine($"A ={A}");

            ////B
            //int x2 = 2;
            //int y2 = 1;
            //bool B = (x2 * y2 != 0) || (y2 > x2);
            //Console.WriteLine($"B = {B}");
        }
    }
}

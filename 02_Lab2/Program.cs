using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /////1
            //Console.WriteLine("ПРИВІТ! Вивчаємо мову C#!");
            //Console.Read();

            //            /////2
            //            Console.WriteLine(@"Це буквальний літерал, а це -
            //"" "" - подвійні лапки у ньому;
            //' ' - одинарні лапки у ньому");
            //            Console.Read();

            /////3
            //double f = 1.5F;
            //char c; 
            //int i = 0;
            //bool b = false;
            //decimal d = 1.5555555555555555555555555M;
            //double x = Math.Sin(Math.PI / 3);
            //c = 'A'; 
            //Console.WriteLine("f = {0} i = {1} x = {2} d = {3} c={4}", f, i, x, d, c);
            //Console.WriteLine(b.ToString());
            //Console.Read();

            ////4  
            //int i = 3;
            //double y = 4.12;
            //decimal d = 600m;
            //string s = "Вася";
            //Console.WriteLine("i = " + i); 
            //Console.WriteLine("y = {0} \n d = {1}", y, d);
            //Console.WriteLine("s = " + s);
            //Console.Read();

            /////5
            // ---------------------------------------------
            Console.WriteLine("Введіть рядок");
            string s = Console.ReadLine();
            Console.WriteLine("s = " + s);
            // ---------------------------------------------
            Console.WriteLine("Введіть символ");
            char c = (char)Console.Read();
            Console.ReadLine();
            Console.WriteLine("c = " + c);
            // ---------------------------------------------
            string buf;
            Console.WriteLine("Введіть ціле число");
            buf = Console.ReadLine();
            int i = Convert.ToInt32(buf);
            Console.WriteLine(i);
            // ---------------------------------------------
            Console.WriteLine("Введіть дійсне число");
            buf = Console.ReadLine();
            double x = Convert.ToDouble(buf);
            Console.WriteLine(x);
            // ---------------------------------------------
            Console.WriteLine("Введіть дійсне число");
            buf = Console.ReadLine();
            double y = double.Parse(buf);
            Console.WriteLine(y);
            // ---------------------------------------------
            Console.WriteLine("Введіть дійсне число");
            buf = Console.ReadLine();
            decimal z = decimal.Parse(buf);
            Console.WriteLine(z);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\tДуми мої, думи мої,\n\n\tЛихо мені з вами!\n\n\tНащо стали на папері\n\n\tСумними рядами?..\n\n\tЧом вас вітер не розвіяв\n\n\tВ степу, як пилину?\n\n\tЧом вас лихо не приспало\n\n");

            //Console.Write("Enter your name :  ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your surname :  ");
            //string surname = Console.ReadLine();
            //Console.Write("Enter your age :  ");
            //string age = Console.ReadLine();
            //Console.WriteLine(name + " " + surname + ", " + age + " years old");

            int d1, d2, sum;

            Console.WriteLine("Enter firs number : ");
            d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            d2 = Convert.ToInt32(Console.ReadLine());
            sum = d1 + d2;
      
            Console.WriteLine($"{d1} + {d2} = {sum}");

            Console.ReadKey();
        }
    }
}

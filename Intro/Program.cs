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

            Console.Write("Enter your name :  ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Your name is " + fullName);
            
            Console.ReadKey();
        }
    }
}

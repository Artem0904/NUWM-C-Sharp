using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Lab1
{
    public class Task3
    {
        public static void Run()
        {
            //Завдання 3
            string str;
            Console.WriteLine("Введіть рядок :");
            str = Console.ReadLine();
            if (str != null && str != String.Empty)
            {
                string toReplace = " ";
                string str1 = "  ";
                str = str.Replace(toReplace, str1);
                Console.WriteLine($"Результат: {str}");
            }
            else
                Console.WriteLine("Ви нічого не ввели!");
            Console.ReadLine();
        }
    }
}

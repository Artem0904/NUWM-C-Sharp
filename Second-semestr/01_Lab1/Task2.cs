using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Lab1
{
    public class Task2
    {
        public static void Run()
        {
            //Завдання 2
            string str;
            Console.WriteLine("Введіть рядок :");
            str = Console.ReadLine();
            int countNumbers = 0;
            if (str != null && str != String.Empty)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsNumber(str[i]))
                        countNumbers++;
                }
                Console.WriteLine($"Кількість цифр в вашому рядку = {countNumbers}");
            }
            else
                Console.WriteLine("Ви нічого не ввели!");
        }
    }
}

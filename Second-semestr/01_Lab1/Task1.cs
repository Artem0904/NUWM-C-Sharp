using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Lab1
{
    public class Task1
    {
        public static char[,] CreateAndFill(int n, int m)
        {
            char[,] cArr = new char[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    cArr[i, j] = Convert.ToChar(Console.ReadLine());
            return cArr;
        }
        public static void PrintCharMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0}   ", matrix[i, j]);
                Console.WriteLine("\n");
            }
        }
        public static void Run()
        {
            //Завдання 1
            const int n = 2;
            const int m = 6;
            Console.WriteLine($"Введіть символи {n}*{m} :");
            var cArr = CreateAndFill(n, m);
            Console.WriteLine("Масив символів :");
            PrintCharMatrix(cArr);

            int countPluses = 0, countMinuses = 0, countStars = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (cArr[i, j] == '+')
                        countPluses++;
                    else if (cArr[i, j] == '-')
                        countMinuses++;
                    else if (cArr[i, j] == '*')
                        countStars++;
                }
            }

            Console.WriteLine($"Кількість плюсів = {countPluses}\nКільскість мінусів = {countMinuses}\nКільскість зірочок = {countStars}\n");
        }
    }
}

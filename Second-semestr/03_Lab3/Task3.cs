using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Lab3
{
    public class Task3
    {
        static bool IsSquareOfOdd(int number)
        {
            int root = (int)Math.Sqrt(number);
            return root * root == number && root % 2 == 1;
        }
        public static void Run()
        {
            string inputFile = "C:\\Users\\artem\\Desktop\\numbers.txt";
            string outputFile = "C:\\Users\\artem\\Desktop\\numbers_result.txt";

            if (!File.Exists(inputFile))
            {
                FileStream fs = new FileStream(outputFile, FileMode.Create);
            }

            string[] lines = File.ReadAllLines(inputFile);

            int count = 0;

            foreach (string line in lines)
            {
                string[] numbers = line.Split(' ');

                foreach (string num in numbers)
                {
                    if (int.TryParse(num, out int value))
                    {
                        if (IsSquareOfOdd(value))
                        {
                            count++;
                        }
                    }
                }
            }

            // Запис результату у вихідний файл
            File.WriteAllText(outputFile, $"Кількість квадратів непарних чисел: {count}");

            Console.WriteLine("Результат записано файлі");


        }
    }
}

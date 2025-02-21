using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Lab3
{
    public class Task1
    {
        public static void PrintArray(int[] nums)
        {
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public static void Run()
        {
            string inputFile = "C:\\Users\\artem\\Desktop\\input.txt";

            if (!File.Exists(inputFile))
            {
                Console.WriteLine("Файл не знайдено!");
                return;
            }

            string[] lines = File.ReadAllLines(inputFile);

            int count = int.Parse(lines[0]); // зчитуємо кількість елементів
            Console.WriteLine($"Кількість елементів: {count}");

            string[] numberStrings = lines[1].Split(); // розбиваємо рядок на частини
            if (numberStrings.Length < count)
            {
                Console.WriteLine("Кількість елементів не відповідає заданій!");
                return;
            }
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(numberStrings[i]);
            }
            Console.Write("Елементи: ");
            PrintArray(numbers);


            double avg = Math.Round(numbers.Average(), 2);
            int min = numbers.Min();

            Console.WriteLine($"\nСереднє: {avg}");
            Console.WriteLine($"Мінімальне: {min}\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > avg)
                {
                    numbers[i] += min;
                }
            }
            Console.Write("Результат: ");
            PrintArray(numbers);

            File.WriteAllLines(inputFile, new string[] { count.ToString(), string.Join(" ", numbers) });
            Console.WriteLine("Результат записаний в файл");
        }
    }
}

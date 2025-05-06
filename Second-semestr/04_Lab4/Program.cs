using System;
using System.Text;

namespace _03_Lab3
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть кількість елементів у векторі: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Виділення пам’яті під масив дійсних чисел
            double* x = stackalloc double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"x[{i}] = ");
                *(x + i) = Convert.ToDouble(Console.ReadLine());
            }

            double max = *x; 
            for (int i = 2; i < n; i += 2)
            {
                if (*(x + i) > max)
                    max = *(x + i);
            }

            Console.WriteLine($"\nМаксимальний елемент серед парних індексів: {max}");
            Console.ReadLine();
        }
    }
}

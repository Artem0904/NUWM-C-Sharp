using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Lab10
{
    internal class Program
    {
        static void FillArray(double[] Arr)
        {
            for (int i = 0; i < Arr.Length; ++i)
            {
                if (i == 0)
                    Arr[i] = 0;
                else if (i > 0 && i <= 4)
                    Arr[i] = 7;
                else
                    Arr[i] = Math.Round((((Arr[i-1] + 4 * Arr[i-2] + Arr[i - 2] + Arr[i - 3])/Math.Sqrt(Arr[i - 4])) + Arr[i - 4]), 2);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Вкажіть номер елементу, який ви хочете отримати: ");
            int n = int.Parse(Console.ReadLine());
            double[] Arr = new double[n];

            FillArray(Arr);
            Console.WriteLine("\nЕлемент під номером {0} = {1}", n, Arr[n - 1]);
        }
    }
}

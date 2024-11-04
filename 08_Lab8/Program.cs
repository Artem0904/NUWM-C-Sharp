using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ////4.2.1
            //int[,] Arr = { { 1, 2, 3, 4 }, { 4, 3, 2, 1 }, { 4, 5, 6, 7 } };
            //Console.WriteLine("Початковий масив :");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0}    ", Arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (i % 2 == 0 && j % 2 == 0)
            //        {
            //            Arr[i, j] = 1;
            //            for (int k = 1; k <= j; k++) Arr[i, j] *= k;
            //        }
            //        else
            //        {
            //            Arr[i, j] = 0;
            //            for (int k = 1; k <= i; k++) Arr[i, j] += k;
            //        }
            //    }
            //}
            //Console.WriteLine("Оновлений масив :");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0}    ", Arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Random r = new Random(1);
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Arr[i, j] = r.Next(100);
            //    }
            //}
            //Console.WriteLine("Масив з рандомними значеннями :");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0}    ", Arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            ////4.2.2
            //int n;
            //Console.Write("Введіть кількість елементів n: ");
            //do
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n > 0)
            //        break;
            //    Console.WriteLine("n має бути > 0");
            //} while (n < 1);

            //int[,] Arr = new int[n, n];
            //Random r = new Random(1);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Arr[i, j] = r.Next(100) - r.Next(100);
            //    }
            //}

            //Console.WriteLine("Масив Arr:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0}    ", Arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int Sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i; j < n; j++)
            //    {
            //        if (i < j && Arr[i, j] > 0)
            //        {
            //            Sum += Arr[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine("Сума додатних елементів вище головної діагоналі: {0}", Sum);
            //Console.ReadLine();

            //4.2.3
            //int n = 7;
            //int[,] Arr = new int[n, n];
            //Random r = new Random(1);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Arr[i, j] = r.Next(100) - r.Next(100);
            //    }
            //}

            //Console.WriteLine("Початковий масив:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("{0}\t", Arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] Tmp = new int[7];
            //for (int i = 0; i < n; i++)
            //{
            //    Tmp[i] = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        Tmp[i] += Arr[i, j];
            //    }
            //}

            //Console.WriteLine("\nСума елементів у кожному рядку:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("{0}    ", Tmp[i]);
            //}

            //int Max = Tmp[0];
            //int NMax = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    if (Max < Tmp[i])
            //    {
            //        Max = Tmp[i];
            //        NMax = i;
            //    }
            //}
            //Console.WriteLine("\nРядок з максимальною сумою: {0} зі значенням {1}", NMax, Max);
            //Console.WriteLine("Елементи цього рядка:");
            //for (int j = 0; j < n; j++)
            //{
            //    Console.Write("{0}    ", Arr[NMax, j]);
            //}
            //Console.ReadLine();
        }
    }
}

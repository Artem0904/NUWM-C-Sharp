﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string buf;
            Console.OutputEncoding = Encoding.UTF8;

            ////////////////////////
            //Console.WriteLine("Введіть значення A=");
            //buf = Console.ReadLine();
            //double A = Convert.ToDouble(buf);

            //Console.WriteLine("Введіть значення N=");
            //int N;
            //do
            //{
            //    buf = Console.ReadLine();
            //    N = Convert.ToInt32(buf);
            //    if (N > 0)
            //        break;
            //    Console.WriteLine("N має бути > 0");

            //} while (N < 1);

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine("N={0} {1}", i, A * A - i * i);
            //}

            //Console.Read();

            //////////////////////
            //Console.WriteLine("Введіть значення x=");
            //buf = Console.ReadLine();
            //double x = Convert.ToDouble(buf);
            //double x1 = x * x * x;

            //Console.WriteLine("Введіть значення eps=");
            //buf = Console.ReadLine();
            //double eps = Convert.ToDouble(buf);

            //double s = 0;      
            //int i = 1;         
            //double Curr;       

            //do
            //{
            //    Curr = Math.Sin((2 * i - 1) * x);

            //    s += Curr;
            //    i++;
            //    x *= x1;

            //} while (Math.Abs(Curr) > eps);  

            //Console.WriteLine("i={0} S={1:f7}", i, s);
            //Console.Read();


            //////////////////////
            //Console.Write("Введіть число A (більше 1): ");
            //double A = Convert.ToDouble(Console.ReadLine());

            //double sum = 0.0;
            //int n = 0;

            //for (n = 1; sum <= A; n++)
            //{
            //    sum += 1.0 / n;
            //}

            //Console.WriteLine("Найменше n: " + (n - 1));
            //Console.WriteLine("Сума: " + sum);



            /////////////////
            //double sum = 0.0, x;

            //Console.Write("Введіть значення x: ");
            //x = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введіть похибку eps: ");
            //double eps = Convert.ToDouble(Console.ReadLine());

            //double term;
            //int i = 1;

            //do
            //{
            //    term = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
            //    sum += term;
            //    i++;
            //} while (Math.Abs(term) > eps);

            //Console.WriteLine("Сума ряду з точністю eps: " + sum);


            ///////////////Home TAsk
            int n;
            Console.Write("Введіть кількість чисел: ");
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                    break;
                Console.WriteLine("n має бути > 0");
            } while (n < 1);

            int countPositive = 0;
            int countEven = 0;
            int? max = null;
            int? min = null;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть число {i + 1}: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                    countPositive++;
                if (number % 2 == 0)
                    countEven++;

                if (max == null || number > max)
                    max = number;
                if (min == null || number < min)
                    min = number;
            }

            Console.WriteLine($"\nКількість позитивних чисел: {countPositive}");
            Console.WriteLine($"Кількість парних чисел: {countEven}");
            Console.WriteLine($"Максимальне число: {max}");
            Console.WriteLine($"Мінімальне число: {min}");
        }
    }
}

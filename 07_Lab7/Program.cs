using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /////////////№1 

            //int n;
            //Console.Write("Введіть кількість елементів n: ");
            //do
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n > 0)
            //        break;
            //    Console.WriteLine("n має бути > 0");
            //} while (n < 1);

            //Console.Write("Введіть значення x: ");
            //double x = double.Parse(Console.ReadLine());

            //double[] nums = new double[n];

            //for (int i = 1; i <= n; i++)
            //{
            //    nums[i - 1] = Math.Sin(x) * Math.Cos(x) - Math.Sin(2*x) * Math.Cos(1*2) * x + Math.Pow(-1, i + 1) * Math.Sin(i * x) * Math.Cos(i * x);
            //}

            //Console.WriteLine("Масив nums:");
            //int minIndex = 0;
            //double? min = null;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"nums[{i}] = {nums[i]}");
            //    if (min == null || nums[i] < min)
            //    {
            //        min = nums[i]; 
            //        minIndex = i;
            //    }
            //}

            //Console.WriteLine($"Порядковий номер найменшого елемента масиву nums: {minIndex}");



            ///////////№2

            //int n;
            //Console.Write("Введіть кількість елементів n : ");
            //do
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n > 0)
            //        break;
            //    Console.Write("n має бути > 0 : ");
            //} while (n < 1);

            //double[] a = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Введіть елемент a[{i}] : ");
            //    a[i] = double.Parse(Console.ReadLine());
            //}

            //double res = 1;
            //bool hasNegative = false;

            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        res *= a[i];
            //        hasNegative = true;
            //    }
            //}

            //if (hasNegative)
            //    Console.WriteLine($"Добуток від'ємних елементів вектора: {res}");

            //else
            //    Console.WriteLine("У векторі немає від'ємних елементів");


            ///////#3

            //int n;
            //Console.Write("Введіть кількість елементів для векеторів : ");
            //do
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n > 0)
            //        break;
            //    Console.Write("n має бути > 0 : ");
            //} while (n < 1);

            //double[] a = new double[n];
            //double[] b = new double[n];
            //double[] c = new double[n];

            //Console.WriteLine("Введіть елементи вектора a:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"a[{i}] = ");
            //    a[i] = double.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Введіть елементи вектора b:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"b[{i}] = ");
            //    b[i] = double.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Введіть елементи вектора c:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"c[{i}] = ");
            //    c[i] = double.Parse(Console.ReadLine());
            //}

            //double resAB = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    resAB += a[i] * b[i];
            //}

            //double resAC = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    resAC += a[i] * c[i];
            //}

            //double s = 2 * resAB - 3 * resAC;

            //Console.WriteLine($"Значення виразу s: {s}");


            ////////////////4
            ///
            int n;
            Console.Write("Введіть кількість елементів у масиві: ");
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                    break;
                Console.Write("n має бути > 0: ");
            } while (n < 1);

            int[] array = new int[n];

            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ел[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] != 0)
                {
                    array[index++] = array[i];
                }
            }

            while (index < n)
            {
                array[index++] = 0;
            }

            Console.WriteLine("Результат:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

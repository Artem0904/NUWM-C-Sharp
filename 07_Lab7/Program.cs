using System;
using System.Text;

namespace _07_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /////////////1 

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
            
            //int n;
            //Console.Write("Введіть кількість елементів у масиві: ");
            //do
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n > 0)
            //        break;
            //    Console.Write("n має бути > 0: ");
            //} while (n < 1);  

            //int[] array = new int[n]; 

            //Console.WriteLine("Введіть елементи масиву:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Ел[{i}] = ");
            //    array[i] = int.Parse(Console.ReadLine());
            //} 

            //int index = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (array[i] != 0)
            //    {
            //        array[index++] = array[i];
            //    }
            //} 

            //while (index < n)
            //{
            //    array[index++] = 0;
            //} 

            //Console.WriteLine("Результат:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(array[i] + " ");
            //} 

            //Console.WriteLine();
            //Console.ReadKey();



            /////Приклад 3.2.1
            
            //string buf;
            //int Size;
            //Console.Write("Введіть розмір масиву: ");
            //buf = Console.ReadLine();
            //Size = Convert.ToInt32(buf);

            //double[] Arr1 = new double[Size];

            //double x, y;
            //Console.Write("Введіть x = ");
            //buf = Console.ReadLine();
            //x = Convert.ToDouble(buf);
            //Console.Write("Введіть y = ");
            //buf = Console.ReadLine();
            //y = Convert.ToDouble(buf);

            //Arr1[0] = Arr1[1] = x;
            //Arr1[2] = y;

            //for (int i = 3; i < Arr1.Length; i++) {
            //    Arr1[i] = Arr1[i - 2] + Arr1[i - 1] * Arr1[i - 3] / Math.Pow(2, i - 1);
            //}

            //Console.WriteLine("Значення елементів масиву:");
            //for (int i = 0; i < Size; i++)
            //    Console.WriteLine("Arr1[{0}] = {1}", i + 1, Arr1[i]);

            //double z;
            //Console.Write("Введіть z = ");
            //buf = Console.ReadLine();
            //z = Convert.ToDouble(buf);

            //int kil = 0;
            //for (int i = 0; i < Arr1.Length; i++) {
            //    if (Arr1[i] > z) kil++;
            //}
            //Console.WriteLine("\nКількість елементів, більших за {0}: {1}", z, kil);
            //Console.ReadLine();




	    ////Приклад 3.2.2

            //const int n = 7;
            //int[] A = new int[n];
            //int i;
            //int sum = 0;

            //Console.WriteLine("Введіть елементи масиву A:");
            //for (i = 0; i < A.Length; i++) {
            //    Console.Write("A[{0}] = ", i + 1);
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Введений масив:");
            //foreach (int k in A)
            //    Console.Write("{0} ", k);
            //Console.WriteLine();

            //i = 0;
            //while (i < n && A[i] >= 0) {
            //    sum += A[i];
            //    i++;
            //}
            //Console.WriteLine("\nСума додатних елементів = " + sum);
            //Console.ReadLine();	




	    ////Приклад 3.2.3

	    //const int n = 7;
            //double[] A = new double[n];
            //double[] B = new double[n];
            //int i;
            //double s = 0;

            //Console.WriteLine("Введіть елементи масиву A:");
            //for (i = 0; i < A.Length; i++) {
            //    Console.Write("A[{0}] = ", i + 1);
            //    A[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //Console.WriteLine("Введіть елементи масиву B:");
            //for (i = 0; i < B.Length; i++) {
            //    Console.Write("B[{0}] = ", i + 1);
            //    B[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //Console.WriteLine("Виведення значеннь масиву A:");
            //foreach(int k in A)
            //{
            //    Console.Write("{0}     ", k);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Виведення значеннь масиву В");
            //foreach(int k in B)
            //{
            //    Console.Write("{0}     ", k);
            //}
            //Console.WriteLine();

            //for (i = 0; i < A.Length; i++)
            //    s += (A[i] + B[i]) * (A[i] - B[i]);
            //s *= 2;

            //Console.WriteLine("\nРезультат обчислення s = " + s);
            //Console.ReadLine();



 	        ////Приклад 3.2.4

            //const int n = 7;
            //double[] A = new double[n];
            //Random rnd = new Random();

            //for (int i = 0; i < A.Length; i++) {
            //   A[i] = 2 * rnd.NextDouble() - 1;
            //}
            //Console.WriteLine("Масив A до сортування:");
            //foreach (double k in A)
            //    Console.Write("{0:f3} ", k);
            
            //Array.Sort(A);
            //Console.WriteLine("\nМасив A після сортування:");
            //foreach (double k in A)
            //    Console.Write("{0:f3} ", k);

            //Array.Reverse(A);
            //Console.WriteLine("\nМасив A у зворотному порядку:");
            //foreach (double k in A)
            //    Console.Write("{0:f3} ", k);
            //Console.ReadLine();
        }
    }
}

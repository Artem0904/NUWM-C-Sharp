using System;
using System.Text;

namespace _05_Lab5
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("Введіть значення m:");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введіть значення n:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //int current = m;

            //do
            //{
            //    sum += current * current;
            //    current++;
            //} while (current <= n);

            //Console.WriteLine("Сума квадратів чисел від {0} до {1} дорівнює {2}", m, n, sum);
            //Console.ReadLine();





            ///////Приклад 4.2.1
            //int[,] Arr = {{1,2,3,4},{4,3,2,1},{4,5,6,7}};
            //Console.WriteLine("Масив Arr з початковими значеннями:");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)  
            //    {   
            //        Console.Write("{0}    ", Arr[i,j]);
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
            //Console.WriteLine("Модифікований масив Arr:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)  
            //    { 
            //        Console.Write("{0}    ", Arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //// Заповнення масиву випадковими значеннями
            //Random r = new Random(1);  
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)  
            //    { 
            //       Arr[i, j] = r.Next(100); 
            //    }
            //}
            //Console.WriteLine("Масив Arr з випадковими значеннями:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)  
            //    { 
            //        Console.Write("{0}    ", Arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();





            ///////Приклад 4.2.1


            //int n; // розмірність масиву
            //Console.WriteLine("Введіть розмірність масиву n:");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[,]  Arr = new int[n,n];  
            //Random r = new Random(1);  
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)  
            //    { 
            //        Arr[i, j] = r.Next(100)- r.Next(100);
            //    }
            //}
            //Console.WriteLine("Масив Arr:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)  
            //    {   
            //        Console.Write("{0}    ", Arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            //int Sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i; j < n; j++)  
            //    { 
            //        if (i < j && Arr[i,j]>0)
            //        { 
            //            Sum += Arr[i, j];   
            //        }
            //    }
            //}
            //Console.WriteLine("Сума додатних елементів вище головної діагоналі: {0}", Sum);
            //Console.ReadLine();




            ///////Приклад 4.2.3



            //int n=7; // розмірність масиву
            //int[,]  Arr = new int[n,n];  
            //Random r = new Random(1);  
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)  
            //    { 
            //        Arr[i, j] = r.Next(100)- r.Next(100);
            //    }
            //}
            //Console.WriteLine("Масив Arr:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)  
            //    {   
            //        Console.Write("{0}\t", Arr[i,j]);
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
            //Console.WriteLine();
            //Console.WriteLine("Рядок з максимальною сумою: {0} зі значенням {1}", Max, NMax);
            //Console.WriteLine("Елементи цього рядка:");
            //for (int j = 0; j < n;j++) 
            //{ 
            //    Console.Write("{0}    ", Arr[NMax, j]);
            //}
            //Console.ReadLine();




            ///////Завдання 1 11


            //int N;
            //Console.WriteLine("Введіть розмірність матриці N:");
            //N = Convert.ToInt32(Console.ReadLine());

            //int[,] A = new int[N, N];

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        A[i, j] = (int)Math.Pow(i, j) - (int)Math.Pow(j, i);
            //    }
            //}

            //Console.WriteLine("Матриця A:");
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        Console.Write("{0}\t", A[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int positiveSum = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (A[i, j] > 0)
            //        {
            //            positiveSum += A[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine("Сума додатних елементів матриці A: {0}", positiveSum);
            //Console.ReadLine();






            ///2   11

            //int n, m;

            //Console.WriteLine("Введіть кількість рядків n:");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введіть кількість стовпців m:");
            //m = Convert.ToInt32(Console.ReadLine());

            //int[,] array = new int[n, m];
            //Random rand = new Random();

            //Console.WriteLine("Двовимірний масив:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        array[i, j] = rand.Next(1, 101); // Випадкові числа від 1 до 100
            //        Console.Write(array[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int evenCount = 0;
            //int oddCount = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (array[i, j] % 2 == 0)
            //        {
            //            evenCount++;
            //        }
            //        else
            //        {
            //            oddCount++;
            //        }
            //    }
            //}

            //Console.WriteLine("Кількість парних чисел: " + evenCount);
            //Console.WriteLine("Кількість непарних чисел: " + oddCount);
            //Console.ReadLine();








            //3 11

            //int rows = 7;
            //int cols = 3;
            //int[,] matrix = new int[rows, cols];
            //Random rand = new Random();

            //Console.WriteLine("Матриця 7x3:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        matrix[i, j] = rand.Next(1, 101);
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int j = 0; j < cols; j++)
            //{
            //    int count = 0;
            //    for (int i = 0; i < rows; i++)
            //    {
            //        if (matrix[i, j] % 3 == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine("Кількість елементів у стовпці {0}, які кратні 3: {1}", j + 1, count);
            //}

            //Console.ReadLine();
        }
    }
}

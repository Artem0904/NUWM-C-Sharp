using System.Diagnostics;
using System.Text;

namespace _00_SortMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть кількість елементів: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть ліву межу: ");
            int left = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть праву межу: ");
            int right = Convert.ToInt32(Console.ReadLine());

            int[] originalArray = GenerateRandomArray(size, left, right);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nОригінальний масив:");
            Console.ForegroundColor = ConsoleColor.White;

            PrintArray(originalArray);

            int[] array = originalArray;

            var watch = Stopwatch.StartNew();

            //BubbleSort(ref array);
            //SelectionSort(ref array);
            InsertionSort(ref array);

            watch.Stop(); 

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nВідсортований масив: ");
            Console.ForegroundColor = ConsoleColor.White;

            PrintArray(array);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\nЧас сортування: {watch.ElapsedMilliseconds} мс");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }

        static int[] GenerateRandomArray(int size, int left, int right)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = rand.Next(left, right);
            return array;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        static void BubbleSort(ref int[] array)
        {
            Console.WriteLine("\n--- Сортування бульбашкою ---");
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Після проходу " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.White;

                PrintArray(array);
            }
        }

        static void SelectionSort(ref int[] array)
        {
            Console.WriteLine("\n--- Сортування вибором ---");
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Після проходу " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.White;

                PrintArray(array);
            }
        }

        static void InsertionSort(ref int[] array)
        {
            Console.WriteLine("\n--- Сортування вставками ---");
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Після проходу " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                PrintArray(array);
            }
        }
    }
}

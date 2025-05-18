using System.Diagnostics;
using System.Text;

namespace _7_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int left = -10000;
            int right = 10000;
            Console.Write("Введіть кількість елементів: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = GenerateRandomArray(size, left, right);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nОригінальний масив:");
            Console.ForegroundColor = ConsoleColor.White;
           // PrintArray(array);
            
            var watch = Stopwatch.StartNew();

            //int[] sortedArray = InsertionSort(array);
            int[] sortedArray = QuickSort(array);

            watch.Stop();
            long sortingTime = watch.ElapsedMilliseconds;

            if (watch.ElapsedMilliseconds == 0)
            {
                const int countIterations = 10000;
                long sum = 0;
                for (int i = 0; i < countIterations; i++)
                {
                    watch.Restart();
                    //InsertionSort(array);
                    QuickSort(array);
                    watch.Stop();
                    //Console.WriteLine($"\n\nЧас сортування: {watch.ElapsedMilliseconds} мс");
                    sum += watch.ElapsedMilliseconds;
                }
                sortingTime = sum / countIterations;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nВідсортований масив: ");
            Console.ForegroundColor = ConsoleColor.White;
            PrintArray(sortedArray);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\nЧас сортування: {sortingTime} мс");
            Console.WriteLine("Кількість порівняннь : " + compareCount);
            Console.WriteLine("Кількість обмінів : " + moveCount);
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
        static int compareCount = 0;
        static int moveCount = 0;
        static int[] InsertionSort(int[] array)
        {
            compareCount = 0;
            moveCount = 0;
            int[] resultArr = (int[])array.Clone();
            int n = resultArr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = resultArr[i];
                int j = i - 1;

                while (j >= 0 && resultArr[j] > key)
                {
                    resultArr[j + 1] = resultArr[j];
                    compareCount++;
                    j--;
                }
                resultArr[j + 1] = key;
                moveCount++;

                //Console.ForegroundColor = ConsoleColor.Blue;
                //Console.Write("Після проходу " + (i + 1) + ": ");
                //Console.ForegroundColor = ConsoleColor.White;
                //PrintArray(resultArr);
            }
            return resultArr;
        }

        static int[] QuickSort(int[] array)
        {
            compareCount = 0;
            moveCount = 0;
            int[] result = (int[])array.Clone();
            QuickSortRecursive(result, 0, result.Length - 1);
            return result;
        }

        static void QuickSortRecursive(int[] array, int low, int high)
        {

            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortRecursive(array, low, pivotIndex - 1);
                QuickSortRecursive(array, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                compareCount++;
                if (array[j] < pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                    moveCount++;
                }
            }

            (array[i + 1], array[high]) = (array[high], array[i + 1]);
            moveCount++;
            return i + 1;
        }


    }
}

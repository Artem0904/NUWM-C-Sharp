using System.Text;

namespace _01_Lab1
{
    internal class Program
    {
        public static char[,] CreateAndFill(int n, int m)
        {
            char[,] cArr = new char[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    cArr[i, j] = Convert.ToChar(Console.ReadLine());
            return cArr;
        }
        public static void PrintCharMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0}   ", matrix[i, j]);
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ////Завдання 1
            //const int n = 2;
            //const int m = 6;
            //Console.WriteLine($"Введіть символи {n}*{m} :");
            //var cArr = CreateAndFill(n, m);
            //Console.WriteLine("Масив символів :");
            //PrintCharMatrix(cArr);

            //int countPluses = 0, countMinuses = 0, countStars = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (cArr[i, j] == '+')
            //            countPluses++;
            //        else if(cArr[i, j] == '-')
            //            countMinuses++;
            //        else if (cArr[i,j] == '*')
            //            countStars++;
            //    }
            //}

            //Console.WriteLine($"Кількість плюсів = {countPluses}\nКільскість мінусів = {countMinuses}\nКільскість зірочок = {countStars}\n");

            ////Завдання 2
            //string str;
            //Console.WriteLine("Введіть рядок :");
            //str = Console.ReadLine();
            //int countNumbers = 0;
            //if(str != null &&  str != String.Empty)
            //{
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (Char.IsNumber(str[i]))
            //            countNumbers++;
            //    }
            //    Console.WriteLine($"Кількість цифр в вашому рядку = {countNumbers}");
            //}
            //else
            //    Console.WriteLine("Ви нічого не ввели!");

            //Завдання 3
            string str;
            Console.WriteLine("Введіть рядок :");
            str = Console.ReadLine();
            if(str != null &&  str != String.Empty)
            {
                string toReplace = " ";
                string str1 = "  ";
                str = str.Replace(toReplace, str1);
                Console.WriteLine($"Результат: {str}");
            }
            else
                Console.WriteLine("Ви нічого не ввели!");
            Console.ReadLine();
        }
    }
}

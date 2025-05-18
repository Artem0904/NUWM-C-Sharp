using System.Text;

namespace _09_Lab9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--------- Line ---------");
            int key = 43;
            int[] ints = new int[] { 1, 8, 5, 7, 2, 1, 6, 4, 7, 3, 2, 0};
            Console.Write("Масив : ");
            PrintArray(ints);

            Console.WriteLine("Ключ : " + key);

            int resultLine = LinSearch(ints, key);

            if (resultLine != -1)
                Console.WriteLine($"Ключ знайдено на позиції: {resultLine}");
            else
                Console.WriteLine("Ключ не знайдено.");

            Console.WriteLine("\n\n--------- KMP ---------");
            string text = "abcabcabcdabcabcd";   // основний текст
            string pattern = "abcabcd";          // підрядок для пошуку

            Console.WriteLine("Весь текст : " + text);
            Console.WriteLine("Підрядок : " + pattern);

            int resultRMP = KMPSearch(text, pattern);

            if (resultRMP != -1)
                Console.WriteLine($"Підрядок знайдено на позиції: {resultRMP}");
            else
                Console.WriteLine("Підрядок не знайдено.");
        }
        static int LinSearch(int[] a, int key)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == key)
                    return i;
            return -1;
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
        static int KMPSearch(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            int[] prefix = new int[m];
            int len = 0;   
            prefix[0] = 0; 

            for (int i = 1; i < m; i++)
            {
                while (len > 0 && pattern[i] != pattern[len])
                    len = prefix[len - 1];

                if (pattern[i] == pattern[len])
                    len++;

                prefix[i] = len; 
            }

            int j = 0;

            for (int i = 0; i < n; i++) 
            {
                while (j > 0 && text[i] != pattern[j])
                    j = prefix[j - 1];

                if (text[i] == pattern[j])
                    j++;

                if (j == m)
                    return i - m + 1;
            }

            return -1;
        }
        //static int KMPSearch(string text, string pattern)
        //{
        //    int[] prefix = BuildPrefixFunction(pattern);
        //    int i = 0; // Для text
        //    int j = 0; // Для pattern

        //    while (i < text.Length)
        //    {
        //        if (text[i] == pattern[j])
        //        {
        //            i++;
        //            j++;
        //        }

        //        if (j == pattern.Length)
        //            return i - j; // Знайдено

        //        else if (i < text.Length && text[i] != pattern[j])
        //        {
        //            if (j != 0)
        //                j = prefix[j - 1];
        //            else
        //                i++;
        //        }
        //    }

        //    return -1; // Не знайдено
        //}

        //// Префікс-функція
        //static int[] BuildPrefixFunction(string pattern)
        //{
        //    int[] prefix = new int[pattern.Length];
        //    int length = 0;
        //    prefix[0] = 0;

        //    for (int i = 1; i < pattern.Length; i++)
        //    {
        //        while (length > 0 && pattern[i] != pattern[length])
        //            length = prefix[length - 1];

        //        if (pattern[i] == pattern[length])
        //            length++;

        //        prefix[i] = length;
        //    }

        //    return prefix;
        //}
    }
}

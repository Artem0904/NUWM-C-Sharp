using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Lab12
{
    public class Task1
    {
        public static void Run()
        {
            string inputPath = "input.txt";
            string outputPath = "output.txt";
            if (!File.Exists(inputPath)) {
                Console.WriteLine("Файл \"" + inputPath + "\" не знайдено!");
                return;
            }

            string[] lines = File.ReadAllLines(inputPath);
            string[] header = lines[0].Split();
            int n = int.Parse(header[0]);
            if(n <= 0) {
                Console.WriteLine("Кількість вершин не може дорівнювати " + n);
                return;
            }
            int m = int.Parse(header[1]);
            if (m <= 0) {
                Console.WriteLine("Кількість ребер не може дорівнювати " + n);
                return;
            }

            int[,] adjacencyMatrix = new int[n, n];
            int[,] incidenceMatrix = new int[n, m];

            for (int i = 0; i < m; i++)
            {
                string[] edge = lines[i + 1].Split();
                int from = int.Parse(edge[0]) - 1;
                int to = int.Parse(edge[1]) - 1;

                adjacencyMatrix[from, to] = 1;

                incidenceMatrix[from, i] = -1;
                incidenceMatrix[to, i] = 1;
            }

            PrintMatrix("Матриця суміжності:", adjacencyMatrix);
            PrintMatrix("Матриця інцидентності:", incidenceMatrix);

            Console.Write("Хочете записати результат в файл?\ny/n\n>");
            string key = Console.ReadLine();
            char successKey = 'y';

            if (char.ToLower(key[0]) == successKey) {
                using StreamWriter writer = new StreamWriter(outputPath);
                Console.WriteLine($"Результати записано у файл: {outputPath}");
                WriteMatrixInFile("Матриця суміжності:", adjacencyMatrix, writer);
                WriteMatrixInFile("Матриця інцидентності:", incidenceMatrix, writer);
            }

            void PrintMatrix(string title, int[,] matrix)
            {
                Console.WriteLine(title);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        Console.Write($"{matrix[i, j],3}");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            void WriteMatrixInFile(string title, int[,] matrix, StreamWriter writer)
            {
                writer.WriteLine(title);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        writer.Write($"{matrix[i, j],3},");
                    writer.WriteLine();
                }
                writer.WriteLine();
            }
        }
    }
}

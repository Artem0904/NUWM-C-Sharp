using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Lab12
{
    public class Task2
    {
        public static void Run()
        {
            Stack<int> stack = new Stack<int>();
            const int size = 7;
            int[,] mas = new int[size, size] { { 0,  0,  0,  0,  0,  1,  0 },
                                               { 1,  0,  1,  0,  0,  0,  1 },
                                               { 0,  0,  0,  1,  0,  0,  0 },
                                               { 0,  0,  0,  0,  1,  0,  0 },
                                               { 0,  0,  0,  0,  0,  0,  1 },
                                               { 0,  1,  0,  0,  1,  0,  1 },
                                               { 0,  0,  1,  0,  0,  0,  0 } };
            int[] nodes = new int[size];
            for (int i = 0; i < size; i++)
                nodes[i] = 0;
            stack.Push(0);
            while (stack.Count > 0)
            {
                int node = stack.Pop();
                if (nodes[node] == 2) continue;
                nodes[node] = 2;
                for (int j = size - 1; j >= 0; j--)
                { 
                    if (mas[node, j] == 1 && nodes[j] != 2)
                    {
                        stack.Push(j); 
                        nodes[j] = 1;
                    }
                }
                Console.WriteLine(node + 1); 
            }
            Console.ReadLine();

        }
    }
}

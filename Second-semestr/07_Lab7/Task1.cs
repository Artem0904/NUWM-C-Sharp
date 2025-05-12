using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Lab7
{
    public unsafe class Task1
    {
        class Node
        {
            public string Value;
            public Node Next;
        }

        class Stack
        {
            private Node top;

            public void Push(string value)
            {
                Node newNode = new Node();
                newNode.Value = value;
                newNode.Next = top;
                top = newNode;
            }

            public string Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("Стек порожній.");
                    return null;
                }

                string value = top.Value;
                top = top.Next;
                return value;
            }

            public void Print()
            {
                Console.WriteLine("Вміст стеку:");
                Node current = top;
                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
            }

            public int CountSingleCharStrings()
            {
                int count = 0;
                Node current = top;
                while (current != null)
                {
                    if (current.Value.Length == 1)
                        count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public static void Run()
        {
            Stack stack = new Stack();

            stack.Push("abc");
            stack.Push("de");
            stack.Push("f");
            stack.Push("g");
            stack.Push("hi");
            stack.Push("jk");

            stack.Print();

            Console.WriteLine("\nВидаляємо один елемент...");
            stack.Pop();

            stack.Print();

            int count = stack.CountSingleCharStrings();
            Console.WriteLine($"\nКількість односимвольних рядків у стеці: {count}");

            Console.ReadKey();
        }
    }
}

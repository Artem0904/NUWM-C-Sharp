using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Lab7
{
    public class Task2
    {
        class Node
        {
            public string Value;
            public Node Next;
        }

        class StringQueue
        {
            private Node head = null;
            private Node tail = null;

            // Додавання елемента в кінець черги
            public void Enqueue(string value)
            {
                Node newNode = new Node { Value = value, Next = null };
                if (tail != null)
                {
                    tail.Next = newNode;
                }
                else
                {
                    head = newNode;
                }
                tail = newNode;
            }

            // Видалення елемента з початку черги
            public string Dequeue()
            {
                if (head == null)
                {
                    Console.WriteLine("Черга порожня.");
                    return null;
                }

                string value = head.Value;
                head = head.Next;

                if (head == null)
                    tail = null;

                return value;
            }

            // Вивід вмісту черги
            public void PrintQueue()
            {
                Console.WriteLine("Вміст черги:");
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
            }

            // Сума довжин рядків
            public int TotalLength()
            {
                int sum = 0;
                Node current = head;
                while (current != null)
                {
                    sum += current.Value.Length;
                    current = current.Next;
                }
                return sum;
            }
        }

        public static void Run()
        {
            StringQueue queue = new StringQueue();

            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");

            queue.PrintQueue();

            Console.WriteLine("\nВидаляємо один елемент...");
            queue.Dequeue();

            queue.Enqueue("five");

            Console.WriteLine("\nОновлена черга:");
            queue.PrintQueue();

            int totalLength = queue.TotalLength();
            Console.WriteLine($"\nСумарна довжина рядків у черзі: {totalLength}");

            Console.ReadLine();
        }
    }
}

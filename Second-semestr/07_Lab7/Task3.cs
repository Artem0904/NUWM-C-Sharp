using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Lab7
{
    public class Task3
    {
        class Node
        {
            public int Value;
            public Node Next;
        }
        public static void Run()
        {
            Node P1 = new Node { Value = 3 };
            P1.Next = new Node { Value = 5 };
            P1.Next.Next = new Node { Value = 7 };
            P1.Next.Next.Next = new Node { Value = 4 };
            P1.Next.Next.Next.Next = new Node { Value = 9 };
            Node P2 = P1.Next.Next.Next.Next; 

            Node P3 = new Node { Value = 10 };
            P3.Next = new Node { Value = 12 };
            Node P4 = P3.Next;

            Console.WriteLine("=== Початкові черги ===");
            PrintQueue("Черга 1", P1);
            PrintQueue("Черга 2", P3);

            while (P1 != null && P1.Value % 2 != 0)
            {
                Node temp = P1;
                P1 = P1.Next;

                temp.Next = null;
                if (P4 != null)
                {
                    P4.Next = temp;
                    P4 = temp;
                }
                else
                {
                    P3 = P4 = temp;
                }

                if (P1 == null)
                {
                    P2 = null;
                }
            }

            Console.WriteLine("\n=== Після переміщення ===");
            PrintQueue("Черга 1", P1);
            PrintQueue("Черга 2", P3);

            Console.WriteLine("\n=== Нові адреси ===");
            Console.WriteLine("P1 (head 1): " + (P1 != null ? P1.GetHashCode().ToString() : "null"));
            Console.WriteLine("P2 (tail 1): " + (P2 != null ? P2.GetHashCode().ToString() : "null"));
            Console.WriteLine("P3 (head 2): " + (P3 != null ? P3.GetHashCode().ToString() : "null"));
            Console.WriteLine("P4 (tail 2): " + (P4 != null ? P4.GetHashCode().ToString() : "null"));

            Console.ReadLine();
        }

        static void PrintQueue(string name, Node head)
        {
            Console.WriteLine(name + ":");
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}

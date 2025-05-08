using System;
using System.Text;

namespace _03_Lab3
{
    unsafe class Program
    {
        public struct Single_List
        {
            public double Data;
            public Single_List* Next;
        }

        static void Main(string[] args)
        {
            Single_List* Head = null;
            Single_List* Last = null;

            Console.WriteLine("Введення списку (завершення — 0):");
            double val = double.Parse(Console.ReadLine());
            while (val != 0)
            {
                Single_List* node = stackalloc Single_List[1];
                node->Data = val;
                node->Next = null;

                if (Head == null)
                {
                    Head = Last = node;
                }
                else
                {
                    Last->Next = node;
                    Last = node;
                }

                val = double.Parse(Console.ReadLine());
            }

            // Пошук першого від’ємного елемента
            double? firstNegative = null;
            Single_List* tmp = Head;
            while (tmp != null)
            {
                if (tmp->Data < 0)
                {
                    firstNegative = tmp->Data;
                    break;
                }
                tmp = tmp->Next;
            }

            if (firstNegative == null)
            {
                Console.WriteLine("Немає негативних елементів. Список без змін:");
                PrintList(Head);
                return;
            }

            // Вставка перед усіма елементами зі значенням 20
            Single_List* prev = null;
            tmp = Head;
            while (tmp != null)
            {
                if (tmp->Data == 20)
                {
                    Single_List* newNode = stackalloc Single_List[1];
                    newNode->Data = (double)firstNegative;
                    newNode->Next = tmp;

                    if (prev == null)
                    {
                        Head = newNode;
                    }
                    else
                    {
                        prev->Next = newNode;
                    }

                    prev = newNode;
                }
                else
                {
                    prev = tmp;
                }

                tmp = tmp->Next;
            }

            Console.WriteLine("Оновлений список:");
            PrintList(Head);
            Console.ReadLine();
        }

        static void PrintList(Single_List* head)
        {
            Single_List* current = head;
            while (current != null)
            {
                Console.Write(current->Data + " -> ");
                current = current->Next;
            }
            Console.WriteLine("null");
        }
    }
}

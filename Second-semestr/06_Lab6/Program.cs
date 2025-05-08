//using System.Text;

//namespace _06_Lab6
//{
//    internal unsafe class Program
//    {
//        public struct DoubleList
//        {
//            public double Data;
//            public DoubleList* Next;
//            public DoubleList* Prev;
//        }

//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;

//            DoubleList* Head = null;
//            DoubleList* Last = null;

//            Console.WriteLine("Введіть 0, щоб завершити.\nВведіть елементи:");
//            Console.Write("> ");
//            double input = double.Parse(Console.ReadLine());

//            while (input != 0)
//            {
//                DoubleList* NewNode = stackalloc DoubleList[1];
//                NewNode->Data = input;
//                NewNode->Next = null;
//                NewNode->Prev = null;

//                if (Head == null)
//                {
//                    Head = Last = NewNode;
//                }
//                else
//                {
//                    NewNode->Prev = Last;
//                    Last->Next = NewNode;
//                    Last = NewNode;
//                }

//                Console.Write("> ");
//                input = double.Parse(Console.ReadLine());
//            }

//            if (Head == null)
//            {
//                Console.WriteLine("Список порожній.");
//                return;
//            }

//            double max = Head->Data;
//            DoubleList* Current = Head;
//            while (Current != null)
//            {
//                if (Current->Data > max)
//                    max = Current->Data;
//                Current = Current->Next;
//            }

//            Console.WriteLine("\nПочатковий список:");
//            Current = Head;
//            while (Current != null)
//            {
//                Console.Write($"{Current->Data} ");
//                Current = Current->Next;
//            }

//            Current = Last;
//            while (Current != null)
//            {
//                if (Current->Data == 1.0)
//                {
//                    DoubleList* MaxNode = stackalloc DoubleList[1];
//                    MaxNode->Data = max;

//                    DoubleList* prev = Current->Prev;

//                    MaxNode->Prev = prev;
//                    MaxNode->Next = Current;
//                    Current->Prev = MaxNode;

//                    if (prev != null)
//                        prev->Next = MaxNode;
//                    else
//                        Head = MaxNode;

//                    Current = MaxNode->Prev;
//                }
//                else
//                {
//                    Current = Current->Prev;
//                }
//            }


//            Console.WriteLine("\nРезультат:");
//            Current = Head;
//            while (Current != null)
//            {
//                Console.Write($"{Current->Data} ");
//                Current = Current->Next;
//            }

//            Console.ReadLine();
//        }
//    }
//}

using System;
using System.Text;

namespace CyclicDoublyLinkedList
{
    internal unsafe class Program
    {
        public struct DoubleList
        {
            public int Data;
            public DoubleList* Next;
            public DoubleList* Prev;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DoubleList* Head = null;
            DoubleList* Last = null;

            Console.WriteLine("Введіть 0, щоб завершити.\nВведіть елементи:");
            Console.Write("> ");
            int input = int.Parse(Console.ReadLine());

            while (input != 0)
            {
                DoubleList* NewNode = stackalloc DoubleList[1];
                NewNode->Data = input;
                NewNode->Next = null;
                NewNode->Prev = null;

                if (Head == null)
                {
                    Head = Last = NewNode;
                    Head->Next = Head;
                    Head->Prev = Head;
                }
                else
                {
                    NewNode->Prev = Last;
                    NewNode->Next = Head;
                    Last->Next = NewNode;
                    Head->Prev = NewNode;
                    Last = NewNode;
                }

                Console.Write("> ");
                input = int.Parse(Console.ReadLine());
            }

            if (Head == null)
            {
                Console.WriteLine("Список порожній.");
                return;
            }

            Console.WriteLine("\nПочатковий циклічний список:");
            PrintList(Head);

            DoubleList* Current = Head;
            do
            {
                if (Current->Data == 10)
                {
                    RemoveNode(ref Head, ref Last, Current);
                    break; 
                }
                Current = Current->Next;
            } while (Current != Head);

            Console.WriteLine("\nРезультат після видалення першого 10:");
            PrintList(Head);
        }

        static unsafe void PrintList(DoubleList* Head)
        {
            if (Head == null)
            {
                Console.WriteLine("Список порожній.");
                return;
            }

            DoubleList* Current = Head;
            do
            {
                Console.Write($"{Current->Data} ");
                Current = Current->Next;
            } while (Current != Head);
            Console.WriteLine();
        }

        static unsafe void RemoveNode(ref DoubleList* Head, ref DoubleList* Last, DoubleList* Node)
        {
            if (Node == null)
                return;

            if (Node->Next == Node)
            {
                Head = Last = null;
                return;
            }

            if (Node == Head)
                Head = Head->Next;

            if (Node == Last)
                Last = Last->Prev;

            Node->Prev->Next = Node->Next;
            Node->Next->Prev = Node->Prev;
        }
    }
}

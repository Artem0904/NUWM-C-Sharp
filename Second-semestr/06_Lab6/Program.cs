using System.Text;

namespace _06_Lab6
{
    internal unsafe class Program
    {
        public struct DoubleList
        {
            public double Data;
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
            double input = double.Parse(Console.ReadLine());

            while (input != 0)
            {
                DoubleList* NewNode = stackalloc DoubleList[1];
                NewNode->Data = input;
                NewNode->Next = null;
                NewNode->Prev = null;

                if (Head == null)
                {
                    Head = Last = NewNode;
                }
                else
                {
                    NewNode->Prev = Last;
                    Last->Next = NewNode;
                    Last = NewNode;
                }

                Console.Write("> ");
                input = double.Parse(Console.ReadLine());
            }

            if (Head == null)
            {
                Console.WriteLine("Список порожній.");
                return;
            }

            double max = Head->Data;
            DoubleList* Current = Head;
            while (Current != null)
            {
                if (Current->Data > max)
                    max = Current->Data;
                Current = Current->Next;
            }

            Console.WriteLine("\nПочатковий список:");
            Current = Head;
            while (Current != null)
            {
                Console.Write($"{Current->Data} ");
                Current = Current->Next;
            }

            Current = Head;
            while (Current != null)
            {
                if (Current->Data == 1.0)
                {
                    DoubleList* MaxNode = stackalloc DoubleList[1];
                    MaxNode->Data = max;

                    DoubleList* next = Current->Next; // ← зберігаємо посилання

                    MaxNode->Next = next;
                    MaxNode->Prev = Current;
                    Current->Next = MaxNode;

                    if (next != null)
                        next->Prev = MaxNode;
                    else
                        Last = MaxNode;

                    Current = MaxNode->Next; // ← переходимо далі правильно
                }
                else
                {
                    Current = Current->Next;
                }
            }


            Console.WriteLine("\nРезультат:");
            Current = Head;
            while (Current != null)
            {
                Console.Write($"{Current->Data} ");
                Current = Current->Next;
            }

            Console.ReadLine();
        }
    }
}

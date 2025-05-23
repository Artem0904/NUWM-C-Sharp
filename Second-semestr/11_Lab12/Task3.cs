namespace _11_Lab12
{
    public class Task3
    {
        const int SIZE = 6;

        static int[,] graph = new int[SIZE, SIZE]
        {
            // 0  1  2  3  4  5
            { 0, 1, 1, 0, 0, 0 }, // 0 залежить від 1 і 2
            { 0, 0, 0, 1, 0, 0 }, // 1 залежить від 3
            { 0, 0, 0, 1, 1, 0 }, // 2 залежить від 3 і 4
            { 0, 0, 0, 0, 0, 1 }, // 3 залежить від 5
            { 0, 0, 0, 0, 0, 1 }, // 4 залежить від 5
            { 0, 0, 0, 0, 0, 0 }  // 5 — базова деталь
        };

        static int[] time = new int[SIZE] { 2, 3, 4, 2, 1, 5 };

        static int[] calculatedTime = new int[SIZE];
        public static void Run()
        {

            int maxTime = 0;

            for (int i = 0; i < SIZE; i++)
            {
                int currentTime = Deep(i);
                if (currentTime > maxTime)
                    maxTime = currentTime;
            }

            Console.WriteLine($"Загальний час виготовлення механізму: {maxTime}");
            Console.ReadLine();
        }

        static int Deep(int node)
        {
            if (calculatedTime[node] != 0)
                return calculatedTime[node];

            int maxDepTime = 0;
            for (int i = 0; i < SIZE; i++)
            {
                if (graph[node, i] == 1)
                {
                    int depTime = Deep(i);
                    if (depTime > maxDepTime)
                        maxDepTime = depTime;
                }
            }

            calculatedTime[node] = time[node] + maxDepTime;
            return calculatedTime[node];
        }
    }
}

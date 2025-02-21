using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Lab2
{
    public class Task1
    {
        public struct Product
        {
            public string Name;
            public int Count;
            public decimal Price;
            public string Creator;
            public DateTime TimeOfArrive;
            public Product(string Name, int Count, decimal Price, string Creator)
            {
                this.Name = Name;
                this.Count = Count;
                this.Price = Price;
                this.Creator = Creator;
                TimeOfArrive = DateTime.Now;
            }
            public override string ToString()
            {
                return $"Name: {Name}\nCount: {Count}\nPrice: {Price}\nCreator: {Creator}\nArrival time: {TimeOfArrive}\n";
            }
        }
        public static decimal GetAvgPrice(Product[] products)
        {
            if (products.Length == 0)
            {
                Console.WriteLine("Array is empty!");
                return -1;
            }
            decimal sum = 0;
            foreach (Product p in products)
            {
                sum += p.Price;
            }
            return sum / products.Length;
        }
        public static void Run()
        {
            //Завдання 1

            const int size = 10;
            Product[] products = new Product[size];
            products[0] = new Product("Laptop", 10, 1500, "TechCorp");
            products[1] = new Product("Phone", 20, 899, "MobileInc");
            products[2] = new Product("Tablet", 15, 499, "TabMakers");
            products[3] = new Product("Monitor", 8, 300, "ScreenCo");
            products[4] = new Product("Keyboard", 25, 50, "KeyMakers");
            products[5] = new Product("Mouse", 30, 25, "MouseTech");
            products[6] = new Product("Printer", 5, 200, "PrintIt");
            products[7] = new Product("Scanner", 7, 180, "ScanCorp");
            products[8] = new Product("Headphones", 12, 79, "AudioTech");
            products[9] = new Product("Webcam", 10, 99, "CamWorld");

            decimal avgPrice = GetAvgPrice(products);
            if (avgPrice != -1)
                Console.WriteLine($"Товари з ціною, вище середньої({avgPrice})\n");
            foreach (Product p in products)
                if (p.Price >= avgPrice)
                    Console.WriteLine(p);
        }
    }
}

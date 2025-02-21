using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _02_Lab2
{
    internal class Program
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
            if(products.Length == 0)
            {
                Console.WriteLine("Array is empty!");
                return -1;
            }
            decimal sum = 0;
            foreach (Product p in products)
            {
                sum += p.Price;
            }
            return sum/products.Length;
        }
        public struct Car
        {
            public string Brand;
            public string Creator;
            public string Type;
            public DateTime CreationYear;
            public DateTime RegisterDate;
            public Car(string Brand, string Creator, string Type, DateTime CreationYear, DateTime RegisterDate)
            {
                this.Brand = Brand;
                this.Creator = Creator;
                this.Type = Type;    
                this.CreationYear = CreationYear;
                this.RegisterDate = RegisterDate;
            }
            public override string ToString()
            {
                return $"Brand: {Brand}\nType: {Type}\nCreator: {Creator}\nCreation Year: {CreationYear}\nRegisterDate: {RegisterDate}\n";
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const int size = 10;

            ////Завдання 1

            //Product[] products = new Product[size];
            //products[0] = new Product("Laptop", 10, 1500, "TechCorp");
            //products[1] = new Product("Phone", 20, 899, "MobileInc");
            //products[2] = new Product("Tablet", 15, 499, "TabMakers");
            //products[3] = new Product("Monitor", 8, 300, "ScreenCo");
            //products[4] = new Product("Keyboard", 25, 50, "KeyMakers");
            //products[5] = new Product("Mouse", 30, 25, "MouseTech");
            //products[6] = new Product("Printer", 5, 200, "PrintIt");
            //products[7] = new Product("Scanner", 7, 180, "ScanCorp");
            //products[8] = new Product("Headphones", 12, 79, "AudioTech");
            //products[9] = new Product("Webcam", 10, 99, "CamWorld");

            //decimal avgPrice = GetAvgPrice(products);
            //if(avgPrice != -1)
            //    Console.WriteLine($"Товари з ціною, вище середньої({avgPrice})\n");
            //    foreach (Product p in products)
            //        if (p.Price >= avgPrice)
            //            Console.WriteLine(p);                

            ////Завдання 2

            Car[] cars = new Car[size];
            cars[0] = new Car("Ford", "Ford Motor Company", "SUV", new DateTime(2020, 5, 1), new DateTime(1999, 6, 15));
            cars[1] = new Car("Ford", "Ford Motor Company", "Sedan", new DateTime(2019, 3, 15), new DateTime(1998, 5, 20));
            cars[2] = new Car("Toyota", "Toyota Motor Corporation", "SUV", new DateTime(2021, 2, 10), new DateTime(2021, 3, 15));
            cars[3] = new Car("Honda", "Honda Motor Co., Ltd.", "Sedan", new DateTime(2018, 7, 15), new DateTime(2018, 8, 20));
            cars[4] = new Car("Ford", "Ford Motor Company", "Pickup", new DateTime(2021, 8, 10), new DateTime(2021, 9, 12));
            cars[5] = new Car("Chevrolet", "General Motors", "Pickup", new DateTime(2019, 5, 30), new DateTime(2019, 6, 5));
            cars[6] = new Car("Ford", "Ford Motor Company", "Hatchback", new DateTime(2020, 11, 1), new DateTime(1998, 12, 10));
            cars[7] = new Car("BMW", "Bayerische Motoren Werke AG", "Coupe", new DateTime(2022, 1, 10), new DateTime(2022, 2, 5));
            cars[8] = new Car("Ford", "Ford Motor Company", "Coupe", new DateTime(2022, 6, 20), new DateTime(2022, 7, 25));
            cars[9] = new Car("Audi", "Audi AG", "Sedan", new DateTime(2020, 10, 15), new DateTime(2020, 11, 1));

            string brand = "Ford";
            if (cars.Length != 0)
            {
                foreach (var car in cars)
                    if(car.Brand == brand && car.RegisterDate.Year < 2000)
                        Console.WriteLine(car);
            }
            else
                Console.WriteLine("Array is empty!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Lab3
{
    public class Task2
    {
        class Guard
        {
            public string LastName;
            public string FirstName;
            public string MiddleName;
            public string Address;
            public DateTime BirthDate;

            public Guard(string LastName, string FirstName, string MiddleName, string Address, DateTime BirthDate)
            {
                this.LastName = LastName;
                this.FirstName = FirstName;
                this.MiddleName = MiddleName;
                this.Address = Address;
                this.BirthDate = BirthDate;
            }
            //public override string ToString()
            //{
            //    return $"Прізвище: {LastName}\nІм'я: {FirstName}\nПо батькові: {MiddleName}\nАдреса: {Address}\nДата народження: {BirthDate.Date}\n";
            //}
        }

        public static void Run()
        {
            string inputFile = "C:\\Users\\artem\\Desktop\\guards.txt";
            string outputFile = "C:\\Users\\artem\\Desktop\\oldest_guard.txt";

            if (!File.Exists(outputFile))
            {
                FileStream fs = new FileStream("C:\\\\Users\\\\artem\\\\Desktop\\\\oldest_guard.txt", FileMode.Create);
            }

            string[] lines = File.ReadAllLines(inputFile);
            Guard oldestGuard = null;

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length < 5 || parts.Length > 5)
                {
                    Console.WriteLine("Некоректний формат запису!");
                    continue;
                }
                
                string lastName = parts[0].Trim();
                string firstName = parts[1].Trim();
                string middleName = parts[2].Trim();
                string address = parts[3].Trim();
                DateTime birthDate;
               
                if (!DateTime.TryParse(parts[4].Trim(), out birthDate))
                {
                    Console.WriteLine("Помилка у форматі дати!");
                    continue;
                }

                Guard guard = new Guard(lastName, firstName, middleName, address, birthDate);

                if (oldestGuard == null || guard.BirthDate < oldestGuard.BirthDate)
                {
                    oldestGuard = guard;
                }
            }

            if (oldestGuard != null)
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine($"Старший охоронець:");
                    writer.WriteLine(oldestGuard);
                }

                Console.WriteLine("Дані про старшого охоронця записані у файл.");
            }
            else
            {
                Console.WriteLine("Не вдалося знайти жодного охоронця у файлі.");
            }
        }
    }
}

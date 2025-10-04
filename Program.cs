using System;
using System.Collections.Generic;

namespace Kodanalys
{
    class Program
    {
        static List<string> users = new List<string>();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                Console.Write("Ditt val: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        ShowUsers();
                        break;
                    case "3":
                        RemoveUser();
                        break;
                    case "4":
                        SearchUser();
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddUser()
        {
            Console.Write("Ange namn: ");
            string name = Console.ReadLine();

            if (users.Count < 10)
            {
                users.Add(name);
                Console.WriteLine("Användare tillagd.");
            }
            else
            {
                Console.WriteLine("Listan är full!");
            }
        }

        static void ShowUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Inga användare finns.");
                return;
            }

            Console.WriteLine("Användare:");
            foreach (var user in users)
                Console.WriteLine(user);
        }

        static void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string nameToRemove = Console.ReadLine();

            if (users.Remove(nameToRemove))
                Console.WriteLine("Användare borttagen.");
            else
                Console.WriteLine("Användaren hittades inte.");
        }

        static void SearchUser()
        {
            Console.Write("Ange namn att söka: ");
            string query = Console.ReadLine();

            if (users.Contains(query))
                Console.WriteLine("Användaren finns i listan.");
            else
                Console.WriteLine("Användaren hittades inte.");
        }
    }
}

using System;
using System.Collections.Generic;

namespace Kodanalys
{
    class Program
    {
        static List<string> users = new List<string>();
        static int userCount = 0;

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
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Ange namn: ");
                    string name = Console.ReadLine();

                    if (users.Count < 10)
                    {
                        users.Add(name);
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Användare:");
                    foreach (var user in users)
                    {
                        Console.WriteLine(user);
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string nameToRemove = Console.ReadLine();

                    if (users.Remove(nameToRemove))
                    {
                        Console.WriteLine("Användare borttagen.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                
                  
                else if (choice == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string query = Console.ReadLine();

                    if (users.Contains(query))
                    {
                        Console.WriteLine("Användaren finns i listan.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }

                }
                else if (choice == "5")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}

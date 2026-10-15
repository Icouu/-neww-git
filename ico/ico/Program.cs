using System;
using System.Collections.Generic;

namespace ico
{
    class TodoTask
    {
        public string Zaglavie { get; set; }
        public string Opisanie { get; set; }
        public DateTime KraenSrok { get; set; }
        public bool Izpulnena { get; set; }

        public TodoTask(string zaglavie, string opisanie, DateTime kraenSrok)
        {
            Zaglavie = zaglavie;
            Opisanie = opisanie;
            KraenSrok = kraenSrok;
            Izpulnena = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TodoManager();
        }

        static void TodoManager()
        {
            List<TodoTask> tasks = new List<TodoTask>();

            while (true)
            {
                Console.WriteLine("\n===== TodoManager =====");
                Console.WriteLine("1. Markiraj zadacha kato izpulnena");
                Console.WriteLine("2. Prekrati programata");
                Console.WriteLine("3. Istrij zadacha");
                Console.WriteLine("4. Pokaji vsichki zadachi");
                Console.WriteLine("5. Vuvedi zadacha");

                Console.Write("Izberi: ");
                string choice = Console.ReadLine();

                if (choice == "2")
                {
                    break;
                }

                if (choice == "5")
                {
                    Console.Write("Vuvedi zaglavie: ");
                    string zaglavie = Console.ReadLine();

                    Console.Write("Vuvedi opisanie: ");
                    string opisanie = Console.ReadLine();

                    Console.Write("Vuvedi kraen srok (dd.MM.yyyy): ");
                    DateTime kraenSrok;

                    if (!DateTime.TryParse(Console.ReadLine(), out kraenSrok))
                    {
                        Console.WriteLine("Nevalidna data!");
                        continue;
                    }

                    TodoTask task = new TodoTask(
                        zaglavie,
                        opisanie,
                        kraenSrok
                    );

                    tasks.Add(task);

                    Console.WriteLine("Zadachata e dobavena!");
                }
                else if (choice == "4")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Nqma zadachi!");
                    }
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine("\nZadacha №" + (i + 1));
                            Console.WriteLine("Zaglavie: " + tasks[i].Zaglavie);
                            Console.WriteLine("Opisanie: " + tasks[i].Opisanie);
                            Console.WriteLine("Kraen srok: " +
                                tasks[i].KraenSrok.ToShortDateString());

                            if (tasks[i].Izpulnena)
                            {
                                Console.WriteLine("Status: Izpulnena");
                            }
                            else
                            {
                                Console.WriteLine("Status: Neizpulnena");
                            }
                        }
                    }
                }
                else if (choice == "1")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Nqma zadachi za markirane!");
                        continue;
                    }

                    Console.Write("Vuvedi nomer na zadachata: ");
                    int nomer;

                    if (int.TryParse(Console.ReadLine(), out nomer) &&
                        nomer >= 1 && nomer <= tasks.Count)
                    {
                        tasks[nomer - 1].Izpulnena = true;
                        Console.WriteLine("Zadachata e markirana kato izpulnena!");
                    }
                    else
                    {
                        Console.WriteLine("Nevaliden nomer!");
                    }
                }
                else if (choice == "3")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Nqma zadachi za iztrivane!");
                        continue;
                    }

                    Console.Write("Vuvedi nomer na zadachata za iztrivane: ");
                    int nomer;

                    if (int.TryParse(Console.ReadLine(), out nomer) &&
                        nomer >= 1 && nomer <= tasks.Count)
                    {
                        tasks.RemoveAt(nomer - 1);
                        Console.WriteLine("Zadachata e iztrita!");
                    }
                    else
                    {
                        Console.WriteLine("Nevaliden nomer!");
                    }
                }
                else if (choice != "2" && choice != "5")
                {
                    Console.WriteLine("Nevalidna opciq!");
                }
            }

            Console.WriteLine("Programata e prekratena.");
        }
    }
}


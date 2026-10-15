using System;
using System.Collections.Generic;

namespace ico
{
    class TodoTask
    {
        // 1. Добавяме свойството за уникално ID
        public int Id { get; set; }
        public string Zaglavie { get; set; }
        public string Opisanie { get; set; }
        public DateTime KraenSrok { get; set; }
        public bool Izpulnena { get; set; }

        // Обновяваме конструктора, за да приема ID
        public TodoTask(int id, string zaglavie, string opisanie, DateTime kraenSrok)
        {
            Id = id;
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
            // Брояч, който ще дава уникално ID на всяка нова задача
            int nextId = 1;

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

                    // Подаваме текущото nextId и след това го увеличаваме с 1 (nextId++)
                    TodoTask task = new TodoTask(
                        nextId++,
                        zaglavie,
                        opisanie,
                        kraenSrok
                    );
                    tasks.Add(task);

                    Console.WriteLine($"Zadachata e dobavena s ID: {task.Id}!");
                }
                else if (choice == "4")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Nqma zadachi!");
                    }
                    else
                    {
                        foreach (var t in tasks)
                        {
                            // Изписваме реалното ID на задачата
                            Console.WriteLine("\nZadacha ID: " + t.Id);
                            Console.WriteLine("Zaglavie: " + t.Zaglavie);
                            Console.WriteLine("Opisanie: " + t.Opisanie);
                            Console.WriteLine("Kraen srok: " + t.KraenSrok.ToShortDateString());

                            if (t.Izpulnena)
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
                    Console.Write("Vuvedi ID на zadachata: ");
                    int tursenoId;

                    if (int.TryParse(Console.ReadLine(), out tursenoId))
                    {
                       
                        TodoTask taskToMark = tasks.Find(t => t.Id == tursenoId);

                        if (taskToMark != null)
                        {
                            taskToMark.Izpulnena = true;
                            Console.WriteLine("Zadachata e markirana kato izpulnena!");
                        }
                        else
                        {
                            Console.WriteLine("Zadacha с такова ID не съществува!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nevaliden format на ID!");
                    }
                }
                else if (choice == "3")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Nqma zadachi za iztrivane!");
                        continue;
                    }
                    Console.Write("Vuvedi ID на zadachata za iztrivane: ");
                    int tursenoId;

                    if (int.TryParse(Console.ReadLine(), out tursenoId))
                    {
                        TodoTask taskToRemove = tasks.Find(t => t.Id == tursenoId);

                        if (taskToRemove != null)
                        {
                            tasks.Remove(taskToRemove);
                            Console.WriteLine("Zadachata e iztrita!");
                        }
                        else
                        {
                            Console.WriteLine("Zadacha с такова ID не съществува!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nevaliden format на ID!");
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

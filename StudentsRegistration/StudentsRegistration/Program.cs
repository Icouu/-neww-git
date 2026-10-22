
using System;
using System.Globalization;

namespace StudentsRegistration
{
    internal class Program
    {
        static int nextId = 1;

        static void Main(string[] args)
        {
            Student student = null;

            while (student == null)
            {
                Console.Write("Ime: ");
                string name = Console.ReadLine();

                try
                {
                    student = new Student(nextId, name);
                    nextId++;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Vusrast: ");

                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    try
                    {
                        student.Age = age;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Nevaliden format za vusrast.");
                }
            }

            while (true)
            {
                Console.Write("Class: ");

                if (int.TryParse(Console.ReadLine(), out int grade))
                {
                    try
                    {
                        student.Grade = grade;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Nevaliden format za klas.");
                }
            }

            while (true)
            {
                Console.Write("Sreden uspeh: ");

                if (double.TryParse(Console.ReadLine(), out double averageGrade))
                {
                    try
                    {
                        student.AverageScore = averageGrade;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Nevaliden sreden uspeh.");
                }
            }

            while (true)
            {
                Console.Write("Taksa: ");

                if (decimal.TryParse(Console.ReadLine(), out decimal fee))
                {
                    try
                    {
                        student.Fee = fee;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Nevalidna taksa.");
                }
            }

            while (true)
            {
                Console.Write("Imash li pravo na stipendiq (true/false): ");

                if (bool.TryParse(Console.ReadLine(), out bool scholarship))
                {
                    student.HasScholarship = scholarship;
                    break;
                }
                else
                {
                    Console.WriteLine("Vuvedi true ili false.");
                }
            }

            while (true)
            {
                Console.Write("Bukva na paralelkata: ");

                if (char.TryParse(Console.ReadLine(), out char classLetter))
                {
                    try
                    {
                        student.ClassLetter = classLetter;
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Nevalidna bukva na paralelka.");
                }
            }

            while (true)
            {
                Console.Write("Data na rajdane (dd.MM.yyyy): ");

                if (DateTime.TryParseExact(
                    Console.ReadLine(),
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime birthDate))
                {
                    try
                    {
                        student.BirthDate = birthDate;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Nevalidna data.");
                }
            }

            Console.WriteLine("\n=== DANNI ZA UCHENIK ===");
            Console.WriteLine("Id: " + student.Id);
            Console.WriteLine("Ime: " + student.Name);
            Console.WriteLine("Vusrast: " + student.Age);
            Console.WriteLine("Klas: " + student.Grade);
            Console.WriteLine("Sreden uspeh: " + student.AverageScore);
            Console.WriteLine("Taksa: " + student.Fee.ToString("F2") + " lv.");

            if (student.HasScholarship)
            {
                Console.WriteLine("Stipendiq: Da");
            }
            else
            {
                Console.WriteLine("Stipendiq: Ne");
            }

            Console.WriteLine("Paralelka: " + student.ClassLetter);
            Console.WriteLine("Data na rajdane: " +
                student.BirthDate.ToString("dd.MM.yyyy"));
        }
    }
}

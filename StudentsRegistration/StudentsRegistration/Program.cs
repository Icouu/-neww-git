namespace StudentsRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ime:");
            string name = Console.ReadLine();
            Console.Write("Vusrast: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Vusrast: {age}");
            }
            else
            {
                Console.WriteLine("Nevalidna vusrast.");
            }
            Console.Write("Class: ");
            if (byte.TryParse(Console.ReadLine(), out byte grade))
            {
                Console.WriteLine($"Class: {grade}");
            }
            else
            {
                Console.WriteLine("Nevaliden Class.");
            }
            Console.WriteLine("Sreden uspeh:");
            if (double.TryParse(Console.ReadLine(), out double averageGrade))
            {
                Console.WriteLine($"Sreden uspeh: {averageGrade}");
            }
            else
            {
                Console.WriteLine("Nevaliden sreden uspeh");
            }
            Console.Write("Taksa");
            if (decimal.TryParse(Console.ReadLine(), out decimal fee))
            {
                Console.WriteLine($"Taksa: {fee:F2} lv/euro.");
            }
            else
            {
                Console.WriteLine("Nevalidna taksa");
            }
               Console.Write("Imash li pravo na stipendiq (true/false): ");
            if (bool.TryParse(Console.ReadLine(), out bool scholarship))
            {
                Console.WriteLine($"Stipendiq: {scholarship}");
            }
            else
            {
                Console.WriteLine("Nevalidna stoinost za stipendiq");
            }
            Console.Write("Bukva na paralelkata: ");
            if (char.TryParse(Console.ReadLine(), out char classLetter))
            {
                Console.WriteLine($"Paralelka {classLetter}");
            }
            else
            {
                Console.WriteLine("Nevalidna bukva na paralelka");
            }
        }
    }
}

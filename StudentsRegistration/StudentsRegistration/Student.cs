
using System;

namespace StudentsRegistration
{
    internal class Student
    {
        public int Id { get; private set; }

        private string name;
        private int age;
        private int grade;
        private double averageScore;
        private decimal fee;
        private char classLetter;
        private DateTime birthDate;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nevalidno ime!");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 6 || value > 20)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Age), "Vuzrastta trqbva da e mejdu 6 i 20!");
                }
                age = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Grade), "Klasut trqbva da e mejdu 1 i 12!");
                }
                grade = value;
            }
        }

        public double AverageScore
        {
            get { return averageScore; }
            set
            {
                if (value < 2 || value > 6 || double.IsNaN(value))
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(AverageScore), "Uspehut trqbva da e mejdu 2 i 6!");
                }
                averageScore = value;
            }
        }

        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Fee), "Taksata ne moje da e otricatelna!");
                }
                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        public char ClassLetter
        {
            get { return classLetter; }
            set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentException("Paralelkata trqbva da e bukva!");
                }
                classLetter = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value.Date > DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(BirthDate), "Datata ne moje da e v budeshteto!");
                }
                birthDate = value;
            }
        }

        public Student(int id, string name)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(id), "ID trqbva da e polojitelno!");
            }

            Id = id;
            Name = name;
        }
    }
}

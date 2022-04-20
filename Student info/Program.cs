using System;

namespace Student_info
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Student student1 = new Student("Kamran", "Gasimov", 26, "P324", 81, true);

            if (student1.Point<80)
            {
                Console.WriteLine("Telebenin kecid bali kecerli deyil");

            }
            else
            {
                Console.WriteLine(student1.getInfo());    
            }
        }
    }

    class Student 
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduated;



        public Student(string name, string surname, byte age, string group,  byte point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;

        }
        public string getInfo()
        {
            

            return $"Name: {Name}, Surname:{Surname}, Group: {Group}, Point: {Point}, IsGraduated: {IsGraduated}";
        }
    }
}

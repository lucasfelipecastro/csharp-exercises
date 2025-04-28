using System;

namespace Program {
    public class Program {
        public static void Main(string[] args) {
            Student student = new Student();

            Console.Write("Student Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter the student's three grades: ");
            student.Grade1 = double.Parse(Console.ReadLine());
            student.Grade2 = double.Parse(Console.ReadLine());
            student.Grade3 = double.Parse(Console.ReadLine());

            double final_grade = student.Grade1 + student.Grade2 + student.Grade3;
            Console.WriteLine($"Final Grade: {final_grade}");

            if (final_grade >= 60) {
                Console.WriteLine("Student passed.");
            }
            else {
                Console.WriteLine("Student failed.");
                double missing = 60 - final_grade;
                Console.WriteLine($"Missing: {missing}");
            }
        }
    }
}
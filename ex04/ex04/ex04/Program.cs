using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Type your employee number: ");
            int employee_number = int.Parse(Console.ReadLine());

            Console.Write("Type your hours worked: ");
            int hours_worked = int.Parse(Console.ReadLine());

            Console.Write("Type your hourly rate: ");
            double hourly_rate = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double salary = (hourly_rate * hours_worked);

            Console.WriteLine($"NUMBER: {employee_number}");
            Console.WriteLine($"SALARY: ${salary:F2}");
        }
    }
}
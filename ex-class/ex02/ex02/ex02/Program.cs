using System;
using ex02;

namespace Ex02 {
    class Program {
        static void Main(string[] args) {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Console.WriteLine("First employee: ");
            Console.WriteLine("---------------");

            Console.Write("Name: ");
            employee1.name = Console.ReadLine();
            Console.Write("Salary: ");
            employee1.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Second employee: ");
            Console.WriteLine("---------------");


            Console.Write("Name: ");
            employee2.name = Console.ReadLine();
            Console.Write("Salary: ");
            employee2.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("---------------");
            double average_salary = (employee1.salary + employee2.salary) / 2;
            Console.WriteLine($"Average Salary: {average_salary:F2}");
        }
    }
}
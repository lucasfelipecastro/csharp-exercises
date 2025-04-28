using System;

namespace Program {
    public class Program {
        static void Main(string[] args) {
            Employee employee = new Employee();

            Console.Write("Name: ");
            employee.name = Console.ReadLine();

            Console.Write("Gross Salary: ");
            employee.gross_salary = double.Parse(Console.ReadLine());

            Console.Write("Tax: ");
            employee.tax = double.Parse(Console.ReadLine());

            Console.WriteLine($"Employee INFOS: {employee.name}, ${employee.gross_salary} ");

            Console.Write("Enter the percentage to increase the salary (EXAMPLE: 10.0): ");
            double percentage = double.Parse(Console.ReadLine());

            employee.increase_salary(percentage);
            Console.WriteLine($"Updated INFOS: {employee.name}, ${employee.net_salary()}"); // Use net_salary() to display updated salary
        }
    }
}
using System;

class Program {
    static void Main() {
        Console.Write("Enter the first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber;

        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");
    }
}

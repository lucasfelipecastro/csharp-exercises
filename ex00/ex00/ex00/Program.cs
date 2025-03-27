using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        /// Receiving the full name
        Console.Write("Enter with your full name: ");
        string full_name = Console.ReadLine();

        /// Receiving the room count
        Console.Write("How many rooms are in your house: ");
        int rooms = int.Parse(Console.ReadLine());

        /// Price of the product
        Console.Write("Enter with price of a product: ");
        double price = double.Parse(Console.ReadLine());

        /// Last name, age and height
        Console.WriteLine("Enter with your last name, age and height (in this order)");
        Console.WriteLine("Example: Silva 20 1.88");
        Console.Write(">>> ");

        
        string all_info = Console.ReadLine();
        string[] data = all_info.Split(' ');

        string lastName = data[0];
        int age = int.Parse(data[1]);
        double height = double.Parse(data[2], CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("- - - Informations - - -");
        Console.WriteLine($"Full name: {full_name}");
        Console.WriteLine($"Number of rooms: {rooms}");
        Console.WriteLine($"Product price: {price:F2}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height:F2}");
    }
}
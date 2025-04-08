using System;

    namespace Program {
    class Program {
        static void Main(string[] args) {
            int obj_alcohol = 1;
            int obj_gasoline = 2;
            int obj_diesel = 3;
            int obj_exit = 4;
            Console.WriteLine($"Alcohol: {obj_alcohol}");
            Console.WriteLine($"Gasoline: {obj_gasoline}");
            Console.WriteLine($"Diesel: {obj_diesel}");
            Console.WriteLine($"Exit: {obj_exit}");

            int count_alcohol = 0;
            int count_gasoline = 0;
            int count_diesel = 0;
            
            while (true) {
                Console.WriteLine("------------------");
                Console.Write("Enter fuel number: ");
                int fuelNumber = int.Parse(Console.ReadLine());

                if (fuelNumber == obj_alcohol) {
                    count_alcohol++;
                }
                else if (fuelNumber == obj_gasoline) {
                    count_gasoline++;
                }
                else if (fuelNumber == obj_diesel) {
                    count_diesel++;
                }
                else if (fuelNumber == obj_exit){
                    Console.WriteLine("------------------");
                    Console.WriteLine("Thank you!");
                    Console.WriteLine($"Alcohol: {count_alcohol}");
                    Console.WriteLine($"Gasoline: {count_gasoline}");
                    Console.WriteLine($"Diesel: {count_diesel}");
                    return;
                }
                else {
                    Console.WriteLine("Invalid fuel number. Please try again.");
                }
            }

        }
    }
}
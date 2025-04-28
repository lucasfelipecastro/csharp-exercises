using System;
using ex01;

namespace Program {
    class Program {
        static void Main(string[] args) {
            PersonName name_person1 = new PersonName();
            PersonName name_person2 = new PersonName();
            Age age_person1 = new Age();
            Age age_person2 = new Age();

            Console.WriteLine("First person: ");
            Console.WriteLine("------------");
            Console.Write("Name: ");
            name_person1.name = Console.ReadLine();

            Console.Write("Age: ");
            age_person1.age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Second person: ");
            Console.WriteLine("------------");
            Console.Write("Name: ");
            name_person2.name = Console.ReadLine();

            Console.Write("Age: ");
            age_person2.age = int.Parse(Console.ReadLine());

            int older = age_person1.age;
            if (age_person2.age > age_person1.age) {
                older = age_person2.age;
                Console.WriteLine($"Older Person: {name_person2.name}");
            }
            else {
                Console.WriteLine($"Older Person: {name_person1.name}");
            }
        }
    }
}
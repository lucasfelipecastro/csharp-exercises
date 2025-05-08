using System;
using System.Collections.Generic;

namespace ex00 {
    internal class Program {
        static void Main(string[] args) {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            List<Person> peoples = new List<Person>();

            Console.Write("Person1 ");
            Console.Write("Name: ");
            person1.Name = Console.ReadLine();

            Console.Write("Age: ");
            person1.Age = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            person1.Email = Console.ReadLine();
            Console.WriteLine("------------------------");


            Console.Write("Person2 ");
            Console.Write("Name: ");
            person2.Name = Console.ReadLine();

            Console.Write("Age: ");
            person2.Age = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            person2.Email = Console.ReadLine();
            Console.WriteLine("------------------------");


            Console.Write("Person3 ");
            Console.Write("Name: ");
            person3.Name = Console.ReadLine();

            Console.Write("Age: ");
            person3.Age = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            person3.Email = Console.ReadLine();
            Console.WriteLine();

            peoples.Add(new Person { Name = person1.Name, Age = person1.Age, Email = person1.Email });
            peoples.Add(new Person { Name = person2.Name, Age = person2.Age, Email = person2.Email });
            peoples.Add(new Person { Name = person3.Name, Age = person3.Age, Email = person3.Email });
            
            foreach (Person p in peoples) {
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Age: {p.Age}");
                Console.WriteLine($"Email: {p.Email}");
                Console.WriteLine("------------------------");
            }
        }
    }
}
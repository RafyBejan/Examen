﻿namespace ExaemenOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate persoane");
            int numberOfPeople = int.Parse(Console.ReadLine());

            Person[] people = new Person[numberOfPeople];

            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.WriteLine("informatii");
                people[i] = Print();

            }
            Person oldestPerson = PersonProcessor.FindTheOldestPerson(people);

            if (oldestPerson != null)
            {
                Console.WriteLine($"peroana cu cea mai mare varsta: {oldestPerson.FirstName};{oldestPerson.LastName}");
                Console.WriteLine($" varsta; {oldestPerson.Age}");
            }
            else
            {
                Console.WriteLine("nu exista");

            }
            foreach (var person in people)
            {
                Console.WriteLine($"Nume: {person.FirstName} {person.LastName}");
                Console.WriteLine($"Year of birth: {person.YearOfBirth}");
                Console.WriteLine($"Age: {person.Age}\n");
            }
            static Person Print()
            {
                Person person = new Person();
                Console.WriteLine("Prenume: ");
                person.FirstName = Console.ReadLine();

                Console.WriteLine(" Nume de familie: ");
                person.LastName = Console.ReadLine();

                Console.WriteLine("Varsta: ");
                person.YearOfBirth = int.Parse(Console.ReadLine());

                return person;
            }
        }
    }
}
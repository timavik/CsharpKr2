namespace KrNumber5
{
    using System;
    using System.Collections.Generic;
    using KrNumber5.Models;

    internal class Program
    {
        static void Main(string[] args)
        {
            IEntityRepository<Person> repository = new InMemoryRepository<Person>();

            repository.Add(new Person { Id = 1, Name = "Tim", Age = 30 });
            repository.Add(new Person { Id = 2, Name = "Bob", Age = 25 });

            Console.WriteLine("All persons in memory:");
            foreach (var person in repository.GetAll())
            {
                Console.WriteLine(person);
            }

            repository.Update(1, new Person { Id = 2, Name = "Robert", Age = 26 });

            Console.WriteLine("\nUpdated persons in memory:");
            foreach (var person in repository.GetAll())
            {
                Console.WriteLine(person);
            }

            string filePath = "persons.json";
            IDataStorage<Person> dataStorage = new JsonDataStorage<Person>();
            dataStorage.SaveToFile(filePath, repository.GetAll());

            Console.WriteLine($"\nData saved to {filePath}");

            List<Person> loadedPersons = dataStorage.LoadFromFile(filePath);

            Console.WriteLine("\nLoaded persons from file:");
            foreach (var person in loadedPersons)
            {
                Console.WriteLine(person);
            }
            Console.ReadKey();
        }
    }
}

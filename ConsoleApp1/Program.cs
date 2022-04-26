using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // start fresh each run
            Operations.CreateFromMockedData();

            foreach (var person in Operations.RemoveList())
            {
                Console.WriteLine(Operations.Remove(person.FirstName, person.LastName) ?
                    $"Removed {person}" :
                    $"{person} does not exists");
            }

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [JsonIgnore]
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString() => FullName;
    }

    public class Operations
    {
        public static string FileName = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "People.json");
        public static List<Person> MockedList()
        {
            return new List<Person>
            {
                new () { FirstName = "Anne", LastName = "Jones" },
                new () { FirstName = "Chuck", LastName = "Smith" },
                new () {FirstName = "Mary", LastName = "Adams"}
            };
        }
        public static List<Person> RemoveList()
        {
            return new List<Person>
            {
                new () { FirstName = "Bill", LastName = "Jones" },
                new () { FirstName = "Chuck", LastName = "Smith" },
                new () {FirstName = "Jon", LastName = "Adams"}
            };
        }

        public static void CreateFromMockedData()
        {
            var json = JsonConvert.SerializeObject(MockedList(), Formatting.Indented);
            File.WriteAllText(FileName, json);
        }

        public static bool Remove(string firstName, string lastName)
        {
            var json = File.ReadAllText(FileName);
            var list = JsonConvert.DeserializeObject<List<Person>>(json);

            var person = list!.FirstOrDefault(x =>
                x.FirstName.CompareToo(firstName) && x.LastName.CompareToo(lastName));

            if (person is null)
            {
                return false;
            }
            else
            {
                list.Remove(person);
                File.WriteAllText(FileName, 
                    JsonConvert.SerializeObject(list, Formatting.Indented));
                return true;
            }

        }
    }
    public static class StringExtensions
    {
        public static bool CompareToo(this string left, string right, bool ignoreCase = true)
            => string.Compare(left, right, ignoreCase) == 0;
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index < 5; index++)
            {
                //Console.WriteLine(Next($"F{index}"));
            }

            Console.WriteLine(Next("1278-120"));


            Console.ReadLine();
        }

        public static string Next(string value)
        {
            string number = Regex.Match(value, "[0-9]+$").Value;

            return value.Substring(0, value.Length - number.Length) +
                   (long.Parse(number) + 1).ToString().PadLeft(number.Length, '0');
        }

        private static void ExampleOne()
        {
            // start fresh each run
            Operations.CreateFromMockedData();

            foreach (var person in Operations.RemoveList())
            {
                Console.WriteLine(Operations.Remove(person.FirstName, person.LastName) ? $"Removed {person}" : $"{person} does not exists");
            }
        }

        private static void GetFileList()
        {
            Directory.GetFiles(
                    AppDomain.CurrentDomain.BaseDirectory, "Name*.*")
                .Where(fileName => !fileName.EndsWith("prototype"))
                .ToList()
                .ForEach(Console.WriteLine);







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

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using EntityDataExample.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityDataExample
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadAll();
            Doctors();
            Actors();
            Console.ReadLine();
        }

        private static void Actors()
        {
            Console.WriteLine(nameof(Actors));
            using var context = new Context();

            int occupationIdentifier = 2;

            var actors = context.Person
                .Include(p => p.OccupationIdentifierNavigation)
                .Include(p => p.CountryIdentifierNavigation)
                .Where(p => p.OccupationIdentifier == occupationIdentifier)
                .ToList();

            foreach (var person in actors)
            {
                Console.WriteLine($"{person.Id,-4}{person.FullName,-15}{person.CountryIdentifierNavigation.Name,-20}{person.OccupationIdentifierNavigation.Description}");
            }

            Console.WriteLine();
        }

        private static void Doctors()
        {
            Console.WriteLine(nameof(Doctors));

            using var context = new Context();

            int occupationIdentifier = 1;

            var doctors = context.Person
                .Include(p => p.OccupationIdentifierNavigation)
                .Include(p => p.CountryIdentifierNavigation)
                .Where(p => p.OccupationIdentifier == occupationIdentifier)
                .ToList();

            foreach (var person in doctors)
            {
                Console.WriteLine($"{person.Id,-4}{person.FullName,-15}{person.CountryIdentifierNavigation.Name,-20}{person.OccupationIdentifierNavigation.Description}");
            }

            Console.WriteLine();
        }

        private static void ReadAll()
        {
            Console.WriteLine(nameof(ReadAll));

            using var context = new Context();
            var allPeople = context.Person
                .Include(p => p.OccupationIdentifierNavigation)
                .Include(p => p.CountryIdentifierNavigation).ToList();

            foreach (var person in allPeople)
            {
                Console.WriteLine($"{person.Id,-4}{person.FullName,-15}{person.CountryIdentifierNavigation.Name,-20}{person.OccupationIdentifierNavigation.Description}");
            }

            Console.WriteLine();
        }
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code samples";
        }
    }
}

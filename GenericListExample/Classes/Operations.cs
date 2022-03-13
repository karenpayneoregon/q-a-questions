using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using GenericListExample.Models;

namespace GenericListExample.Classes
{
    public class Operations
    {
        /// <summary>
        /// Get current assembly name
        /// </summary>
        /// <returns></returns>
        public static string CurrentAssembly() =>
            Path.GetFileNameWithoutExtension(
                Assembly.GetExecutingAssembly()
                    .ManifestModule.Name);

        /// <summary>
        /// Get assembly name with Models folder which contains our models/classes
        /// </summary>
        public static string ModelsFolder => $"{CurrentAssembly()}.{nameof(Models)}";

        /// <summary>
        /// Create list from type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IList ListFromType(Type type)
        {
            var listType = typeof(List<>);
            var constructedType = listType.MakeGenericType(type);
            return (IList)Activator.CreateInstance(constructedType);
        }

        /// <summary>
        /// Process list from <see cref="ListFromType"/>
        /// </summary>
        /// <param name="created"></param>
        /// <param name="list"></param>
        public static void ProcessToList(object created, IList list)
        {
            switch (created)
            {
                case Car car:
                {
                    list.Add(new Car() { Id = 1, Manufacturer = "Ford", Model = "Mustang" });
                    list.Add(new Car() { Id = 2, Manufacturer = "Mazda", Model = "Miata" });

                    car = new Car() { Id = 3, Manufacturer = "Ford", Model = "Mustang IV" };

                    list.Add(car);

                    var cars = list.Cast<Car>().ToList();

                    foreach (var singleCar in cars)
                    {
                        Console.WriteLine($"{singleCar.Manufacturer}, {singleCar.Model}");
                    }

                    break;
                }
                case Product:

                    list.Add(new Product() { Id = 1, Name = "Phone" });
                    list.Add(new Product() { Id = 2, Name = "Watch" });

                    var products = list.Cast<Product>().ToList();

                    foreach (var product in products)
                    {
                        Console.WriteLine($"{product.Id,-3}{product.Name}");
                    }

                    break;

                case Person:

                    list.Add(new Person() { Id = 1, FirstName = "Karen", LastName = "Payne" });
                    list.Add(new Person() { Id = 2, FirstName = "Mary", LastName = "Jones" });

                    var people = list.Cast<Person>().ToList();

                    foreach (var person in people)
                    {
                        Console.WriteLine($"{person.Id,-3}{person.FullName}");
                    }

                    break;

                default:
                    throw new InvalidCastException("TODO");
            }
        }

    }
}

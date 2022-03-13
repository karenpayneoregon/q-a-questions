using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using GenericListExample.Classes;

namespace GenericListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classes = new[] { "Person", "Product", "Car" };

            foreach (var currentClass in classes)
            {

                ObjectHandle classHandle = Activator.CreateInstance(null,
                    $"{Operations.ModelsFolder}.{currentClass}");

                object created = classHandle.Unwrap();
                Type type = created.GetType();

                IList list = Operations.ListFromType(type);

                Console.WriteLine($"Processing: {type.Name}");
                Operations.ProcessToList(created, list);
                Console.WriteLine();

            }

            Console.ReadLine();

        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code samples";
        }
    }

}

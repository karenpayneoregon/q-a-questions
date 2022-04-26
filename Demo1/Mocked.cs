using System.Collections.Generic;

namespace Demo1
{
    public class Mocked
    {
        public static List<Item> List => new List<Item>()
        {
            new Item() { Country = "Canada", Name = "Jane" },
            new Item() { Country = "France", Name = "Luke" },
            new Item() { Country = "Japan", Name = "Anne" },
            new Item() { Country = "Africa", Name = "Mike" }
        };
    }
}
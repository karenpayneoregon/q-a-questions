using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OccurrencesApp.Classes
{
    public class Operations
    {

        public static List<Item> GetAllItems(string values) 
            => (from item in ProcessData(values) select item).ToList();

        public static List<List<Item>> ReadFromFile()
        {
            var itemList = new List<List<Item>>();
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.txt");
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                itemList.Add((from item in ProcessData(line) select item).ToList());
            }

            return itemList;
        }

        private static IOrderedEnumerable<Item> ProcessData(string values)
        {
            var itemsGroup = (
                    from chr in values.ToCharArray()
                    group chr by chr
                    into grp
                    select new Item
                    {
                        Character = grp.Key,
                        Occurrences = grp.Count(),
                        Code = Convert.ToInt32((int)grp.Key)
                    })
                .ToList()
                .OrderBy(item => item.Character.ToString());

            return itemsGroup;
        }
    }
}
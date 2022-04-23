using System;
using System.Collections.Generic;
using System.Linq;

namespace OccurrencesApp.Classes
{
    public class Operations
    {
        /// <summary>
        /// Count occurrences for each char in a string
        /// </summary>
        public static List<Item> GetAllItems(string values)
        {
            var itemsGroup = (
                    from chr in values.ToCharArray()
                    group chr by chr into grp
                    select new Item
                    {
                        Character = grp.Key,
                        Occurrences = grp.Count(),
                        Code = Convert.ToInt32((int)grp.Key)
                    })
                .ToList()
                .OrderBy(item => item.Character.ToString());

            return (from item in itemsGroup select item).ToList();

        }

        /// <summary>
        /// Count occurrences of numbers in array
        /// </summary>
        public static List<NumberItem> GetAllNumbers(int[] values)
        {
            IOrderedEnumerable<NumberItem> itemsGroup = (
                    from chr in values
                    group chr by chr into grp
                    select new NumberItem
                    {
                        Item = grp.Key,
                        Occurrences = grp.Count()
                    })
                .ToList()
                .OrderBy(item => item.Item.ToString());

            return (from item in itemsGroup select item).ToList();

        }
    }
}
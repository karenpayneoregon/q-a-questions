using CountCharactersApp.Models;

namespace CountCharactersApp.Classes;
internal static class StringExtensions
{
    public static IOrderedEnumerable<Item> Occurrences(this string sender) =>
        (sender.ToCharArray()
            .GroupBy(chr => chr)
            .Select(grp => new Item
            {
                Character = grp.Key, 
                Occurrences = grp.Count(), 
                Code = Convert.ToInt32((int)grp.Key)
            }))
        .ToList()
        .OrderBy(item => item.Character.ToString());
}

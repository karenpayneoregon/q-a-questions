using CountCharactersApp.Models;

namespace CountCharactersApp.Classes
{
    public class StringHelpers
    {
        public static List<Item> GetAllItems(string values)
        {
            var itemsGroup = (values.ToCharArray()
                    .GroupBy(chr => chr)
                    .Select(grp => new Item
                    {
                        Character = grp.Key, 
                        Occurrences = grp.Count(), 
                        Code = Convert.ToInt32((int)grp.Key)
                    }))
                .ToList()
                .OrderBy(item => item.Character.ToString());

            return (itemsGroup.Select(item => item)).ToList();

        }

        public static List<Item> GetNumbersOnly(string values)
            => GetAllItems(values).Where(item => char.IsDigit(item.Character)).ToList();

        public static List<Item> GetLowerLettersOnly(string values) 
            => GetAllItems(values).Where(item => char.IsLower(item.Character)).ToList();

        public static List<Item> GetUpperLettersOnly(string values) 
            => GetAllItems(values).Where(item => char.IsUpper(item.Character)).ToList();

        public static List<Item> GetLettersOnly(string values)
            => GetAllItems(values).Where(item => char.IsLetter(item.Character)).ToList();

        public static List<Item> GetSpecialOnly(string values)
            => GetAllItems(values).Where(item => !char.IsLetterOrDigit(item.Character)).ToList();


        public static (int letterCount, int numberCount, int specialCount) GetDetails(string values)
        {
            var items = GetAllItems(values);

            return (
                items.Count(item => char.IsLetter(item.Character)),
                items.Where(item => char.IsDigit(item.Character)).Select(x => x.Occurrences).Sum(),
                items.Count(item => !char.IsLetterOrDigit(item.Character)));

        }


    }
}
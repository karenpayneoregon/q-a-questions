# About

Code to obtain count of each character in a string. In this case showing numerics.

![Occurances](assets/occurances.png)

```csharp
private void ReadFileButton_Click(object sender, EventArgs e)
{
    List<Item> GetInfo(List<List<Item>> list, int findChar)
    {
        var items = 
            (
                from sublist in list 
                from item in sublist 
                where item.Character == findChar select item).ToList();
        return items;
    }

    List<List<Item>> itemList = Operations.ReadFromFile();
    
    var one = GetInfo(itemList, '1').Sum(x => x.Occurrences);
    var eight = GetInfo(itemList, '8').Sum(x => x.Occurrences);
    Console.WriteLine($"1 = {one,-4}8 = {eight}");

}
```

</br>

```csharp
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
```
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text.Json;
using BindingListLibrary;
using DataGridViewCheckBoxApp.Models;

namespace DataGridViewCheckBoxApp;

public partial class Form1 : Form
{
    private readonly BindingSource _bindingSource = new ();
    private SortableBindingList<Item> _bindingList;
    public Form1()
    {
        InitializeComponent();
        Shown += OnShown;
    }
    
    private void OnShown(object sender, EventArgs e)
    {

        _bindingList = new SortableBindingList<Item>(new List<Item>()
        {
            new() { Selected = false, Id = 1, Description = "A"},
            new() { Selected = false, Id = 2, Description = "B"},
            new() { Selected = false, Id = 3, Description = "B"},
            new() { Selected = false, Id = 4, Description = "A"},
        });

        _bindingSource.DataSource = _bindingList;
        dataGridView1.DataSource = _bindingSource;
        dataGridView1.Columns[nameof(Item.Id)]!.ReadOnly = true;
        dataGridView1.CellContentClick += DataGridView1OnCellContentClick;
    }

    private void DataGridView1OnCellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != 0) return;

        dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

        for (int index = 0; index < _bindingList.Count; index++)
        {
            if (_bindingList[index].Selected)
            {
                // TODO
            }
            else
            {
                // TODO
            }
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        CustomContainer dictionary = new();
        dictionary.Add(new CustomItem() { Key = 1, Value = new List<string>() });
        dictionary.Add(new CustomItem() {Key = 2, Value = new List<string>() {"A", "B"}});
        dictionary.Add(new CustomItem() {Key = 3, Value = new List<string>()});
        dictionary.Add(new CustomItem() {Key = 4, Value = new List<string>() { "C", "D" } });
        dictionary.Add(new CustomItem() {Key = 3, Value = new List<string>()});


        Debug.WriteLine(dictionary.Serialize());
        Debug.WriteLine(dictionary.TryAdd(new CustomItem() { Key = 1, Value = new List<string>() { "A", "B" } })
            ? "Added"
            : "Not added");

        Debug.WriteLine($"Contains value? {dictionary.ContainsValue(new List<string>() { "A", "B" })}");
        Debug.WriteLine($"Contains value? {dictionary.ContainsValue(new List<string>() { "A", "b" })}");

        Debug.WriteLine(dictionary.ContainsKey(2));
        
        var item = dictionary[1];
        dictionary.Remove(item);
        
        dictionary.Clear();
        

    }

    private static void Dict1()
    {
        Dictionary<string, int> originalDictionary = new()
        {
            { "one", 1 },
            { "four", 4 },
            { "two", 2 },
            { "three", 3 }
        };


        List<KeyValuePair<string, int>> myList = originalDictionary.ToList();
        myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
    }
}

public class CustomItem
{
    public int Key { get; set; }
    public List<string> Value { get; set; }
    public override string ToString() => $"{Key} {Value.Count}";
}

public class CustomContainer
{

    public List<CustomItem> Items = new();
    public CustomItem this[int index] => Items[index];
    public int Count => Items.Count;

    public bool ContainsKey(int index) 
        => Items.Any(x => x.Key == index);

    public bool ContainsValue(List<string> list) 
        => Items.Select(customItem => customItem.Value).ToList().Any(item => item.SequenceEqual(list));

    public void Add(CustomItem item)
    {
        if (Items.All(customItem => customItem.Key != item.Key))
        {
            Items.Add(item);
        }
    }
    public bool TryAdd(CustomItem item)
    {
        if (Items.All(payneItem => payneItem.Key != item.Key))
        {
            Items.Add(item);
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Remove(CustomItem item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
        }
    }

    public void Clear()
    {
        Items.Clear();
    }

    public string Serialize()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize(Items, options);
    }
}
namespace Demo1
{
    public class Item
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public override string ToString() => $"{Name} {Country}";
    }
}
namespace RadioButtonSelection.Classes
{
    public class Item
    {
        public string CityName { get; set; }
        public int Lodging { get; set; }
        public int Days { get; set; }
        public int Fee { get; set; }
        public int Cost => Fee + (Days * Lodging);
        public override string ToString() => CityName;
    }
}
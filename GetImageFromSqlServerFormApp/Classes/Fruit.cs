using System.Drawing;

namespace GetImageFromSqlServerFormApp.Classes
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Image Picture { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
using System.Drawing;

namespace GetImageFromSqlServerFormApp.Classes
{
    public class PhotoContainer
    {
        public int Id { get; set; }
        public Image Picture { get; set; }
        public string FileName { get; set; }
    }
}
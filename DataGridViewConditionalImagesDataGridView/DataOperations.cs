using System.Collections.Generic;
using System.Drawing;

namespace DataGridViewConditionalImagesDataGridView
{
    public class DataOperations
    {
        public static List<Person> LoadPeople() =>
            new List<Person>
            {
                new Person() { FullName = "Jane Doe", Priority = 1 },
                new Person() { FullName = "Sam Jones", Priority = 3},
                new Person() { FullName = "May Wilson", Priority = 4},
                new Person() { FullName = "Kent Frank", Priority = 2}
            };

        public static Dictionary<int, Bitmap> Images() =>
            new Dictionary<int, Bitmap>
            {
                { 1, Properties.Resources._1 },
                { 2, Properties.Resources._2 },
                { 3, Properties.Resources._3 },
                { 4, Properties.Resources._4 }
            };
    }
}
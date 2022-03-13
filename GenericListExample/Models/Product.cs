namespace GenericListExample.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
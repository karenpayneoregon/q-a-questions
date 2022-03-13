namespace GenericListExample.Models
{
    public class Car : BaseModel
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public override string ToString() => Model;

    }
}
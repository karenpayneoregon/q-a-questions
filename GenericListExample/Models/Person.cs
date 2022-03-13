namespace GenericListExample.Models
{
    public class Person : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public override string ToString() => FullName;

    }
}

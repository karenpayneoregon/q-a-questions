
#nullable disable
namespace EntityDataExample.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OccupationIdentifier { get; set; }
        public int CountryIdentifier { get; set; }
        public string FullName => $"{FirstName} {LastName}"; public virtual Countries CountryIdentifierNavigation { get; set; }
        public virtual Occupation OccupationIdentifierNavigation { get; set; }
    }
}
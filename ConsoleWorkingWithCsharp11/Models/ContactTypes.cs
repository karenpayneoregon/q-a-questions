#nullable disable

namespace ConsoleWorkingWithCsharp11.Models;

public partial class ContactTypes
{
    public int Identifier { get; set; }
    public string ContactType { get; set; }
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();
    public override string ToString() => ContactType;

}
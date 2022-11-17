#nullable disable

namespace ConsoleWorkingWithCsharp11.Models;

public partial class Genders
{
    public int Id { get; set; }
    public string GenderType { get; set; }
    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();
    public override string ToString() => GenderType;

}
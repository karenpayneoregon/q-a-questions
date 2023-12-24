using PropertyChanged;

namespace FodyWinFormsApp.ForFodyModels;

#pragma warning disable CS8618
[AddINotifyPropertyChangedInterface]
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public override string ToString() => $"{FirstName} {LastName}";
}
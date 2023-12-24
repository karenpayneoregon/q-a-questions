using PropertyChanged;

namespace FodyWinFormsApp.ForFodyModels;

#pragma warning disable CS8618

[AddINotifyPropertyChangedInterface]
public class Person
{
    public Person() { }

    public Person(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // When this property changes the event below is triggered
    [OnChangedMethod(nameof(OnBirthDatePropertyChanged))]
    public DateOnly BirthDate { get; set; }
    public override string ToString() => $"{FirstName} {LastName}";

    private void OnBirthDatePropertyChanged(DateOnly oldValue, DateOnly newValue)
    {

    }
}
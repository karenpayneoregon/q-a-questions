namespace StackoverflowApp;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Score { get; set; }
    public override string ToString() => $"{FirstName} {LastName}";
}
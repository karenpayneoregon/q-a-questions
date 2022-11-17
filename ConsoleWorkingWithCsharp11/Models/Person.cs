namespace ConsoleWorkingWithCsharp11.Models;

/// <summary>
/// required modifier
/// </summary>
public class Person
{
    public required string FirstName { get; init; }
    public string MiddleName { get; set; }
    public required string LastName { get; init; }
    public string Email { get; init; }
}
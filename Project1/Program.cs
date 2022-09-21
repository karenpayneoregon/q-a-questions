namespace Project1;

internal class Program
{
    static void Main(string[] args)
    {
        Mocked.People().ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName}"));
        Console.ReadLine();
    }
}

internal class Mocked
{
    public static List<Person> People() =>
        new()
        {
            new () { Id = 1, FirstName = "Jim", LastName = "Smith" },
            new () { Id = 2, FirstName = "Mary", LastName = "Adams" },
            new () {Id = 3, FirstName = "Katrina", LastName = "Payne"}
        };
}

internal class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
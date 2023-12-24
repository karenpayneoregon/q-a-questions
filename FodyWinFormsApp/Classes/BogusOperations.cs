using Bogus;


namespace FodyWinFormsApp.Classes;
internal class BogusOperations
{
    public static List<M1.Person> FodyPeople(int count = 10) =>
        new Faker<M1.Person>()
            .RuleFor(c => c.FirstName, f => f.Person.FirstName)
            .RuleFor(c => c.LastName, f => f.Person.LastName)
            .RuleFor(c => c.BirthDate, f =>
                f.Date.BetweenDateOnly(new DateOnly(1999, 1, 1),
                    new DateOnly(2010, 1, 1)))
            .Generate(count);

    public static List<M2.Person> People(int count = 10) =>
        new Faker<M2.Person>()
            .RuleFor(c => c.FirstName, f => f.Person.FirstName)
            .RuleFor(c => c.LastName, f => f.Person.LastName)
            .RuleFor(c => c.BirthDate, f =>
                f.Date.BetweenDateOnly(new DateOnly(1999, 1, 1),
                    new DateOnly(2010, 1, 1)))
            .Generate(count);
}
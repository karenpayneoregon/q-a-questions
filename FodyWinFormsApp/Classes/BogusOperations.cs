using Bogus;
using Bogus.DataSets;


namespace FodyWinFormsApp.Classes;
internal class BogusOperations
{
    public static List<M1.Person> FodyPeople(int count = 10)
    {
        int identifier = 1;
        return new Faker<M1.Person>()
            .CustomInstantiator(f => new M1.Person(identifier++))
            .RuleFor(c => c.FirstName, f => f.Person.FirstName)
            .RuleFor(c => c.LastName, f => f.Person.LastName)
            .RuleFor(c => c.BirthDate, f =>
                f.Date.BetweenDateOnly(new DateOnly(1999, 1, 1),
                    new DateOnly(2010, 1, 1)))
            .Generate(count);
    }

    public static List<M2.Person> People(int count = 10)
    {
        int identifier = 1;
        return new Faker<M2.Person>()
            .CustomInstantiator(f => new M2.Person(identifier++))
            .RuleFor(c => c.FirstName, f => f.Person.FirstName)
            .RuleFor(c => c.LastName, f => f.Person.LastName)
            .RuleFor(c => c.BirthDate, f =>
                f.Date.BetweenDateOnly(new DateOnly(1999, 1, 1),
                    new DateOnly(2010, 1, 1)))
            .Generate(count);
    }
}
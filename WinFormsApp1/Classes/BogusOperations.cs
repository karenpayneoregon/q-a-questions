using Bogus;
using WinFormsApp1.Models;

namespace WinFormsApp1.Classes;

public class BogusOperations
{
    public static List<Student> MockedStudents(int count = 10)
    {
        Faker<Student> students = new Faker<Student>()
            .RuleFor(p =>
                p.FirstName, f => f.Person.FirstName)
            .RuleFor(p =>
                p.LastName, f => f.Person.LastName);


        return students.Generate(count);

    }
}
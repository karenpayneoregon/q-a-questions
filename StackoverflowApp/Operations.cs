namespace StackoverflowApp;

public class Operations
{
    public static List<Student> Students()
    {
        return new List<Student>()
        {
            new Student() {Id = 1, FirstName = "Jim", LastName = "Adams", Score = 87m},
            new Student() {Id = 2, FirstName = "Mary", LastName = "Jones", Score = 73m},
        };
    }
}
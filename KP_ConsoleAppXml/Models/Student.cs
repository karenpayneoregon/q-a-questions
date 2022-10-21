using Newtonsoft.Json;

namespace KP_ConsoleAppXml.Models;

public class StudentsData
{
    public Students Students { get; set; }
}

public class Students
{
    public Student[] Student { get; set; }
}

public class Student
{
    [JsonProperty("@Id")]
    public string Id { get; set; }

    [JsonProperty("@Name")]
    public string Name { get; set; }

    [JsonProperty("@Year")]
    public int Year { get; set; }

    [JsonProperty("SomeDate")]
    public DateTime BirthDate { get; set; }

    public bool Activated { get; set; }
}
using KP_ConsoleAppXml.Classes;
using KP_ConsoleAppXml.Models;

namespace KP_ConsoleAppXml;

internal partial class Program
{
    static void Main(string[] args)
    {
        StudentOperations.Example1();
        Console.ReadLine();
    }

    private static void EmployeeSingleTest()
    {
        Employee emp = new Employee()
        {
            EmployeeID = 1,
            FirstName = "Karen",
            LastName = "Payne",
            BirthDate = new DateTime(1956, 9, 24)
        };

        string xml = EmployeeOperations.EmployeeToXml(emp);
        string json = EmployeeOperations.EmployeeToJson(emp);
    }
}
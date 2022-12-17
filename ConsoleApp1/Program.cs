using System;

namespace ConsoleApp1;

internal partial class Program
{
    static void Main(string[] args)
    {
        //DateTime startDate = new(2022, 10, 1);
        //DateTime endDate = new(2022, 10, LastDayOfMonth);
        //DumpDates(endDate, startDate);

        //var demo = new StackOverFlow() {Environment = Environments.Development};
        //demo.SwitchExpression();
        //Console.WriteLine(demo.Precision);
        //demo.Environment = Environments.Test;
        //demo.SwitchExpression();
        //Console.WriteLine(demo.Precision);
        EnumDemo();
        Console.ReadLine();
    }

    private static void EnumDemo()
    {
        Priority result;

        Enum.TryParse("high", true, out Priority test);
        
        
        Enum.TryParse("High", out result);
        
        // Match using case-insensitive string comparison. We are also
        // using C# 7.0's parameter type inlining feature here.
        Enum.TryParse("low", true, out Priority result2);

        Console.WriteLine($"result: {result}");
        Console.WriteLine($"result2: {result2}");

        // Try find an enum that doesn't exist
        Console.WriteLine(Enum.TryParse("mid", out Priority result3)
            ? $"result3: {result3}"
            : "Could not find the specified enum item :(");
    }


    private static void DumpDates(DateTime endDate, DateTime startDate)
    {
        TimeSpan diff = endDate - startDate;
        int days = diff.Days;

        for (var index = 0; index <= days; index++)
        {
            var testDate = startDate.AddDays(index);
            switch (testDate)
            {
                case { DayOfWeek: DayOfWeek.Saturday }:
                case { DayOfWeek: DayOfWeek.Sunday }:
                    Console.WriteLine(testDate.ToShortDateString());
                    break;
            }
        }
    }

    private static int LastDayOfMonth =>
        DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
}

public enum Environments
{
    Production,
    Test,
    Development
}
public class StackOverFlow
{
    public int Precision = 0;
    public Environments Environment { get; set; }

    public void SwitchStatement()
    {
        switch (Environment)
        {
            case Environments.Production:
                Precision = 1;
                break;
            case Environments.Test:
                Precision = 2;
                break;
            case Environments.Development:
                Precision = 3;
                break;
        }
    }

    public void SwitchExpression()
    {
        Precision = Environment switch
        {
            Environments.Production => 1,
            Environments.Test => 2,
            Environments.Development => 3
        };

    }
}
enum Priority
{
    High = 1,
    Medium = 2,
    Low = 3
}
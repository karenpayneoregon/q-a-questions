using System;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        //DateTime startDate = new(2022, 10, 1);
        //DateTime endDate = new(2022, 10, LastDayOfMonth);
        //DumpDates(endDate, startDate);

        var demo = new StackOverFlow() {Environment = Environments.Development};
        demo.SwitchExpression();
        Console.WriteLine(demo.Precision);
        demo.Environment = Environments.Test;
        demo.SwitchExpression();
        Console.WriteLine(demo.Precision);

        Console.ReadLine();
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

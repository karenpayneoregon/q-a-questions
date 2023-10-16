using FiniteStateMachine.Classes;

namespace FiniteStateMachine;

internal partial class Program
{
    static void Main(string[] args)
    {
        NewMethod();


        Console.ReadLine();
    }

    private static void Method1()
    {
        var items = (File.ReadAllLines("TextFile3.txt")
            .Select((line, index) => new { Line = line, Index = index })
            .Select(lineData => lineData)).ToList();

        List<string> sections = new List<string>()
        {
            "INFO",
            "PANEL_INSP_RESULT",
            "BOARD_INSP_RESULT",
            "COMPONENT_INSP_RESULT"
        };

        foreach (var section in sections)
        {
            Console.WriteLine($"{section}");
            var startItem = items.FirstOrDefault(x => x.Line == $"[{section}]");
            var endItem = items.FirstOrDefault(x => x.Line == $"[{section}_END]");
            if (startItem is not null && endItem is not null)
            {
                bool header = false;
                for (int index = startItem.Index + 1; index < endItem.Index; index++)
                {
                    if (header == false)
                    {
                        Console.WriteLine($"\t{items[index].Line}");
                        header = true;
                    }
                    else
                    {
                        Console.WriteLine($"\t\t{items[index].Line}");
                    }
                }
            }
            else
            {
                Console.WriteLine("\tFailed to read this section");
            }
        }
    }

    private static void NewMethod()
    {
        List<double> list = new();

        string[] exceptions = { "Sig1", "Sig2" };

        foreach (var line in Helpers.StateReader(@"TextFile2.txt"))
        {
            if (exceptions.Contains(line)) continue;

            var parts = line.Split(' ');
            if (parts.Length < 10)
            {
                continue;
            }

            if (double.TryParse(parts[9], out var value))
            {
                list.Add(value);
            }
            else
            {
                // failed to convert
            }
        }

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
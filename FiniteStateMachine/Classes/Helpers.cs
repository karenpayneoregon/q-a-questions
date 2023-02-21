#pragma warning disable IDE0059

namespace FiniteStateMachine.Classes;

[SuppressMessage("ReSharper", "TooWideLocalVariableScope"), 
 SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
public class Helpers
{
    public static IEnumerable<string> StateReader(string fileName)
    {
        bool isMarker = false;
        var lines = File.ReadLines(fileName).ToList();
        foreach (string line in lines)
        {
            isMarker = true;
            if (line.StartsWith("============>"))
            {
                isMarker = !isMarker;
            }
            else if (isMarker)
            {
                yield return line;
            }
        }
    }

    public static IEnumerable<string> Reader(string fileName)
    {
        bool inRead = false;
        var lines = File.ReadLines(fileName).ToList();
        foreach (string line in lines)
        {
            inRead = true;
            if (string.Equals(line, "(Read)"))
            {
                inRead = !inRead;
            }
            else if (inRead)
            {
                yield return line;
            }
        }
    }

    public static IEnumerable<string> Reader(string fileName, string startToken, string endToken)
    {
        bool inRead = false;
        var lines = File.ReadLines(fileName).ToList();
        foreach (string line in lines)
        {
            inRead = true;
            if (string.Equals(line, startToken) || string.Equals(line, endToken))
            {
                inRead = !inRead;
            }
            else if (inRead)
            {
                yield return line;
            }
        }
    }
}

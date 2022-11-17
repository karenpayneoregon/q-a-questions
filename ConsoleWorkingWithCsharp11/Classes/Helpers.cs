using System.Numerics;

namespace ConsoleWorkingWithCsharp11.Classes;

public class Helpers
{
    public static  T Sum<T>(T[] values) where T : INumber<T>
    {

        T result = T.Zero;

        foreach (var value in values)
        {
            result += value;
        }

        return result;
    }

    public static T Add<T>(T left, T right) where T : INumber<T>
    {
        return left + right;
    }
}
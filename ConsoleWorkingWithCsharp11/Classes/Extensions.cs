namespace ConsoleWorkingWithCsharp11.Classes;

public static class Extensions
{
    public static int CheckSwitch(this int[] sender) => sender switch
        {
            [1, 2, .., 10] => 1,
            [1, 2] => 2,
            [1, _] => 3,
            [1, ..] => 4,
            [..] => 50
        };
}
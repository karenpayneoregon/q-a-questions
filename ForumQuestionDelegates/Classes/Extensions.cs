namespace ForumQuestionDelegates.Classes;
internal static class Extensions
{
    public static bool IsEven(this int sender) => sender % 2 == 0;
    public static bool IsOdd(this int sender) => !IsEven(sender);
}
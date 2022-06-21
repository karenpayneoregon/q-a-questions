using System;

namespace StackoverflowQuestion.Classes
{
    public static class Extensions
    {
        public static bool IgnoreCaseEquals(this string sender, string other)
            => string.Equals(sender, other, StringComparison.OrdinalIgnoreCase);

    }
}
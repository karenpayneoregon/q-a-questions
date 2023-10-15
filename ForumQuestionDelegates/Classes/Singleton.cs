namespace ForumQuestionDelegates.Classes;

public sealed class Singleton
{
    private static readonly Lazy<Singleton> Lazy = new(() => new Singleton());
    public static Singleton Instance => Lazy.Value;
    public int Value { get; set; }
}
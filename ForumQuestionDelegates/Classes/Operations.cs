namespace ForumQuestionDelegates.Classes;
internal class Operations
{
    public delegate void OnChangeColors(Color color);
    public static event OnChangeColors? ColorsChanged;

    public static void Decide()
    {
        ColorsChanged?.Invoke(Singleton.Instance.Value.IsOdd() ?
            Color.Red : 
            Color.DodgerBlue);
    }

    public static void DoSomeWork()
    {
        Decide();
    }
}
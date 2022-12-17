namespace HidePathInExceptions.Classes;

public readonly struct Range
{

    public DateTime Start { get;  }

    public DateTime End => Start.AddDays(6);

    public Range(DateTime start)
    {
        Start = start;
    }

}
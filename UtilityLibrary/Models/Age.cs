

namespace UtilityLibrary.Models;

public class Age
{
    public int Years { get; set; }
    public int Months { get; set; }
    public int Days { get; set; }
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public int Milliseconds { get; set; }
    /// <summary>
    /// Date to calculate off of a later date
    /// </summary>
    public DateTime From { get; set; }
    /// <summary>
    /// Date to calculate off a earlier date
    /// </summary>
    public DateTime To { get; set; }

    /// <summary>
    /// No logic if any member is 0
    /// </summary>
    public string Full(string text = "Posted ")
        => $"{text}" +
           $"{Years} years " +
           $"{Months} months " +
           $"{Days} days " +
           $"{Hours} hours " +
           $"{Minutes} minutes " +
           $"{Seconds} ago";

    public string Posted()
    {
        var data = 
            $"{Years} years " + 
            $"{Months} months " + 
            $"{Days} days " + 
            $"{Hours} hours " + 
            $"{Minutes} minutes " + 
            $"{Seconds} seconds ago";

        return data
            .Replace("0 years", "")
            .Replace("0 months", "")
            .Replace("0 days", "")
            .Replace("0 hours", "")
            .Replace("0 minutes", "")
            .TrimStart();
    }


    /// <summary>
    /// No logic for 0 on time portions
    /// </summary>
    public override string ToString()
    {
        if (Years > 0 && Months > 0 && Days > 0)
        {
            return $"{Years} years {Months} months {Days} days ago";
        }
        else if (Months > 0 && Days > 0)
        {
            return $"{Months} months {Days} days ago";
        }
        else if (Days > 0)
        {
            return $"{Days} days ago";
        }
        else
        {
            return "";
        }
    }
}
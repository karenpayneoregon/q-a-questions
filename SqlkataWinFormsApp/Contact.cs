using RecordApp.Models;

namespace SqlkataWinFormsApp;

public class Contact
{
    public int ContactId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ContactTypeIdentifier { get; set; }
    public string ContactTitle { get; set; }
}
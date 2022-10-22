using MenuVeryBasic.Models;

namespace KP_ConsoleAppJokes.Classes;

class MenuOperations
{
    /// <summary>
    /// Create main menu
    /// </summary>
    public static SelectionPrompt<MenuItem> SelectionPrompt()
    {
        SelectionPrompt<MenuItem> menu = new()
        {
            HighlightStyle = new Style(Color.Black, Color.White, Decoration.None)
        };

        menu.Title("[cyan]Select a option[/]");
        menu.AddChoices(new List<MenuItem>()
        {
            new () {Id = 1, Text = "Chuck joke",  
                Action = ChuckJokes.Execute },
            new () {Id = 2, Text = "Joke", 
                Action = RandomJokes.Execute },
            new () {Id = -1,Text = "Exit"},
        });

        return menu;

    }
}
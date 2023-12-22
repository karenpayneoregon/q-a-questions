namespace ChristmasTree.Classes;
internal class Prompts
{
    public static T GetNumber<T>(string text, T value) =>
        AnsiConsole.Prompt(
            new TextPrompt<T>($"[white]{text}[/]?")
                .PromptStyle("yellow")
                .DefaultValue(value)
                .ValidationErrorMessage("[red]Please enter salary (numbers only)[/]"));
}

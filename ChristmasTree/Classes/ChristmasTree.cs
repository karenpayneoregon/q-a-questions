namespace ChristmasTree.Classes;
public class ChristmasTree
{
    public static async Task InputTreeSize()
    {
        Console.CursorVisible = true;
        const string question = "Enter the number of tree branches or 0 to exit: ";
        Console.Clear();
        
        AnsiConsole.MarkupLine("[yellow]Build a Christmas tree, don't get silly and enter a gazillion branches[/]");
        int numberOfBranches = Prompts.GetNumber<int>(question,5);
        if (numberOfBranches == 0)
        {
            return;
        }
        Console.CursorVisible = false;
        await DrawTree(numberOfBranches);
    }
    private static async Task DrawTree(int branches)
    {
        int delay = 250;

        int starSpaceCount = branches * 2 - 1;
        if (branches == 1)
        {
            starSpaceCount = 2;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        var starSpace = new string(' ', starSpaceCount);
        
        await Task.Delay(delay);

        Console.WriteLine("{0}{1}☼{0}{1}▲", Environment.NewLine, starSpace);
        Console.ResetColor();


        for (int index = 0; index < branches; index++)
        {
            string slash = "/";
            string backslash = "\\";

            for (int j = 0; j <= index + 1; j++)
            {
                int leavesSpaceCount = branches * 2 - 2 - j;

                if (branches == 1)
                {
                    leavesSpaceCount = 1 - j;
                }

                int leavesSpaceBetweenCount = j * 2 + 1;

                if (index > 1)
                {
                    leavesSpaceCount -= (index - 1);
                    leavesSpaceBetweenCount = leavesSpaceBetweenCount + (index - 2) * 2 + 2;
                }

                string leavesSpace = new(' ', leavesSpaceCount);
                string leavesSpaceBetween = new('_', leavesSpaceBetweenCount);
                if (j < index + 1)
                {
                    leavesSpaceBetween = new(' ', leavesSpaceBetweenCount);
                }
                else if (index < branches - 1)
                {
                    if (index == 0)
                    {
                        leavesSpaceBetween = "_ _";
                    }
                    else
                    {
                        leavesSpaceBetween = new string('_', index) + new string(' ', index * 2 + 1) + new string('_', index);
                    }
                }

                var leavesSpaceBetweenChar = leavesSpaceBetween.ToCharArray();
                Random random = new();
                for (int k = 0; k < leavesSpaceBetweenChar.Length; k++)
                {
                    int randomInt = random.Next(leavesSpaceBetweenChar.Length);
                    bool randomBauble = random.Next(100) <= 3 ? true : false;

                    if (randomBauble == true || k == randomInt)
                    {
                        if (leavesSpaceBetweenChar[randomInt] != '_')
                        {
                            leavesSpaceBetweenChar[randomInt] = 'o';
                        }
                    }
                }

                await Task.Delay(delay);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(leavesSpace);
                Console.Write(slash);

                foreach (char bauble in leavesSpaceBetweenChar)
                {
                    if (bauble == 'o')
                    {
                        Console.ForegroundColor = (ConsoleColor)random.Next(9, 15);
                        Console.Write(bauble);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else
                    {
                        Console.Write(bauble);
                    }
                }
                Console.Write(backslash);
                Console.WriteLine();
                Console.ResetColor();
            }

        }

        int logSpaceCount = branches + 1;

        if (branches < 4)
        {
            logSpaceCount = branches + 1;
        }
        else if (branches < 6)
        {
            logSpaceCount = branches + 2;
        }
        else
        {
            logSpaceCount = branches * 2 - 3;
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;
        string logSpace = new(' ', logSpaceCount);

        await Task.Delay(delay);

        switch (branches)
        {
            case 1:
                Console.WriteLine("{1}║", Environment.NewLine, logSpace);
                break;
            case 2:
                Console.WriteLine("{1}║{0}{1}║", Environment.NewLine, logSpace);
                break;
            case 3:
                Console.WriteLine("{1}║ ║{0}{1}╚═╝", Environment.NewLine, logSpace);
                break;
            case 4:
                Console.WriteLine("{1}║ ║{0}{1}║ ║{0}{1}╚═╝", Environment.NewLine, logSpace);
                break;
            case 5:
                Console.WriteLine("{1}║   ║{0}{1}║   ║{0}{1}╚═══╝", Environment.NewLine, logSpace);
                break;
            default:
                Console.WriteLine("{1}║   ║{0}{1}║   ║{0}{1}║   ║{0}{1}╚═══╝", Environment.NewLine, logSpace);
                break;
        }

        Console.ResetColor();

        await Task.Delay(delay);
        SpectreConsoleHelpers.ContinuePrompt();

        await InputTreeSize();

    }
}

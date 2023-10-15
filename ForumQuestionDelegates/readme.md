# About

Demonstrates how to update a label foreground color based on an event which assigns a color based on an int value setup in a singleton class.

This class provides storage for an int value which provides global access anywhere in this project.

> **Note**
> A developer should never access, in this case a form control directly from another class which is why in this code sample we use an event rather than directly accessing in this case a label.

```csharp
public sealed class Singleton
{
    private static readonly Lazy<Singleton> Lazy = new(() => new Singleton());
    public static Singleton Instance => Lazy.Value;
    public int Value { get; set; }
}
```

Dummy class

- delegate OnChangeColors is a signature for the event OnChangeColors
- Decide method invokes OnChangeColors, passes a color based on if the Value property of the Singleton class is odd or even.

```csharp
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
```

Form code

- In the form constructor we subscibe to the event Operations.ColorsChanged
- Operations_ColorsChanged passes a color and assigns it to to the label.
- UpdateValueButton_Click updates the Value property followed by invoking DoSomeWork which in turn determines the color for the label and the label is updated in Operations_ColorsChanged.

```csharp
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Operations.ColorsChanged += Operations_ColorsChanged;
    }

    private void Operations_ColorsChanged(Color color)
    {
        label1.ForeColor = color;
    }

    private void UpdateValueButton_Click(object sender, EventArgs e)
    {
        Singleton.Instance.Value += 1;
        Operations.DoSomeWork();
        label2.Text = $@"Singleton value is {Singleton.Instance.Value}";
    }
}
```

## Notes

- See the following [Microsoft docs page](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-subscribe-to-and-unsubscribe-from-events#to-subscribe-to-events-programmatically) for subscribing to events.
- The singleton pattern is one of the best-known patterns in software engineering. Essentially, a singleton is a class which only allows a single instance of itself to be created, and usually gives simple access to that instance.
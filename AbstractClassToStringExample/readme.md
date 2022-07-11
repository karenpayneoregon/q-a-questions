# About

Example for having the ability to work with one data set with two override ToString

Here we set the default ToString

```csharp
public abstract class BaseContainer
{
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public override string ToString() => Name;
}
```

Load data via this model to use the ToString method above

```csharp
public class MachineCombo1 : BaseContainer
{

}
```

Then for the other override the base class ToString.

```csharp
public class MachineCombo2 : BaseContainer
{
    public override string ToString() => SerialNumber;
}
```
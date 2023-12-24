# About

When working with a DataGridView with a DataTable as the data source there is change notification built-in while when working with classes/models with controls a developer must implement INotifyPropertyChanged or use a third-party library like PostScript (a paid for library) or Fody.

This project shows conventional INotifyPropertyChanged and Fody for implementation of property change notification.

> **Note**
> That for controls such as ComboBox and ListBox where the underlying data may change, consider not using a DataTable but instead the same methods used for this code sample by replacing the DataGridView with a ComboBox or ListBox which works same as the DataGridView as the first iteration of this project used ListBox controls.


## Overview

Examples for conventional property change notification using [INotifyPropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-8.0) and [PropertyChanged.Fody](https://www.nuget.org/packages/PropertyChanged.Fody/4.1.0?_src=template).


## Writen with

NET8 and Visual Studio 2022


## PropertyChanged.Fody

Below are very basic usage, see the [docs](https://github.com/Fody/PropertyChanged) for more usages.

1. Add [Fody](https://www.nuget.org/packages/Fody/6.8.0?_src=template) package
1. Add [PropertyChanged.Fody](https://www.nuget.org/packages/PropertyChanged.Fody/4.1.0?_src=template) package
1. Add FodyWeavers.xml file at the root of the project.

```xml
<?xml version="1.0" encoding="utf-8"?>
<Weavers xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:noNamespaceSchemaLocation="FodyWeavers.xsd">
	<PropertyChanged />
</Weavers>
```

4. Add [[AddINotifyPropertyChangedInterface]](https://github.com/Fody/PropertyChanged/wiki/Attributes) attribute to the class for change notification.

```csharp
[AddINotifyPropertyChangedInterface]
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public override string ToString() => $"{FirstName} {LastName}";
}
```

## Conventional INotifyPropertyChanged

Simply follow the model below.



```csharp
public class Person : INotifyPropertyChanged
{
    private string _firstName;
    private string _lastName;
    private DateOnly _birthDate;

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (value == _firstName) return;
            _firstName = value;
            OnPropertyChanged();
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (value == _lastName) return;
            _lastName = value;
            OnPropertyChanged();
        }
    }

    public DateOnly BirthDate
    {
        get => _birthDate;
        set
        {
            if (value.Equals(_birthDate)) return;
            _birthDate = value;
            OnPropertyChanged();
        }
    }

    public override string ToString() => $"{FirstName} {LastName}";

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```

If ReSharper is installed, add `: INotifyPropertyChanged` to the model followed by 

```csharp
public event PropertyChangedEventHandler? PropertyChanged;
protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
{
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
```

Select a single property, right click and ReSharper will implement property change for all properties or do each property one by one.
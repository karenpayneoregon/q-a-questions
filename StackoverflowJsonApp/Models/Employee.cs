using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StackoverflowJsonApp.Models;

public class Employee : INotifyPropertyChanged
{
    private int _id;
    private string _name;
    private string _surname;
    private int _age;
    private int _salary;
    private string _position;

    public int ID
    {
        get => _id;
        set
        {
            if (value == _id) return;
            _id = value;
            OnPropertyChanged();
            OnPropertyChanged();
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            if (value == _name) return;
            _name = value;
            OnPropertyChanged();
            OnPropertyChanged();
        }
    }

    public string Surname
    {
        get => _surname;
        set
        {
            if (value == _surname) return;
            _surname = value;
            OnPropertyChanged();
            OnPropertyChanged();
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value == _age) return;
            _age = value;
            OnPropertyChanged();
            OnPropertyChanged();
        }
    }

    public int Salary
    {
        get => _salary;
        set
        {
            if (value == _salary) return;
            _salary = value;
            OnPropertyChanged();
        }
    }

    public string Position
    {
        get => _position;
        set
        {
            if (value == _position) return;
            _position = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null!)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

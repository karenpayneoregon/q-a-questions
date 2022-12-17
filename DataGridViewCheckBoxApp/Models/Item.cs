using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataGridViewCheckBoxApp.Models;

public class Item : INotifyPropertyChanged
{
    private bool _selected;
    private string _description;


    public bool Selected
    {
        get => _selected;
        set
        {
            _selected = value;
            OnPropertyChanged();
        }
    }

    public int Id { get; set; }
    public string Description
    {
        get => _description;
        set
        {
            _description = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
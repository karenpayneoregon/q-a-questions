using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinFormsAppKarenVersion.Classes;

public class Model : INotifyPropertyChanged
{
    private double? _doubleValue;

    public double? DoubleValue
    {
        get => _doubleValue;
        set
        {
            _doubleValue = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}


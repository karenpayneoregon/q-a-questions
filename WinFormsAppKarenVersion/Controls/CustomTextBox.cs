using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace WinFormsAppKarenVersion.Controls;

public class CustomTextBox : TextBox, INotifyPropertyChanged
{
    public delegate void ValueChanged(double value);
    public event ValueChanged OnValueChanged = null!;

    private double _doubleValue;

    public double Value
    {
        get => _doubleValue;
        set
        {
            _doubleValue = value;
            OnPropertyChanged();
        }
    }

    [Category("Custom")]
    [Description("Override value for WatchValue")]
    public double OverRideValue { get; set; }

    [Category("Custom")]
    [Description("Value to watch and change")]
    public double WatchValue { get; set; }

    protected override void OnTextChanged(EventArgs e)
    {
        if (double.TryParse(Text, out var value))
        {
            if (value == WatchValue)
            {
                Text = OverRideValue.ToString(CultureInfo.InvariantCulture);
                OnValueChanged?.Invoke(30);
            }
            else
            {
                OnValueChanged?.Invoke(value);
            }
        }
        base.OnTextChanged(e);
    }
        
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null!)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
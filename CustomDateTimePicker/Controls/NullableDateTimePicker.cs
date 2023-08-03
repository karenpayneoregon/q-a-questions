using System.ComponentModel;
#pragma warning disable CS8618

namespace CustomDateTimePicker.Controls;
public class NullableDateTimePicker : DateTimePicker
{
    private DateTimePickerFormat _originalFormat = 
        DateTimePickerFormat.Short;

    private string _originalCustomFormat;
    private bool _isNull;

    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
    public new DateTime Value
    {
        get => _isNull ? DateTime.MinValue : base.Value;
        set
        {
            // incoming value is set to min date
            if (value == DateTime.MinValue)
            {
                // if set to min and not previously null,
                // preserve original formatting
                if (!_isNull)
                {
                    _originalFormat = Format;
                    _originalCustomFormat = CustomFormat!;
                    _isNull = true;
                }

                Format = DateTimePickerFormat.Custom;
                CustomFormat = " ";
            }
            else // incoming value is real date
            {
                // if set to real date and previously null,
                // restore original formatting
                if (_isNull)
                {
                    Format = _originalFormat;
                    CustomFormat = _originalCustomFormat;
                    _isNull = false;
                }

                base.Value = value;
            }
        }
    }

    protected override void OnCloseUp(EventArgs eventArgs)
    {
        // on keyboard close, restore format
        if (MouseButtons == MouseButtons.None)
        {
            if (_isNull)
            {
                Format = _originalFormat;
                CustomFormat = _originalCustomFormat;
                _isNull = false;
            }
        }

        base.OnCloseUp(eventArgs);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        // on delete key press, set to min value (null)
        if (e.KeyCode == Keys.Delete)
        {
            Value = DateTime.MinValue;
        }

        if (e.KeyCode == Keys.Insert)
        {
            Value = DateTime;
        }

    }
    [Category("Behavior")]
    [Description("Default value for restoring value")]
    public DateTime DateTime { get; set; }
    /// <summary>
    /// Indicates if Value has a date or not
    /// </summary>
    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsNullValue => Value == DateTime.MinValue;
}

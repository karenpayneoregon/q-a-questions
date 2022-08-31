using WinFormsAppKarenVersion.Classes;

namespace WinFormsAppKarenVersion;

public partial class Form1 : Form
{
    Model _model;
    readonly BindingSource _bindingSource = new ();
    public Form1()
    {
        InitializeComponent();
    }

    private void CurrentButton_Click(object sender, EventArgs e)
    {
        if (_bindingSource.Current is not null)
        {
            MessageBox.Show($@"{((Model)_bindingSource.Current).DoubleValue}");
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _model = new Model { DoubleValue = 40 };

        _bindingSource.DataSource = _model;

        SomeTextBox.Text = "40";
        SomeTextBox.DataBindings.Add("Text", _bindingSource, nameof(Model.DoubleValue));
        SomeTextBox.OnValueChanged += OnOnValueChanged;
        ActiveControl = SomeTextBox;
        SelectEndOfTextBox();
    }

    private void OnOnValueChanged(double value)
    {
        ((Model)_bindingSource.Current).DoubleValue = value;
        SelectEndOfTextBox();
    }

    private void SelectEndOfTextBox()
    {
        SomeTextBox.SelectionStart = SomeTextBox.Text.Length;
        SomeTextBox.SelectionLength = 0;
    }
}
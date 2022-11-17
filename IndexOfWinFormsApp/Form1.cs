

namespace IndexOfWinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void FindButton_Click(object sender, EventArgs e)
    {

        cmbAnimals.Items.AddRange(new object[]{"dog", "cat", "Horse"});

        var result = cmbAnimals
            .Items
            .Cast<string>().Select((item, index) 
                => new { Text = item.Trim(), Index = index })
            .FirstOrDefault(x => 
                string.Equals(x.Text, tbAnimal.Text, 
                    StringComparison.CurrentCultureIgnoreCase));

        if (result is not null)
        {
            cmbAnimals.SelectedIndex = result.Index;
            MessageBox.Show($@"{tbAnimal.Text} was located case insensitive at index {result.Index}");
        }
        else
        {
            MessageBox.Show($@"{tbAnimal.Text} not located");
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        var result = await Task.Run(SomeService.DoNothingMethod);

    }

    private void GetCheckedRadioButton_Click(object sender, EventArgs e)
    {
        var rb = this.RadioButtonChecked();

        if (rb is not null)
        {
            MessageBox.Show(rb.GetColor());
        }
        else
        {
            MessageBox.Show("Make a selection");
        }
    }
}

internal class SomeService
{
    public static async Task<int> DoNothingMethod()
    {
        // Tons of work to do in here!
        for (int index = 0; index != 10000000; ++index)
            await Task.Delay(500);
        return 42;
    }
}
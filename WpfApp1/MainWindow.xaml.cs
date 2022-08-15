using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Classes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        readonly MyUserSettings _userSettings = new();
        public MainWindow()
        {
            InitializeComponent();
            
            Option1RadioButton.Checked += Option1RadioButtonOnChecked;
            Option2RadioButton.Checked += Option1RadioButtonOnChecked;


            var radioButtonName = _userSettings.SelectedRadioButton;
            if (!string.IsNullOrWhiteSpace(radioButtonName))
            {
                MainGrid.Children.OfType<RadioButton>().FirstOrDefault(x => x.Name == radioButtonName).IsChecked = true;
            }

        }

        private void Option1RadioButtonOnChecked(object sender, RoutedEventArgs e)
        {
            _userSettings.SelectedRadioButton = ((sender as RadioButton)!).Name;
            _userSettings.Save();
        }

        private void SelectionButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton checkedValue = MainGrid.Children.OfType<RadioButton>()
                .FirstOrDefault(r => r.IsChecked.HasValue && r.IsChecked.Value);

            MessageBox.Show(checkedValue is null ? "Nothing selected" : $"Selected: {checkedValue.Name}");
        }
    }
}

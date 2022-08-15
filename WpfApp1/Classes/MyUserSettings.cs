using System.Configuration;
using System.Windows.Controls;

namespace WpfApp1.Classes
{
    /// <summary>
    /// This could had been done in the designer
    /// </summary>
    public class MyUserSettings : ApplicationSettingsBase
    {

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string SelectedRadioButton
        {
            get => this[nameof(SelectedRadioButton)] as string;
            set => this[nameof(SelectedRadioButton)] = value;
        }

    }
}
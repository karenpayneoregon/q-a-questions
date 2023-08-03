using System.Diagnostics;
using WinFormsApp1.Classes;

namespace WinFormsApp1;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.TextBoxList().ForEach(tb => 
            tb.Click += delegate (object tb, EventArgs args) {
            Debug.WriteLine(((TextBox)tb).Name);
        });
    }
}

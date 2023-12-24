using System.ComponentModel;
using FodyWinFormsApp.Classes;

namespace FodyWinFormsApp;

/// <summary>
/// When updating a current item, the item is updated in both the DataGridView and ComboBox.
/// </summary>
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private SortableBindingList<M1.Person> FodyBindingList = new(BogusOperations.FodyPeople());
    private BindingSource FodyBindingSource = new();

    private SortableBindingList<M2.Person> ConventionalBindingList = new(BogusOperations.People());
    private BindingSource ConventionalBindingSource = new();

    private void Form1_Shown(object? sender, EventArgs e)
    {
        FodyBindingSource.DataSource = FodyBindingList;
        FodyDataGridView.DataSource = FodyBindingSource;
        FodyDataGridView.Columns["Id"].Visible = false;
        FodyDataGridView.FixHeaders();

        FodyComboBox.DataSource = FodyBindingSource;

        ConventionalBindingSource.DataSource = ConventionalBindingList;
        ConventionalDataGridView.DataSource = ConventionalBindingSource;
        ConventionalDataGridView.Columns["Id"].Visible = false;
        ConventionalDataGridView.FixHeaders();

        ConventionalComboBox.DataSource = ConventionalBindingSource;
    }

    private void FodyChangeCurrentBButton_Click(object sender, EventArgs e)
    {
        M1.Person person = FodyBindingList[FodyBindingSource.Position];
        person.FirstName = "Karen";
        person.LastName = "Payne";
        person.BirthDate = new DateOnly(1990, 12, 1);

    }

    private void ConventionalChangeCurrentBButton_Click(object sender, EventArgs e)
    {
        M2.Person person = ConventionalBindingList[ConventionalBindingSource.Position];
        person.FirstName = "Jill";
        person.LastName = "Smith";
        person.BirthDate = new DateOnly(1980, 9, 1);
    }
}

using System.ComponentModel;
using FodyWinFormsApp.Classes;

namespace FodyWinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private BindingList<M1.Person> FodyBindingList = new(BogusOperations.FodyPeople());
    private BindingSource FodyBindingSource = new();

    private BindingList<M2.Person> ConventionalBindingList = new(BogusOperations.People());
    private BindingSource ConventionalBindingSource = new();

    private void Form1_Shown(object? sender, EventArgs e)
    {
        FodyBindingSource.DataSource = FodyBindingList;
        FodyDataGridView.DataSource = FodyBindingSource;

        ConventionalBindingSource.DataSource = ConventionalBindingList;
        ConventionalDataGridView.DataSource = ConventionalBindingSource;

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleDelegateEventAction.Classes;
using SimpleDelegateEventAction.Extensions;

namespace SimpleDelegateEventAction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Operations.ErrorHandler += OnErrorHandler;
            Operations.Progress += OperationsOnProgress;
            Operations.OnAddItem += OnOnAddItem;
            Dialogs.ContinueOperation += DialogsOnContinueOperation;
        }

        private void DialogsOnContinueOperation(bool sender)
        {
            Dialogs.Information(this, $"Continue: {sender.ToYesNoString()} ");
        }

        private void OnOnAddItem(string item)
        {
            label1.Text = item;
        }

        private void OperationsOnProgress(int sender)
        {
            listBox1.Items.Add($"{sender:D2}");
        }

        private void OnErrorHandler(Exception sender)
        {
            listBox1.Items.Add(sender.Message);
        }

        private void ProgressErrorButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Operations.InvokeError();
        }

        private async void ActionAsyncButton_Click(object sender, EventArgs e)
        {
            await Operations.Load(12);
        }

        private void ActionsButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Sum of two strings: {ActionClass.SumCharacters("Anne", "Jeffery")}");
            ActionClass.HelloFunction2();
            ActionClass.GoodbyeFunction2();
            ActionClass.GreetingsAction("Karen Payne");
        }

        private void QuestionDialogButton_Click(object sender, EventArgs e)
        {
            Dialogs.Question(this,"Head", YesMethod, NoMethod);
        }
        public void YesMethod()
        {
            Debug.WriteLine(nameof(YesMethod));
        }
        public void NoMethod()
        {
            Debug.WriteLine(nameof(NoMethod));
        }

        private void AutoCloseButton_Click(object sender, EventArgs e)
        {
            Dialogs.AutoClosingTaskDialog(this, Properties.Resources.Timer_16x);
        }
    }


}

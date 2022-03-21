using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDelegateEventAction.Classes
{
    public class Dialogs
    {
        public delegate void OnContinue(bool sender);

        public static event OnContinue ContinueOperation;

        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesAction">Action to perform when Yes is clicked</param>
        /// <param name="noAction">Action to perform when No is clicked</param>
        /// <returns>true for yes button, false for no button</returns>
        /// <remarks>
        /// Dialogs.Question(this, "Ask something", YesMethod, NoMethod);
        /// </remarks>
        public static void Question(Control owner, string heading, Action yesAction, Action noAction)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection
            {
                yesButton,
                noButton
            };


            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Footnote = new TaskDialogFootnote() { Text = "Karen Payne did this" },
                Icon = new TaskDialogIcon(Properties.Resources.QuestionBlue),
                Buttons = buttons
            };

            var result = TaskDialog.ShowDialog(owner, page);

            if ((DialogResult)result.Tag == DialogResult.Yes)
            {
                yesAction?.Invoke();
            }
            else
            {
                noAction?.Invoke();
            }

        }

        /// <summary>
        /// Mocked example for showing a auto-close dialog which by passing the parent control
        /// will be default display this dialog centered on the parent control.
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="Icon">Icon to display in dialog</param>
        public static void AutoClosingTaskDialog(Control owner, Icon Icon)
        {

            const string textFormat = "Closing in {0} seconds...";
            var remainingTenthSeconds = 50;

            TaskDialogButton continueButton = new("Just do it");
            TaskDialogButton cancelButton = TaskDialogButton.Cancel;

            // Display the form's icon in the task dialog.
            // Note however that the task dialog will not scale the icon.
            TaskDialogPage page = new()
            {
                Heading = "Continuing with next process...",
                Text = string.Format(textFormat, (remainingTenthSeconds + 9) / 10),
                Icon = new TaskDialogIcon(Icon),
                ProgressBar = new TaskDialogProgressBar() { State = TaskDialogProgressBarState.Paused },
                Buttons = new TaskDialogButtonCollection() { continueButton, cancelButton },
                Caption = "Auto-close"
            };

            using Timer timer = new()
            {
                Enabled = true,
                Interval = 100
            };

            timer.Tick += (_, _) =>
            {
                remainingTenthSeconds -= 1;

                if (remainingTenthSeconds > 0)
                {
                    page.Text = string.Format(textFormat, (remainingTenthSeconds + 9) / 10);
                    page.ProgressBar.Value = 100 - remainingTenthSeconds * 2;
                }
                else
                {
                    timer.Enabled = false;

                    if (continueButton.BoundPage is not null)
                    {
                        continueButton.PerformClick();
                    }
                }
            };

            TaskDialogButton result = TaskDialog.ShowDialog(owner, page);

            ContinueOperation?.Invoke(result == continueButton);
        }

        /// <summary>
        /// displays a message with option to assign button text
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading"></param>
        /// <param name="buttonText"></param>
        public static void Information(Control owner, string heading, string buttonText = "Ok")
        {

            TaskDialogButton okayButton = new(buttonText);

            TaskDialogPage page = new()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = heading,
                Icon = TaskDialogIcon.Warning,
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };

            TaskDialog.ShowDialog(owner, page);


        }
    }
}

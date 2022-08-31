#nullable disable
using System.Diagnostics;
using System.Text;
using Bogus;
using Bogus.Extensions;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private List<TextBox> _textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Faker<LineItem> faker = new Faker<LineItem>()
                .RuleFor(item => item.Value, f => f.Random.String2(1, 100));

            var result = faker.Generate(1000);

            StringBuilder builder = new ();

            foreach (var item in result)
            {
                builder.Append(item);
            }

            File.WriteAllText("Dump.txt", builder.ToString());
        }


    }

public class LineItem
{
    public string Value { get; set; }
    public override string ToString() => Value;
}

    public static class Extensions
    {
        public static bool AllInt(this string[] sender) =>
            sender.SelectMany(item => item.ToCharArray()).All(char.IsNumber);

        public static string[] TextValue(this List<TextBox> sender)
            => sender.Select(x => x.Text).ToArray();
    }
}
namespace ComboBoxesWinFormsApp
{
    public partial class Form1 : Form
    {
        readonly BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            bindingSource.PositionChanged += BindingSource_PositionChanged;
            bindingSource.DataSource = Mocking.List();
            StateComboBox.DataSource = bindingSource;
        }

        private void BindingSource_PositionChanged(object? sender, EventArgs e)
        {
            if (bindingSource.Current != null)
            {
                CityComboBox.DataSource = ((StateContainer)bindingSource.Current).CityList;
            }
        }
    }

    public class StateContainer
    {
        public string? State { get; set; }
        public List<string>? CityList { get; set; }
        public override string? ToString() => State;

    }

    public class Mocking
    {
        public static List<StateContainer> List()
        {
            return new List<StateContainer>()
            {
                new StateContainer()
                {
                    State = "Illinois", CityList = new List<string>()
                    {
                        "Chicago", "Springfield", "Random Town"
                    }
                },
                new StateContainer()
                {
                    State = "Texas", CityList = new List<string>()
                    {
                        "Austin",  "Houston"
                    }
                },
            };
        }
    }
}
namespace BlazorInWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add(new PersonListItem(1, "John Doe"));
            listBox1.Items.Add(new PersonListItem(3, "Sabrina Miller"));
            listBox1.Items.Add(new PersonListItem(16, "Claudio Bernasconi"));
        }
    }

    public record PersonListItem(int PersonId, string Name)
    {
        public override string ToString()
        {
            return Name;
        }
    }
}

using BlazorInWinForms.Services;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorInWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddScoped<IPersonService, PersonService>();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();

            listBox1.Items.Add(new PersonListItem(1, "John Doe"));
            listBox1.Items.Add(new PersonListItem(3, "Sabrina Miller"));
            listBox1.Items.Add(new PersonListItem(16, "Claudio Bernasconi"));

            var parameters = new Dictionary<string, object> { { "PersonId", 1 } };
            blazorWebView1.RootComponents.Add<PersonDetail>("#app", parameters);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPerson = listBox1.SelectedItem as PersonListItem;

            blazorWebView1.RootComponents.Remove("#app");

            var parameters = new Dictionary<string, object> { { "PersonId", selectedPerson.PersonId } };
            blazorWebView1.RootComponents.Add<PersonDetail>("#app", parameters);
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

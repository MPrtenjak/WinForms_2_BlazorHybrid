using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace Simple_CRUD
{
    public partial class BlazorForm : Form
    {
        public BlazorForm()
        {
            InitializeComponent();

            blazorWebView1.Dock = DockStyle.Fill;

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = Program.serviceProvider;
            blazorWebView1.RootComponents.Add<Members>("#app");
        }
    }
}

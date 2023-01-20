using Phichaya_1911310512.View.IFPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phichaya_1911310512.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            gitOpen.Clicked += GitOpen_Clicked;
        }

        private void GitOpen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new GitHubPage());
        }
    }
}
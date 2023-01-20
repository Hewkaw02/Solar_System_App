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
    public partial class InfoPage : ContentPage

    {
        public InfoPage()
        {
            InitializeComponent();

            earth.Clicked += Earth_Clicked;
            jupiter.Clicked += Jupiter_Click;
            mars.Clicked += Mars_Clicked;
            merculy.Clicked += Mercury_Clicked;
            neptune.Clicked += Neptune_Clicked;
            saturn.Clicked += Saturn_Clicked;
            sun.Clicked += Sun_Clicked;
            uranus.Clicked += Uranus_Clicked;
            venus.Clicked += Venus_Clicked;
        }

        private void Venus_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new VenusPage());
        }

        private void Uranus_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new UranusPage());
        }

        private void Sun_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SunPage());
        }

        private void Saturn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SaturnPage());
        }

        private void Neptune_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NeptunePage());
        }

        private void Mercury_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MercuryPage());
        }

        private void Jupiter_Click(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new JupiterPage());
        }

        private void Mars_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MercuryPage());
        }

        private void Earth_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EarthPage());
        }
    }
}
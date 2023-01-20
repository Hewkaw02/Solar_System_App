using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phichaya_1911310512.View.IFPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NeptunePage : ContentPage
    {
        public NeptunePage()
        {
            InitializeComponent();
            MClose.Clicked += MClose_Clicked;
        }
        private void MClose_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
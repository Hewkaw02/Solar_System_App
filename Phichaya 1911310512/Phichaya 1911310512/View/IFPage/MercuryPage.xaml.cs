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
    public partial class MercuryPage : ContentPage
    {

        public string A = "Mercury is the smallest and closest planet to the Sun in our solar system.It is about a third the size of Earth and has an orbital period of about 88 Earth days.The surface of Mercury is heavily cratered and covered in a layer of fine dust and rocky debris. It has no atmosphere and no known moons.";
        public string B = "Mercury has a very thin exosphere, which is an extremely tenuous atmosphere made up of atoms that have escaped from the surface. The planet has a weak magnetic field and it has been observed that the magnetic field is irregular and varies greatly in intensity.";
        public string C = "Mercury's surface is heavily cratered and has evidence of past volcanic activity. The craters on Mercury range in size from small bowl-shaped depressions to large multi-ringed basins. The largest known crater on the planet is the Caloris Basin, which is over 800 miles (1,300 km) across.";
        public string D = "Mercury also has a unique geological feature called  'hollows' which are small, shallow, and irregular depressions that have been found on the surface. It is believed that these hollows may be caused by the sublimation of volatile materials, such as water ice, that have been buried in the surface.";
        public string E = "Mercury's surface temperature varies greatly due to its lack of an atmosphere to regulate temperature. On the side facing the sun, temperatures can reach up to 800 degrees Fahrenheit (427 degrees Celsius), while on the night side, temperatures can drop as low as -290 degrees Fahrenheit (-179 degrees Celsius).";
        public string F = "Mercury is a challenging planet to study because it is so close to the Sun, and it is difficult to observe with telescopes.The majority of our knowledge about Mercury has been obtained through flyby missions, such as NASA's Mariner 10 and MESSENGER spacecraft, as well as the recent BepiColombo mission which is currently in operation.";
        public MercuryPage()
        {
            InitializeComponent();

            MClose.Clicked += MClose_Clicked;
            ALabel.Text = A;
            BLabel.Text = B;
            CLabel.Text = C;
            DLabel.Text = D;
            ELabel.Text = E;
            FLabel.Text = F;
        }

        private void MClose_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
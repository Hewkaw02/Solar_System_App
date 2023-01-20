using Phichaya_1911310512.Services;
using Phichaya_1911310512.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phichaya_1911310512
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<IPicService,PicService>();
            var tp  = new  TabbedPage();


            tp.Children.Add(new ListPage());
            tp.Children.Add(new MainPage());
            tp.Children.Add(new InfoPage());
            tp.BarBackgroundColor = Color.Black;
            tp.BarTextColor = Color.White;
            tp.CurrentPage = tp.Children[1];

            MainPage = tp;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

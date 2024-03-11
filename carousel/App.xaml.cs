using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace carousel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Temperament();
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

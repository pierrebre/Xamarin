using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_02.Vues;

namespace Xamarin_02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CartePage();
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

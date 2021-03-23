using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_01.Views.Forms;

namespace Xamarin_01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SimpleLoginPage();
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

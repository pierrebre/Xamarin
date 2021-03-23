using System;
using TestCarte.Vues;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCarte
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AjoutCarteVue();
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

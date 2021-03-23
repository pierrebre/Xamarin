using Em.Vues;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Em
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageConnection();
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

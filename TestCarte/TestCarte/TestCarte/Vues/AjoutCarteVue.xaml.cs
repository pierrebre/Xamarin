using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCarte.VuesModeles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCarte.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjoutCarteVue : ContentPage
    {
        public AjoutCarteVue()
        {
            InitializeComponent();
            BindingContext = new AjoutCarteVueModele();
        }
    }
}
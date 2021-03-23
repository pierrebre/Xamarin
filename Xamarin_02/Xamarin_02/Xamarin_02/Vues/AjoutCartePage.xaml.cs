using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_02.VuesModeles;

namespace Xamarin_02.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjoutCartePage : ContentPage
    {
        public AjoutCartePage()
        {
            InitializeComponent();
            BindingContext = new AjoutCarteVueModele();
        }
    }
}
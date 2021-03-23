using PPE_v1.VuesModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPE_v1.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View1 : ContentView
    {
        public View1()
        {
            InitializeComponent();
            BindingContext = new ApiVueModele();
        }
    }
}
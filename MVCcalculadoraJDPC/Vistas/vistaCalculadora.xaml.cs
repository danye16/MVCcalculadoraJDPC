using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCcalculadoraJDPC.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVCcalculadoraJDPC.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vistaCalculadora : ContentPage
    {
        public vistaCalculadora()
        {
            InitializeComponent();
            BindingContext = new VMcalculadora(Navigation);
        }
    }
}
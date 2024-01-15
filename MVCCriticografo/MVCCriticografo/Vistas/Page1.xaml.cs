using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCCriticografo.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVCCriticografo.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new VMcriticografo(Navigation);
        }
    }
}
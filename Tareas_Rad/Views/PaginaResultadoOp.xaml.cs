using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tareas_Rad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaResultadoOp : ContentPage
    {
        public PaginaResultadoOp(double resultado )
        {
            InitializeComponent();

            Lblresultado.Text =resultado.ToString();   
        }
    }
}
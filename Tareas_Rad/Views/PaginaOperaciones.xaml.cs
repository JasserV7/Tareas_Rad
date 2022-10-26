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
    public partial class PaginaOperaciones : ContentPage
    {
        public PaginaOperaciones()
        {
            InitializeComponent();

            pkOperacion.Items.Add("Suma");
            pkOperacion.Items.Add("Resta");
            pkOperacion.Items.Add("Multiplicacion");
            pkOperacion.Items.Add("Division");
        }

        private async void pkOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion= pkOperacion.SelectedItem.ToString();

            double n1 = Convert.ToDouble(txtNumero1.Text);
            double n2 = Convert.ToDouble(txtNumero2.Text);

            double resultado = 0;

            if (seleccion == "Suma")
                resultado = n1 + n2;
            else if (seleccion == "Resta")
                resultado = n1 - n2;
            else if (seleccion == "Multiplicacion")
                resultado = n1 * n2;
            else
                resultado = n1 / n2;


            await Navigation.PushAsync(new PaginaResultadoOp(resultado));
        }
    }
}
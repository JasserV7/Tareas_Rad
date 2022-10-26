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
    public partial class MainEmpleados : ContentPage
    {
        public MainEmpleados()
        {
            InitializeComponent();
        }

        private async void BtnSalvar_Clicked(object sender, EventArgs e)
        {
            var empleados = new Models.Empleado
            {
                Nombres= txtNombre.Text,
                apellidos=txtApellido.Text,
                Edad= Convert.ToInt32(txtEdad.Text),
                Correo= txtCorreo.Text, 
            };

            var page = new Views.RecepcionEmpleados();
            page.BindingContext = empleados;    

            await Navigation.PushAsync(page);

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tareas_Rad
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnMath_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PaginaOperaciones());
        }

        private async void Btndatos_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Views.MainEmpleados());

        }
    }
}

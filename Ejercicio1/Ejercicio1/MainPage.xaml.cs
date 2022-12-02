using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btnsuma_Clicked(object sender, EventArgs e)
        {
            var vari = new Model.Variables
            {
                n1 = Convert.ToInt32(txtnumero1.Text),
                n2 = Convert.ToInt32(txtnumero2.Text),
                Resultado = Convert.ToInt32(txtnumero1.Text) + Convert.ToInt32(txtnumero2.Text)
            };
            var ma = new Views.Page1();
            ma.BindingContext = vari;
            await Navigation.PushModalAsync(ma);
        }

        private async void Btnresta_Clicked(object sender, EventArgs e)
        {
            var vari = new Model.Variables
            {
                n1 = Convert.ToInt32(txtnumero1.Text),
                n2 = Convert.ToInt32(txtnumero2.Text),
                Resultado = Convert.ToInt32(txtnumero1.Text) - Convert.ToInt32(txtnumero2.Text)
            };
            var ma = new Views.Page1();
            ma.BindingContext = vari;
            await Navigation.PushModalAsync(ma);
        }

        private async void Btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            var vari = new Model.Variables
            {
                n1 = Convert.ToInt32(txtnumero1.Text),
                n2 = Convert.ToInt32(txtnumero2.Text),
                Resultado = Convert.ToInt32(txtnumero1.Text) * Convert.ToInt32(txtnumero2.Text)
            };
            var ma = new Views.Page1();
            ma.BindingContext = vari;
            await Navigation.PushModalAsync(ma);
        }

        private async void Btndivision_Clicked(object sender, EventArgs e)
        {
            var vari = new Model.Variables
            {
                n1 = Convert.ToInt32(txtnumero1.Text),
                n2 = Convert.ToInt32(txtnumero2.Text),
                Resultado = Convert.ToInt32(txtnumero1.Text) / Convert.ToInt32(txtnumero2.Text)
            };
            var ma = new Views.Page1();
            ma.BindingContext = vari;
            await Navigation.PushModalAsync(ma);
        }
    }
}

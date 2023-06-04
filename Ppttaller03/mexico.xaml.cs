using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ppttaller03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mexico : ContentPage
    {
        public mexico()
        {
            InitializeComponent();
        }
        private void dolares_clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Pesos.Text);
            double n = n1 / 18.91;
            n = System.Math.Round(n, 2);
            rpta.Text = n1 + " pesos mexicanos es lo mismo que " + n + " dolares";
        }

        private void euros_clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Pesos.Text);
            double n = n1 / 20.19;
            n = System.Math.Round(n, 2);
            rpta.Text = n1 + " pesos mexicanos es lo mismo que " + n + " euros";
        }
    }
}
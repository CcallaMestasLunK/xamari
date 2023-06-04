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
    public partial class chile : ContentPage
    {
        public chile()
        {
            InitializeComponent();
        }
        private void dolares_clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(PesosChilenos.Text);
            double n = n1 / 814.84;
            n = System.Math.Round(n, 2);
            rpta.Text = n1 + " pesos chilenos es lo mismo que " + n + " dolares";
        }

        private void euros_clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(PesosChilenos.Text);
            double n = n1 / 878.03;
            n = System.Math.Round(n, 2);
            rpta.Text = n1 + " pesos chilenos  es lo mismo que " + n + " euros";
        }
    }
}
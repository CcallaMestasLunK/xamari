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
    public partial class bolivia : ContentPage
    {
        public bolivia()
        {
            InitializeComponent();
        }
        private void dolares_clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(bolivianos.Text);
            double n = n1 / 6.81;
            n = System.Math.Round(n, 2);
            rpta.Text = n1 + " bolivianos es lo mismo que " + n + " dolares";
        }

        private void euros_clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(bolivianos.Text);
            double n = n1 / 7.34;
            n = System.Math.Round(n, 2);
            rpta.Text = n1 + " bolivianos es lo mismo que " + n + " euros";
        }
    }
}
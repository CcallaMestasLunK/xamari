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
    public partial class peru : ContentPage
    {
        public peru()
        {
            InitializeComponent();
        }
        private void dolares_clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Soles.Text);
            double n = n1 / 3.74;
            n = System.Math.Round(n, 2);
            rpta.Text = n1 + " soles es lo mismo que " + n + " dolares";
        }

        private void euros_clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Soles.Text);
            double n = n1 / 4.03;
            n = System.Math.Round(n, 2);
            rpta.Text = n1 + " soles es lo mismo que " + n + " euros";
        }
    }
}
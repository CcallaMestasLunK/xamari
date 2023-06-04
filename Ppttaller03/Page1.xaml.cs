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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            btnPais.Clicked += async (sender, e) =>
            {
                string action =
                await DisplayActionSheet("Elija su Pais de origen",
                "cancel",
                null,
                "Peru",
                "Chile",
                "Bolivia",
                "Mexico");
                lblPais.Text = "Pais seleccionado:  " + action;
                if (action == "Peru")
                {
                    await Navigation.PushAsync(new peru());
                }
                else if(action== "Chile")
                {
                    await Navigation.PushAsync(new chile());
                }
                else if (action == "Bolivia")
                {
                    await Navigation.PushAsync(new bolivia());
                }
                else if (action == "Mexico")
                {
                    await Navigation.PushAsync(new mexico());
                }
                else
                {
                    await DisplayAlert("Alerta", "Seleccione un pais", "Cerrar");

                }
            };
            Registro();
        }
        async void Registro()
        {
            while (true)
            {
                string nombre =
                    await DisplayPromptAsync("Registro", "Cual es su nombre");
                if (nombre == null)
                {
                    await DisplayAlert("Error", "Debe Ingresar su nombre", "Cerrar");
                }
                else
                {
                        string correo =
                    await DisplayPromptAsync("Registro", "Cual es su correo");
                        if (correo == null)
                        {
                            await DisplayAlert("Error", "Debe Ingresar su correo", "Cerrar");
                        }
                        else
                        {
                            string edad =
                                await DisplayPromptAsync("Registro", "Cual es su edad",
                                initialValue: "10", maxLength: 2, keyboard: Keyboard.Numeric);
                            if (Convert.ToInt32(edad) < 18)
                            {
                                await DisplayAlert("Alerta", "Esta App es solo para mayores de edad", "Cerrar");
                                 await Navigation.PushAsync(new MainPage());
                            break;

                        }
                            else
                            {
                                lblNombre.Text = "Usuario:  " + nombre;    
                                lblCorreo.Text = "Correo del usuario: " + correo;
                                lblEdad.Text = "Edad:  " + edad;
                            break;
                            }
                        }

                    }
                }
            }
        }
    }


        


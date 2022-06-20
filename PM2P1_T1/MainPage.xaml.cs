using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2P1_T1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Operation_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryFirstNumber.Text) || string.IsNullOrWhiteSpace(entrySecondNumber.Text))
            {
                message("Alerta", "Debe escribir ambos numeros");
                return;
            }

            decimal num1 = decimal.Parse(entryFirstNumber.Text);
            decimal num2 = decimal.Parse(entrySecondNumber.Text);
            decimal result;


            if (sender.Equals(btnSum))
            {
                result = num1 + num2;
            }
            else if (sender.Equals(btnRest))
            {
                result = num1 - num2;
            }
            else if (sender.Equals(btnDiv))
            {
                if (num2 == 0)
                {
                    message("Alerta", "El segundo numero no puede ser 0");
                    return;
                }
                result = num1 / num2;
            }
            else 
            {
                result = num1 * num2;
            }
            await Navigation.PushAsync(new ResultPage(result));
        }

        private async void message(string title, string description)
        {
            await DisplayAlert(title, description, "OK");
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            entryFirstNumber.Text = "";
            entrySecondNumber.Text = "";
        }
    }
}

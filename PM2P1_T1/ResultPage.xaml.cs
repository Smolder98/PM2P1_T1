using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2P1_T1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage()
        {
            InitializeComponent();
            
        }

        public ResultPage(decimal result)
        {
            InitializeComponent();

            txtResult.Text = "El resultado es :" + result.ToString("0.##");
        }
    }
}
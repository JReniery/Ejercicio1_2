using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSend_Clicked(object sender, EventArgs e)
        {
            var Info = new InformationClass
            {
                Name = txbName.Text,
                LastName = txbLastName.Text,
                Age = Convert.ToInt16(txbAge.Text),
                Email = txbEmail.Text
            };
            var InfoPage = new ViewDataPage
            {
                BindingContext = Info
            };
            await Navigation.PushAsync(InfoPage);
        }
    }
}

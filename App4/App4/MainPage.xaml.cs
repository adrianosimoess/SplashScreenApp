using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(200);

            await Task.WhenAll(
                SplashGrid.FadeTo(0,2000),
                Logo.ScaleTo(10,2000)
                );
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GetWeaterPhoneApp.Services;

namespace GetWeaterPhoneApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            WeatherService weatherService = new WeatherService();
            weatherService.Get();


        }
    }
}

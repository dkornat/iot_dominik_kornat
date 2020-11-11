using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab1.DTO.Api;

namespace Lab1
{
    public partial class App : Application
    {
        public App()
        {
            var client = RestEase.RestClient.For<IPeopleClient>("http://192.168.8.103:6001/api");
            InitializeComponent();

            MainPage = new MainPage(client);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

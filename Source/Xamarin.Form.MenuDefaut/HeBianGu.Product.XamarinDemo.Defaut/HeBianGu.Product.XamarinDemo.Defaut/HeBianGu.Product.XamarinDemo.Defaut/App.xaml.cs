using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HeBianGu.Product.XamarinDemo.Defaut.Services;
using HeBianGu.Product.XamarinDemo.Defaut.Views;

namespace HeBianGu.Product.XamarinDemo.Defaut
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using MvvmSample2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSample2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InboxPage())
            {
                BarBackgroundColor = Color.Red
            };
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

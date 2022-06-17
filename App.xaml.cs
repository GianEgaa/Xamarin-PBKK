using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms_PBKK
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HelloXamarin.MainPage();
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

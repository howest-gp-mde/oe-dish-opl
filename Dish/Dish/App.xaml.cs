using Dish.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dish
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DishPage());
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

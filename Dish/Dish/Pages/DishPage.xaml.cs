using Dish.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dish.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DishPage : ContentPage
    {
        DishViewModel model;
        public DishPage()
        {
            InitializeComponent();

            model = new DishViewModel();
            BindingContext = model;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            model.AppearingCommand.Execute(null);
        }
    }
}
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dish.ViewModels
{
    public class DishViewModel : FreshBasePageModel
    {

        private int timesEaten;

        public int TimesEaten
        {
            get { return timesEaten; }
            set { timesEaten = value; RaisePropertyChanged(nameof(TimesEaten)); }
        }

        private string dishName;

        public string DishName
        {
            get { return dishName; }
            set { 
                dishName = value; 
                RaisePropertyChanged(nameof(DishName)); 
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.Properties[nameof(DishName)] = DishName;
                    Application.Current.Properties[nameof(TimesEaten)] = TimesEaten;
                });
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            AppearingCommand.Execute(null);
        }

        public ICommand AppearingCommand
        {
            get
            {
                return new Command(() =>
                {
                    if (Application.Current.Properties.ContainsKey(nameof(DishName))
                    && Application.Current.Properties.ContainsKey(nameof(TimesEaten)))
                    {
                        DishName = Application.Current.Properties[nameof(DishName)] as string;
                        TimesEaten = Convert.ToInt32(Application.Current.Properties[nameof(TimesEaten)]);
                    }
                    
                });
            }
        }
    }
}

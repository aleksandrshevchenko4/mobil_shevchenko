using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobil_shevchenko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderSepper : ContentPage
    {
        public SliderSepper()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            Editor1.FontSize = Slider1.Value;
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                Editor1.FontSize = e.NewValue;
                Stepper1.Value = e.NewValue;
            }

        }

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
                Editor1.FontSize = e.NewValue;
            Slider1.Value = e.NewValue;
        }
    }
}
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
    public partial class SliderStepper : ContentPage
    {
        public static Xamarin.Forms.Color Black { get; }
        Slider Slider1, slider2, Slider3;
        BoxView boxView;
        Label redLabel, greenLabel, blueLabel;

        public SliderStepper()
        {
            boxView = new BoxView()
            {
                WidthRequest = 160,
                HeightRequest = 160,
                Color = Color.Black,
            };
            Slider1 = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 0,
            };
            Slider1.ValueChanged += Slider1_ValueChanged;
            redLabel = new Label()
            {

            };
            slider2 = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 0,
            };

            slider2.ValueChanged += Slider2_ValueChanged;

            greenLabel = new Label()
            {

            };

            Slider3 = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 0,
            };

            Slider3.ValueChanged += Slider3_ValueChanged;

            blueLabel = new Label()
            {

            };

            StackLayout stackLayout = new StackLayout()
            {
                Margin = new Thickness(10),
                Children = { boxView, Slider1, redLabel, slider2, greenLabel, Slider3, blueLabel }
            };
            Content = stackLayout;

        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                redLabel.Text = Convert.ToInt32(e.NewValue).ToString();
                boxView.Color = Color.FromRgb(Convert.ToInt32(e.NewValue), slider2.Value, Slider3.Value);

            }
        }
        private void Slider2_ValueChanged(object sender, ValueChangedEventArgs g)
        {
            if (g.NewValue > 0)
            {
                greenLabel.Text = Convert.ToInt32(g.NewValue).ToString();
                boxView.Color = Color.FromRgb(Convert.ToInt32(g.NewValue), Slider1.Value, Slider3.Value);
            }
        }
        private void Slider3_ValueChanged(object sender, ValueChangedEventArgs b)
        {
            if (b.NewValue > 0)
            {
                blueLabel.Text = Convert.ToInt32(b.NewValue).ToString();
                boxView.Color = Color.FromRgb(Convert.ToInt32(b.NewValue), Slider1.Value, slider2.Value);
            }
        }
    }
}
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
    public partial class Valgusfoor : ContentPage
    {
        public Valgusfoor()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btn_Clicked(object sender, EventArgs e)
        {
            int c = rnd.Next(1, 4);
            if (c == 1)
            {
                pun.BackgroundColor = Xamarin.Forms.Color.FromRgb(255, 0, 0);
                kol.BackgroundColor = Xamarin.Forms.Color.Gray;
                roh.BackgroundColor = Xamarin.Forms.Color.Gray;
            }
            else if (c == 2)
            {
                pun.BackgroundColor = Xamarin.Forms.Color.Gray;
                kol.BackgroundColor = Xamarin.Forms.Color.FromRgb(255, 255, 0);
                roh.BackgroundColor = Xamarin.Forms.Color.Gray;
            }
            else if (c == 3)
            {
                pun.BackgroundColor = Xamarin.Forms.Color.Gray;
                kol.BackgroundColor = Xamarin.Forms.Color.Gray;
                roh.BackgroundColor = Xamarin.Forms.Color.FromRgb(0, 255, 0);
            }
            else if (c == 4)
            {
                pun.BackgroundColor = Xamarin.Forms.Color.FromRgb(255, 0, 0);
                kol.BackgroundColor = Xamarin.Forms.Color.FromRgb(255, 255, 0);
                roh.BackgroundColor = Xamarin.Forms.Color.FromRgb(0, 255, 0);
            }
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Xamarin.Forms.Color.FromRgb(100, 100, 100);
            kol.BackgroundColor = Xamarin.Forms.Color.Gray;
            roh.BackgroundColor = Xamarin.Forms.Color.FromHex("#aaaaa");
        }
    }
}
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
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
        }
        int clik = 0;
        private void btn_Clicked(object sender, EventArgs e)
        {
            //btn.Text = "Huraaaa!";
            clik++;
            btn.Text = clik.ToString();
            if (clik % 5 == 0)
            {
                lbl.IsVisible = false;
            }
            else
            {
                lbl.IsVisible = true;
            }
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            clik = 0;
        }
    }
}
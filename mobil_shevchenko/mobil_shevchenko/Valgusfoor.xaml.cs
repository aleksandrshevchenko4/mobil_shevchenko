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

        private void button_Clicked(object sender, EventArgs e)
        {
            frm1.BackgroundColor = Color.Gray;
            Red.Text = "Turned off";
            frm2.BackgroundColor = Color.Gray;
            Yellow.Text = "Turned off";
            frm3.BackgroundColor = Color.Gray;
            Green.Text = "Turned off";
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            Red.Text = "Red";
            frm1.BackgroundColor = Color.Red;
            Yellow.Text = "Yellow";
            frm2.BackgroundColor = Color.Yellow;
            Green.Text = "Green";
            frm3.BackgroundColor = Color.Green;
        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            if (Red.Text == "Red")
            {
                Red.Text = "Turned off";
                frm1.BackgroundColor = Color.Gray;
            }
            else
            {
                Red.Text = "Red";
                frm1.BackgroundColor = Color.Red;
            }

        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            if (Yellow.Text == "Yellow")
            {
                Yellow.Text = "Turned off";
                frm2.BackgroundColor = Color.Gray;
            }
            else
            {
                Yellow.Text = "Yellow";
                frm2.BackgroundColor = Color.Yellow;
            }
        }

        private void button4_Clicked(object sender, EventArgs e)
        {
            if (Green.Text == "Green")
            {
                Green.Text = "Turned off";
                frm3.BackgroundColor = Color.Gray;
            }
            else
            {
                Green.Text = "Green";
                frm3.BackgroundColor = Color.Green;
            }
        }

        private void button5_Clicked(object sender, EventArgs e)
        {
            //frm1.BackgroundColor = Color.Gray;
            //frm2.BackgroundColor = Color.Gray;
            //frm3.BackgroundColor = Color.Gray;
            //Thread.Sleep(1000);
            //frm1.BackgroundColor = Color.Red;
            //Thread.Sleep(1000);
            //frm1.BackgroundColor = Color.Gray;
            //Thread.Sleep(1000);
            //frm2.BackgroundColor = Color.Yellow;
            //Thread.Sleep(1000);
            //frm2.BackgroundColor = Color.Gray;
            //Thread.Sleep(1000);
            //frm3.BackgroundColor = Color.Green;
            //Thread.Sleep(1000);
            //frm3.BackgroundColor = Color.Gray;
        }
        Random rnd = new Random();
        private void button6_Clicked(object sender, EventArgs e)
        {
            int c = rnd.Next(1, 4);
            if (c == 1)
            {
                frm1.BackgroundColor = Color.FromRgb(255, 0, 0);
                frm2.BackgroundColor = Color.Gray;
                frm3.BackgroundColor = Color.Gray;
            }
            else if (c == 2)
            {
                frm1.BackgroundColor = Color.Gray;
                frm2.BackgroundColor = Color.FromRgb(255, 255, 0);
                frm3.BackgroundColor = Color.Gray;
            }
            else if (c == 3)
            {
                frm1.BackgroundColor = Color.Gray;
                frm2.BackgroundColor = Color.Gray;
                frm3.BackgroundColor = Color.FromRgb(0, 255, 0);
            }
            else if (c == 4)
            {
                frm1.BackgroundColor = Color.Gray;
                frm2.BackgroundColor = Color.Gray;
                frm3.BackgroundColor = Color.Gray;
            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobil_shevchenko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label punane, kollane, roheline;
        Frame pun, kol, roh;
        Button sisse, valja;
        bool sisse_valja;

        public Valgusfoor2()
        {
            //InitializeComponent();
            punane = new Label()
            {
                Text = "Punane",
                TextColor = Xamarin.Forms.Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            pun = new Frame()
            {
                BackgroundColor = Xamarin.Forms.Color.Red,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
            };
            kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Xamarin.Forms.Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            kol = new Frame()
            {
                BackgroundColor = Xamarin.Forms.Color.Yellow,
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
            };
            roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Xamarin.Forms.Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            roh = new Frame()
            {
                BackgroundColor = Xamarin.Forms.Color.Green,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            valja = new Button()
            {
                Text = "Välja",
                BackgroundColor = Xamarin.Forms.Color.Gray,
                Margin = new Thickness(80, 0, 80, 0),


            };
            sisse = new Button()
            {
                Text = "Sisse",
                BackgroundColor = Xamarin.Forms.Color.Gray,
                Margin = new Thickness(80, 0, 80, 0),


            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh, valja, sisse }
            };

            sisse.Clicked += Sisse_Clicked;
            valja.Clicked += Valja_Clicked;


            //stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);

            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += Tap_Tapped;
            kol.GestureRecognizers.Add(tap1);

            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += Tap_Tapped;
            roh.GestureRecognizers.Add(tap2);


        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == pun) { punane.Text = "Seisa ja oota!"; };
            if (fr == kol) { kollane.Text = "Sea end vajuta!"; };
            if (fr == roh) { roheline.Text = "Mine!"; };
            if (pun.BackgroundColor == Xamarin.Forms.Color.FromRgb(100, 100, 100)) { punane.Text = "Sisse lülitada!"; };
            if (kol.BackgroundColor == Xamarin.Forms.Color.Gray) { kollane.Text = "Sisse lülitada!"; };
            if (roh.BackgroundColor == Xamarin.Forms.Color.FromHex("#a1a1a1")) { roheline.Text = "Sisse lülitada!"; };
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Xamarin.Forms.Color.FromRgb(100, 100, 100);
            kol.BackgroundColor = Xamarin.Forms.Color.Gray;
            roh.BackgroundColor = Xamarin.Forms.Color.FromHex("#a1a1a1");
            sisse_valja = true;
        }
        Random rnd = new Random();

        private async void Sisse_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Xamarin.Forms.Color.Red;
            pun.BorderColor = Xamarin.Forms.Color.WhiteSmoke;
            sisse_valja = false;
            for (int i = 0; i < 100; i++)
            {
                punane.FontSize++;
                await Task.Run(() => Thread.Sleep(1000));
            }
            int c = rnd.Next(1, 4);
            if (c == 1)
            {
                pun.BackgroundColor = Xamarin.Forms.Color.Red;
                kol.BackgroundColor = Xamarin.Forms.Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Xamarin.Forms.Color.FromRgb(62, 62, 62);

            }
            else if (c == 2)
            {
                pun.BackgroundColor = Xamarin.Forms.Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Xamarin.Forms.Color.Yellow;
                roh.BackgroundColor = Xamarin.Forms.Color.FromRgb(62, 62, 62);
            }
            else if (c == 3)
            {
                pun.BackgroundColor = Xamarin.Forms.Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Xamarin.Forms.Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Xamarin.Forms.Color.Green;
            }
        }
    }
}
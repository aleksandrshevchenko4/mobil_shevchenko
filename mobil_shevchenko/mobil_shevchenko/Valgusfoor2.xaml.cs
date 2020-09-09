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
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
            };
            kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
            };
            roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            valja = new Button()
            {
                Text = "off",
                BackgroundColor = Color.Gold,

            };
            sisse = new Button()
            {
                Text = "on",
                BackgroundColor = Color.Gold,

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
            pun.GestureRecognizers.Add(tap1);

            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap2);
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == pun) { punane.Text = "Seisa ja oota!!"; }
            if (fr == kol) { kollane.Text = "Pochti mine!!"; }
            if (fr == roh) { roheline.Text = "Mine!!"; }

        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromRgb(100, 100, 100);
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.FromHex("#aaaaaa");
        }
        Random rnd = new Random();
        private async void Sisse_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.Red;
            pun.BorderColor = Color.WhiteSmoke;
            sisse_valja = false;
            for (int i = 0; i < 100; i++)
            {
                punane.FontSize++;
                await Task.Run(() => Thread.Sleep(1000));
            }
            int c = rnd.Next(1, 4);
            if (c == 1)
            {
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);

            }
            else if (c == 2)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.Yellow;
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);
            }
            else if (c == 3)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.Green;
            }
        }
    }
}
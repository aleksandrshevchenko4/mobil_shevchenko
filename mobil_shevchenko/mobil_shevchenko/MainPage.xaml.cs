using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobil_shevchenko
{
    public partial class MainPage : ContentPage
    {
        BoxView box;
        Button new_game, random_player;
        public bool first_player;
        public MainPage()
        {
            First_Player_manual();
            New_game_Clicked();
        }

        void New_game_Clicked()
        {
            Grid grid = new Grid();
            for (int i = 0; i < 4; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    box = new BoxView { Color = Color.FromRgb(0, 0, 0) };
                    grid.Children.Add(box, i, j);
                    var tap = new TapGestureRecognizer();
                    box.GestureRecognizers.Add(tap);
                    tap.Tapped += Tap_Tapped;
                }
            }
            new_game = new Button { Text = "Новая игра" };
            grid.Children.Add(new_game, 0, 3);
            Grid.SetColumnSpan(new_game, 2);
            random_player = new Button { Text = "Кто первый" };
            grid.Children.Add(random_player, 2, 3);
            Grid.SetColumnSpan(random_player, 2);
            random_player.Clicked += Random_player_Clicked;
            Content = grid;

        }
        private void Random_player_Clicked(object sender, EventArgs e)
        {
            First_Player();
            New_game_Clicked();
        }
        BoxView box_clik;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            {
                box_clik = sender as BoxView;
                //if (box.Color == Color.FromRgb(255, 0, 0))
                //{
                //    box.Color = Color.FromRgb(0, 255, 0);
                //}
                //else
                //{
                //    box.Color = Color.FromRgb(255, 0, 0);
                //}
                if (box_clik.Color == Color.FromRgb(0, 0, 0) && first_player)
                {
                    box_clik.Color = Color.FromRgb(255, 0, 0);
                    first_player = false;
                }
                else if (box_clik.Color == Color.FromRgb(0, 0, 0) && !first_player)
                {
                    box_clik.Color = Color.FromRgb(0, 255, 0);
                    first_player = true;
                }
                else
                {
                    DisplayAlert("Сообщение", "Противник уже выбрал это поле", "Ok");
                }
            };
        }

        Random rnd = new Random();
        private bool First_Player()
        {
            int player = rnd.Next(0, 2);
            if (player == 1)
            {
                first_player = true;
            }
            else
            {
                first_player = false;
            }
            return first_player;
        }

        public async void First_Player_manual()
        {
            string first_player_manual = await DisplayPromptAsync("Кто первый?", "Красный -1, Зеленый -2", initialValue: "1", maxLength: 1, keyboard: Keyboard.Numeric);
            if (first_player_manual == "1")
            {
                first_player = true;
            }
            else
            {
                first_player = false;
            }
        }
    }
}
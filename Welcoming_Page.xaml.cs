using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PopularCharacters
{
    public partial class Welcoming_Page : ContentPage
    {
        public Welcoming_Page()
        {
            InitializeComponent();
        }


        private async void VideoGames_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new MainPage());

        }


        private async void Anime_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new AnimePage());

        }
    }
}

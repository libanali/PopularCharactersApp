using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PopularCharacters
{
    public partial class AnimePage : ContentPage
    {
        public AnimePage()
        {
            InitializeComponent();
        }



        private async void Goku_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new GokuPage());

        }



        private async void Naruto_clicked(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new NarutoooPage());

        }



        private async void Luffy_clicked(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new LuffyPage());

        }



        private async void Light_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new LightYagami());

        }


        private async void Ash_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new AshKetchum());

        }


        private async void Kirito_clicked(object sneder, EventArgs e)

        {

            await Navigation.PushAsync(new KiritoPage());
        }



        private async void Ichigo_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new IchigoPage());
        }



        private async void Shoto_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new ShotoPage());
        }
    }
}

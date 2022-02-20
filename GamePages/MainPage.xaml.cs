using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopularCharacters
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }


        private async void Cloud_clicked(object sender, EventArgs e)
        {

            // Navigation.PushAsync(new MyPage());

            //var page = new MyPage();

           // await Navigation.PushAsync(new MyPage());

            await Navigation.PushAsync(new MyPage());

        }



        private async void Sora_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new SoraPage());

        }



        private async void X_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new Megaman());

         

        }



        private async void Link_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new LinkZeldaPage());
        }



        private async void Mario_clicked(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new MarioPage());
        }



        private async void Sephiroth_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new SephirothPage());
        }



        private async void Sonic_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new SonicPage());
        }



        private async void Crash_clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new CrashPage());
        }





    }
}

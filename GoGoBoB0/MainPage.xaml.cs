using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoGoBoB0.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoGoBoB0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Krisinformation_Clicked(System.Object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new Krisinformation());
        }

        async void PackaenBOB_Clicked(System.Object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new PackaenBOB());
        }

        async void Minchecklista_Clicked(System.Object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new Minchecklista());
        }

        async void Links_Clicked(System.Object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new Links());
        }

        async void Kontakt_Clicked(System.Object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new Kontakt());
        }
    }
}

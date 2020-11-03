using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using GoGoBoB0.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections;

namespace GoGoBoB0
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Krisinformation : ContentPage
    {
        public IApiService apiService;

        public ObservableCollection<Services.Entry> KrisFeed { get; } = new ObservableCollection<Services.Entry>();

        public ICommand LoadCommand { get; }

        public Krisinformation()
        {
            InitializeComponent();
            apiService = DependencyService.Get<IApiService>();
            LoadCommand = new Command(async () => await Load());
            krisFeedListView.ItemsSource = KrisFeed;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Load();
        }

        public async Task Load()
        {
            KrisFeed.Clear();

            var root = await apiService.GetKrisFeed();           

            foreach (var item in root.Entries)
            {
                KrisFeed.Add(item);
            }
        }
    }
}


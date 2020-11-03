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
        public ApiService apiService;

        public ObservableCollection<string> KrisTema { get; } = new ObservableCollection<string>();
        public ICommand LoadCommand { get; }

        public Krisinformation()
        {
            InitializeComponent();
            LoadCommand = new Command(async () => await Load());
            krisTemanListView.ItemsSource = KrisTema;
        }

        public async Task Load()
        {
            var krisTema = await apiService.Get();

            //foreach (var KrisTema in krisTema)
            //{
            //    KrisTema.Add();
            //}
        }
    }

    public class KrisTema
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }
    }

    //public class Krisfeed
    //{
    //    public int ID { get; set; }
    //    public string Title { get; set; }
    //    public string Summary { get; set; }
    //    public string LinkUrl { get; set; }
    //}
}


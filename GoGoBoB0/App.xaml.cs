using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GoGoBoB0.Services;

namespace GoGoBoB0
{
    public partial class App : Application
    {
        static NoteDatabase database;

        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            RegisterServices();
            MainPage = new NavigationPage(new MainPage());
        }

        private static void RegisterServices()
        {
            DependencyService.Register<IApiService, ApiService>();
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

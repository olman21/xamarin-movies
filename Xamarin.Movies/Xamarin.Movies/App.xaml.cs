using AiForms.Dialogs.Abstractions;
using CommonServiceLocator;
using System;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Movies.IoC;
using Xamarin.Movies.Models;
using Xamarin.Movies.Services;
using Xamarin.Movies.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin.Movies
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            XamarinMovieContainer
                .Create()
                .Configure()
                .SetInternalSettings(new InternalSettings
                {
                    MovieDbBaseUrl = Resources["MovieDbBaseUrl"] as string,
                    MovieDbApiKey = Resources["MovieDbApiKey"] as string,
                    MovieDbImageBaseUrl = Resources["MovieDbImageBaseUrl"] as string
                }).Build();

            MainPage = new NavigationPage(new SearchMoviePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

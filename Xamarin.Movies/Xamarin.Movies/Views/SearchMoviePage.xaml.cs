using AiForms.Dialogs;
using AiForms.Dialogs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Movies.ViewModels;

namespace Xamarin.Movies.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchMoviePage : ContentPage
	{
        public SearchMovieViewModel ViewModel => (BindingContext as SearchMovieViewModel);
        public SearchMoviePage ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (!ViewModel.Movies.Any())
                await ViewModel.LoadMovies();
        }
    }
}
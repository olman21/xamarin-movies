using AiForms.Dialogs;
using AiForms.Dialogs.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Movies.Extensions;
using Xamarin.Movies.Models;
using Xamarin.Movies.Services;

namespace Xamarin.Movies.ViewModels
{
    public class SearchMovieViewModel : INotifyPropertyChanged
    {
        private readonly IMovieService _movieService;

        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isBusy = false;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(IsBusy)));
                }
            }
        }
        public ObservableCollection<Movie> Movies { get; private set; } = new ObservableCollection<Movie>();

        public SearchMovieViewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task LoadMovies()
        {
            IsBusy = true;
            var movieList = await _movieService.GetData();
            Movies.LoadFromList(movieList);
            IsBusy = false;
        }
    }
}

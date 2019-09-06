using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Movies.ViewModels;

namespace Xamarin.Movies.IoC
{
    public class ViewModelLocator
    {
        public SearchMovieViewModel SearchMovieViewModel => ServiceLocator.Current.GetInstance<SearchMovieViewModel>();
    }
}

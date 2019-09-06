using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Movies.Models;

namespace Xamarin.Movies.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetData();
    }
}

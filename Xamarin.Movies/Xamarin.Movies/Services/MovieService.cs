using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Movies.Models;

namespace Xamarin.Movies.Services
{
    public class MovieService : IMovieService
    {
        private readonly InternalSettings _settings;
        private readonly HttpClient _httpClient;

        public MovieService(InternalSettings settings, HttpClient httpClient)
        {
            _settings = settings;
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Movie>> GetData()
        {
            var response = await _httpClient.GetAsync($"{_settings.MovieDbBaseUrl}/discover/movie?api_key={_settings.MovieDbApiKey}&sort_by=popularity.desc");
            var responseContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<MovieDbResponse<Movie>>(responseContent);

            return result.Results;
        }
    }
}

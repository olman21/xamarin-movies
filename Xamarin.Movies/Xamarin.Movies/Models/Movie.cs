using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Movies.Models
{
    public class Movie
    {
        public double Popularity { get; set; }
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        public bool Video { get; set; }
        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }
        public int id { get; set; }
        public bool adult { get; set; }
        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }
        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }
        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }
        [JsonProperty("genre_ids")]
        public List<int> GenreIds { get; set; }
        public string Title { get; set; }
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }
        public string Overview { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

    }
}

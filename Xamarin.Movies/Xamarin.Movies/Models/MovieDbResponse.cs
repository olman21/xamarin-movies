using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Movies.Models
{
    public class MovieDbResponse<T>
    {
        public int Page { get; set; }
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        public IEnumerable<T> Results { get; set; }

    }
}

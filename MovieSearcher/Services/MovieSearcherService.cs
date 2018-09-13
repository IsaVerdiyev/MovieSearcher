using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MovieSearcher.Exceptions;
using MovieSearcher.Model;
using Newtonsoft.Json.Linq;

namespace MovieSearcher.Services
{
    class MovieSearcherService : IMovieSearcher
    {
        string api;
        string staticPartOfRequest = @"http://www.omdbapi.com/?apikey=";
        public string API { get => api; set => api = value; }
        public MovieSearcherService() { }
        
        public MovieSearcherService(string api)
        {
            API = api;
        }

        public async Task<bool> AsyncLoadFullMovieInfoById(Movie movie)
        {
            string response = await GetAsyncResponseOfSearchByIdFromWeb(movie.ImdbId);
            var JObj = JObject.Parse(response);
            movie.Response = JObj["Response"].Value<bool>();
            if (movie.Response == true)
            {
                movie.Rated = JObj["Rated"]?.Value<string>();
                movie.Released = JObj["Released"]?.Value<string>();
                movie.Runtime = JObj["Runtime"]?.Value<string>();
                movie.Genre = JObj["Genre"]?.Value<string>();
                movie.Director = JObj["Director"]?.Value<string>();
                movie.Writer = JObj["Writer"]?.Value<string>();
                movie.Actors = JObj["Actors"]?.Value<string>();
                movie.Plot = JObj["Plot"]?.Value<string>();
                movie.Language = JObj["Language"]?.Value<string>();
                movie.Country = JObj["Country"]?.Value<string>();
                movie.Awards = JObj["Awards"]?.Value<string>();
                movie.Ratings = JObj["Ratings"]?.Select(r => new Rating { Source = r.SelectToken("Source").Value<string>(), Value = r.SelectToken("Value").Value<string>() }).ToList<Rating>();
                movie.Metascore = JObj["Metascore"]?.Value<string>();
                movie.ImdbRating = JObj["imdbRating"]?.Value<string>();
                movie.ImdbVotes = JObj["imdbVotes"]?.Value<string>();
                movie.DVD = JObj["DVD"]?.Value<string>();
                movie.BoxOffice = JObj["BoxOffice"]?.Value<string>();
                movie.Production = JObj["Production"]?.Value<string>();
                movie.Website = JObj["Website"]?.Value<string>();
                return true;
            }
            else
            {
                throw new Exception($"Error occured in AsyncLoadFullMovieInfoById. Searched id: {movie.ImdbId}");
            }
        }

        public List<Movie> SearchMoviesByTitle(string title)
        {
            string webResponse = GetResponseOfSearchByTitleFromWeb(title);
            var JObj = JObject.Parse(webResponse);
            if (JObj["Response"].Value<bool>() == true)
            {
                return JObj["Search"].Select(r => new Movie
                {
                    Title = r.SelectToken("Title").Value<string>(),
                    Year = r.SelectToken("Year").Value<string>(),
                    ImdbId = r.SelectToken("imdbID").Value<string>(),
                    Type = r.SelectToken("Type").Value<string>(),
                    Poster = r.SelectToken("Poster").Value<string>()
                }).ToList<Movie>();
            }
            else
            {
                string errorCode = JObj["Error"].Value<string>();
                if(errorCode == "Too many results.")
                {
                    throw new TooManyResultsException();
                }
                else if(errorCode == "Movie not found!")
                {
                    throw new MovieNotFoundException();
                }
                else
                {
                    throw new Exception($"Uknown exception in SearchMoviesByTitle. Requested title: {title}");
                }
            }

        }

        string GetResponseOfSearchByTitleFromWeb(string title)
        {
            string request = $"{staticPartOfRequest}{API}&s={title}";
            using(WebClient client = new WebClient())
            {
                return client.DownloadString(request);
            }
        }

        async Task<string> GetAsyncResponseOfSearchByIdFromWeb(string id)
        {
            string request = $"{staticPartOfRequest}{API}&i={id}";
            using(WebClient client = new WebClient())
            {
                return await client.DownloadStringTaskAsync(request);
            }
        }
    }
}

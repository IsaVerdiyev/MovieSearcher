using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearcher.Model
{
    public class Movie
    {
        string title;
        string year;
        string rated;
        string released;
        string runtime;
        string genre;
        string director;
        string writer;
        string actors;
        string plot;
        string language;
        string country;
        string awards;
        string poster;
        List<Rating> ratings;
        string metascore;
        string imdbRating;
        string imdbVotes;
        string imdbId;
        string type;
        string dvd;
        string boxOffice;
        string production;
        string website;
        bool response;

        public string Title { get => title; set => title = value; }
        public string Year { get => year; set => year = value; }
        public string Rated { get => rated; set => rated = value; }
        public string Released { get => released; set => released = value; }
        public string Runtime { get => runtime; set => runtime = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Director { get => director; set => director = value; }
        public string Writer { get => writer; set => writer = value; }
        public string Actors { get => actors; set => actors = value; }
        public string Plot { get => plot; set => plot = value; }
        public string Language { get => language; set => language = value; }
        public string Country { get => country; set => country = value; }
        public string Awards { get => awards; set => awards = value; }
        public string Poster { get => poster; set => poster = value; }
        public List<Rating> Ratings { get => ratings; set => ratings = value; }
        public string Metascore { get => metascore; set => metascore = value; }
        public string ImdbRating { get => imdbRating; set => imdbRating = value; }
        public string ImdbVotes { get => imdbVotes; set => imdbVotes = value; }
        public string ImdbId { get => imdbId; set => imdbId = value; }
        public string Type { get => type; set => type = value; }
        public string DVD { get => dvd; set => dvd = value; }
        public string BoxOffice { get => boxOffice; set => boxOffice = value; }
        public string Production { get => production; set => production = value; }
        public string Website { get => website; set => website = value; }
        public bool Response { get => response; set => response = value; }

        public void LoadAllMovieInfoFromOmdbApi(string url)
        {
            string webResponse;
            using(WebClient webClient = new WebClient())
            {
                webResponse = webClient.DownloadString(url);
                FillDataInMovieFromWebResponse(webResponse);
            }

        }

        void FillDataInMovieFromWebResponse(string webResponse)
        {
            var JObj = JObject.Parse(webResponse);
            Response = JObj["Response"].Value<bool>();
            if (Response == true)
            {
                Rated = JObj["Rated"].Value<string>();
                Released = JObj["Released"].Value<string>();
                Runtime = JObj["Runtime"].Value<string>();
                Genre = JObj["Genre"].Value<string>();
                Director = JObj["Director"].Value<string>();
                Writer = JObj["Writer"].Value<string>();
                Actors = JObj["Actors"].Value<string>();
                Plot = JObj["Plot"].Value<string>();
                Language = JObj["Language"].Value<string>();
                Country = JObj["Country"].Value<string>();
                Awards = JObj["Awards"].Value<string>();
                Ratings = JObj["Ratings"].Select(r => new Rating { Source = r.SelectToken("Source").Value<string>(), Value = r.SelectToken("Value").Value<string>() }).ToList<Rating>();
                Metascore = JObj["Metascore"].Value<string>();
                ImdbRating = JObj["imdbRating"].Value<string>();
                ImdbVotes = JObj["imdbVotes"].Value<string>();
                DVD = JObj["DVD"].Value<string>();
                BoxOffice = JObj["BoxOffice"].Value<string>();
                Production = JObj["Production"].Value<string>();
                Website = JObj["Website"].Value<string>();
            }
        }

        public override string ToString()
        {
            return $"{Title} ({Type}, {Year})";
        }
    }
}

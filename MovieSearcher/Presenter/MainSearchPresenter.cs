using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSearcher.Model;
using MovieSearcher.Services;
using MovieSearcher.View;

namespace MovieSearcher.Presenter
{
    class MainSearchPresenter: IMainSearchPresenter
    {
        IMainSearchView mainSearchView;
        IMovieSearcher movieSearcher;
        List<Movie> movies;

        public MainSearchPresenter(IMainSearchView mainSearchView)
        {
            this.mainSearchView = mainSearchView;
            movieSearcher = new MovieSearcherService("ba0ef793");
        }
        
        public List<Movie> Movies { get => movies; set => movies = value; }

        public async Task<bool> GetMoreInfoAboutMovieAsync(Movie movie)
        {
            return await movieSearcher.AsyncLoadFullMovieInfoById(movie);
        }

        public bool SearchByTitle(string title)
        {
            if (!String.IsNullOrWhiteSpace(title))
            {
                movies = movieSearcher.SearchMoviesByTitle(title);
                mainSearchView.UpdateListOfMovies();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ZeroMoviesList()
        {
            Movies = null;
            mainSearchView.UpdateListOfMovies();
        }
    }
}

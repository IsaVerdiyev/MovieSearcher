using MovieSearcher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearcher.Presenter
{
    interface IMainSearchPresenter
    {
        List<Movie> Movies { get; set; }
        bool SearchByTitle(string title);
        Task<bool> GetMoreInfoAboutMovieAsync(Movie movie);
        void ZeroMoviesList();
    }
}

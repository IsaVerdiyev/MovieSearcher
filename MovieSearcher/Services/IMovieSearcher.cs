using MovieSearcher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearcher.Services
{
    interface IMovieSearcher
    {
        List<Movie> SearchMoviesByTitle(string title);
        Task<bool> AsyncLoadFullMovieInfoById(Movie movie);
    }
}

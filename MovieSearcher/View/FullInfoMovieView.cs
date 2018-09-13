using MovieSearcher.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSearcher.View
{
    public partial class FullInfoMovieMovie2 : Form
    {
        Movie movie;
        public FullInfoMovieMovie2(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            InitializeInfoFiels();
        }

        void InitializeInfoFiels()
        {
            TitleLabel.Text = movie.Title;
            YearValueLabel.Text = movie.Year;
            RatedValueLabel.Text = movie.Rated;
            ReleasedValueLabel.Text = movie.Released;
            RuntimeValueLabel.Text = movie.Runtime;
            GenreValueLabel.Text = movie.Genre;
            DirectorValueLabel.Text = movie.Director;
            WriterValueLabel.Text = movie.Writer;
            ActorsValueLabel.Text = movie.Actors;
            PlotValueLabel.Text = movie.Plot;
            LanguageValueLabel.Text = movie.Language;
            CountryValueLabel.Text = movie.Country;
            if (movie.Poster != "N/A")
            {
                try
                {
                    MoviePoster.Load(movie.Poster);
                }
                catch (WebException exception) { }
            }
        }
    }
}

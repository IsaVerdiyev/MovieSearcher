using MovieSearcher.Exceptions;
using MovieSearcher.Model;
using MovieSearcher.Presenter;
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
    public partial class MainSearchView : Form, IMainSearchView
    {
        IMainSearchPresenter mainSearchPresenter;
        Dictionary<Movie, Task<bool>> resultsOfSearchOfFullMovieInfo;
        public MainSearchView()
        {
            InitializeComponent();
            mainSearchPresenter = new MainSearchPresenter(this);
        }

        public void UpdateListOfMovies()
        {
            ResultsListBox.DataSource = null;
            ResultsListBox.DataSource = mainSearchPresenter.Movies;
        }

        void SearchByTitle()
        {
            try
            {
                bool searchSuccess = mainSearchPresenter.SearchByTitle(SearchTextBox.Text);
                if (searchSuccess == false)
                {
                    return;
                }
                resultsOfSearchOfFullMovieInfo = new Dictionary<Movie, Task<bool>>();
                foreach (var movie in mainSearchPresenter.Movies)
                {
                    resultsOfSearchOfFullMovieInfo[movie] = mainSearchPresenter.GetMoreInfoAboutMovieAsync(movie);
                }
            }
            catch (WebException exception)
            {
                mainSearchPresenter.ZeroMoviesList();
                MessageBox.Show("WebException occured. Check internet connection.");
            }
            catch (TooManyResultsException exception)
            {
                mainSearchPresenter.ZeroMoviesList();
                MessageBox.Show(exception.Message);
            }
            catch (MovieNotFoundException exception)
            {
                mainSearchPresenter.ZeroMoviesList();
                MessageBox.Show(exception.Message);
            }
        }

        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchByTitle();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SearchByTitle();
            }
        }

        private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ResultsListBox.SelectedIndex != - 1)
            {
                Movie movie = ResultsListBox.SelectedItem as Movie;
                if(movie.Poster != "N/A")
                {
                    try
                    {
                        MoviePictureBox.Load(movie.Poster);
                    }catch(WebException ex) { }
                }
                else
                {
                    MoviePictureBox.Image = null;
                }
                MoreButton.Visible = true;
            }
            else
            {
                MoviePictureBox.Image = null;
                MoreButton.Visible = false;
            }
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            GerMoreInfoAboutMovie();
        }

        void GerMoreInfoAboutMovie()
        {
            Movie selectedMovie = ResultsListBox.SelectedItem as Movie;
            try
            {
                if(selectedMovie != null && resultsOfSearchOfFullMovieInfo[selectedMovie].Result == true)
                {
                    var fullInfoMovieView = new FullInfoMovieView(selectedMovie);
                    fullInfoMovieView.ShowDialog();
                }
            }
            catch(WebException exception)
            {
                MessageBox.Show("WebException occured. Check internet connection.");
            }
        }
    }
}

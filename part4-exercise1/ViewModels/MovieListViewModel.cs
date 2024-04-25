using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MovieCatalog.ViewModels;

public class MovieListViewModel: ObservableObject
{
    public ObservableCollection<MovieViewModel> Movies { get; set; }

    public MovieListViewModel() =>
        Movies = [];

    public async Task RefreshMovies()
    {
        IEnumerable<Models.Movie> moviesData = await Models.MoviesDatabase.GetMovies();

        foreach (Models.Movie movie in moviesData)
            Movies.Add(new MovieViewModel(movie));
    }

    public void DeleteMovie(MovieViewModel movie) =>
        Movies.Remove(movie);
}

using CommunityToolkit.Mvvm.ComponentModel;

namespace MovieCatalog.ViewModels;

public class MovieViewModel: ObservableObject
{
    private string _title;
    private string _studio;
    private string _director;
    private DateOnly _year;

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    public string Studio
    {
        get => _studio;
        set => SetProperty(ref _studio, value);
    }

    public string Director
    {
        get => _director;
        set => SetProperty(ref _director, value);
    }

    public DateOnly Year
    {
        get => _year;
        set => SetProperty(ref _year, value);
    }

    public MovieViewModel(Models.Movie movie)
    {
        _title = movie.Title;
        _studio = movie.Studio;
        _director = movie.Director;
        _year = new DateOnly(movie.Year, 1, 1);
    }
}

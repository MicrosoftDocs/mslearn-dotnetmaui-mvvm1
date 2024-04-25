namespace MovieCatalog.Views;

public partial class MoviesListPage : ContentPage
{
	public MoviesListPage()
	{
		InitializeComponent();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Navigation.PushAsync(new Views.MovieDetailPage());
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        MenuItem menuItem = (MenuItem)sender;
        ViewModels.MovieViewModel movie = (ViewModels.MovieViewModel)menuItem.BindingContext;
        App.MainViewModel.DeleteMovie(movie);
    }
}
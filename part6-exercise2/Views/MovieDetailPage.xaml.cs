namespace MovieCatalog.Views;

public partial class MovieDetailPage : ContentPage
{
    public MovieDetailPage()
    {
        BindingContext = App.MainViewModel.SelectedMovie;
        InitializeComponent();
    }
}
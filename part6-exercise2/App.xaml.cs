namespace MovieCatalog
{
    public partial class App : Application
    {
        public static ViewModels.MovieListViewModel MainViewModel { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            MainViewModel = new();
            MainViewModel.RefreshMovies();
        }
    }
}

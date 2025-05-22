using Maui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        LoginPage = new NavigationPage(new LoginPage());
    }
}

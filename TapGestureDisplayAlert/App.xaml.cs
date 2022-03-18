using TapGestureDisplayAlert.Pages;

namespace TapGestureDisplayAlert;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}

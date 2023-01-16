using th_pl.View; //
namespace th_pl;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();
        MainPage = new NavigationPage(new MainPageView()); //
    }
}

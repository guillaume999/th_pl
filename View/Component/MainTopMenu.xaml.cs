using th_pl.View.Preference;
namespace th_pl.View.Component;

public partial class MainTopMenu : ContentView
{
	public MainTopMenu()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_Preferences(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PreferencesView());
    }
}
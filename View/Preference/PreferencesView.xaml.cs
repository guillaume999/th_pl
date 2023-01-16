using th_pl.View.Preference.Component;
namespace th_pl.View.Preference;

public partial class PreferencesView : ContentPage
{
	public PreferencesView()
	{
		InitializeComponent();
		PreferencesBody.Content = new PreferencesViewMain();
    }
}
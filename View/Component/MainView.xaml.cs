using th_pl.Tools;
using th_pl.ViewModel;
using th_pl.View;
using th_pl.View.Logbook;
using th_pl.View.Bestiaire;

namespace th_pl.View.Component;

public partial class MainView : ContentView
{
    public MainView()
	{
		InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped_Set_Login(object sender, EventArgs e)
    {
        ImageBottomMenuChange.ImageChangeMenu(sender, e);
    }

    private void TapGestureRecognizer_Tapped_Delete_Login(object sender, EventArgs e)
    {
        ImageBottomMenuChange.ImageChangeMenu(sender, e);
    }

    private async void TapGestureRecognizer_Tapped_Logbook(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LogBookView());
    }

    private async void TapGestureRecognizer_Tapped_Bestiaire(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BestiaireView());
    }
}
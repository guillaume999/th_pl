using th_pl.Tools;
namespace th_pl.View.Bestiaire.Component;

public partial class BestiaireBottomMenu : ContentView
{
	public BestiaireBottomMenu()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        MenuHelper.ChangeMenu(sender, e);
    }
}
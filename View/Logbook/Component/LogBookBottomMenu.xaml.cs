using th_pl.Tools;
namespace th_pl.View.Logbook.Component;

public partial class LogBookBottomMenu : ContentView
{
	public LogBookBottomMenu()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        MenuHelper.ChangeMenu(sender, e);
    }
}
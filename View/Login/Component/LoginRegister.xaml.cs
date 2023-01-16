namespace th_pl.View.Login.Component;

public partial class LoginRegister : ContentView
{
	public LoginRegister()
	{
		InitializeComponent();
	}

    private async void TapGesture_GotoLoginPage(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
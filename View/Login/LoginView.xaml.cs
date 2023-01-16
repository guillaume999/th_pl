using th_pl.View.Login;
namespace th_pl.View.Login;

public partial class LoginView : ContentView
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void TapGesture_GotoForgotLoginPage(object sender, EventArgs e)
    {
        string var = "ForgotLogin";
        await Navigation.PushAsync(new LoginIssueView(var));
    }

    private async void TapGesture_GotoRegisterPage(object sender, EventArgs e)
    {
        string var = "RegisterLogin";
        await Navigation.PushAsync(new LoginIssueView(var));
    }
}
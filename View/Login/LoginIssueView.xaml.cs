using th_pl.View.Login.Component;
namespace th_pl.View.Login;

public partial class LoginIssueView : ContentPage
{
	public LoginIssueView(string infosURL)
	{
		InitializeComponent();
        QuelPage(infosURL);
	}

	private void QuelPage(string infosURL)
	{

        if (infosURL == "ForgotLogin")
        {
            LoginIssueBody.Content = new LoginForget();
        }
        else if (infosURL == "RegisterLogin")
        {
            LoginIssueBody.Content = new LoginRegister();
        }
    }
}
using th_pl.Tools;
using th_pl.View.Login;
namespace th_pl.View.Component;

public partial class MainBottomMenu : ContentView
{
	public MainBottomMenu()
	{
		InitializeComponent();

        if (Helper.HasLogin)
        {
            buttonbottomright.Source = "profil_noir.png";
        }
        else
        {
            buttonbottomright.Source = "profil_noir_add.png";
        }
    }

    private void TapGestureRecognizer_Tapped_ButtonBottom(object sender, EventArgs e)
    {
        ButtonBottomLoginURL.ChangeUrlLoginButton(sender, e);
    }

    // permet de changer l'image du menu depuis un autre code behind
    // donner un nom dans le content view de l'autre coté
    public void SetImageSourceButtonRight(string source)
    {
        buttonbottomright.Source = source;
    }
}
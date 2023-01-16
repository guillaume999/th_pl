using th_pl.Tools;
using th_pl.ViewModel;
using th_pl.View.Component;
using th_pl.View.Login;

namespace th_pl.View;

public partial class MainPageView : ContentPage
{
    string user_login = "samp";
    public MainPageView()
    {
        InitializeComponent();
        var mainView = new MainView();
        MainBody.Content = mainView;
        ImageBottomMenuChange.imageMenuChange += ImageBottomMenuChange_imageMenuChange;
        ButtonBottomLoginURL.UrlLoginButtonChange += ButtonBottomLoginURL_UrlLoginButtonChange;
    }

    // methode pour naviguer avec le BOTTOMMENU 
    // entre les Pages HOME/LOGIN/MEMBRE
    private void ButtonBottomLoginURL_UrlLoginButtonChange(object sender, EventArgs e)
    {
        string idGrid = (sender as Grid).AutomationId;
        if(idGrid == "home")
        {
            MainBody.Content = new MainView();
        }
        else if (idGrid == "login")
        {
            if (Helper.HasLogin)
            {
                MainBody.Content = new MemberView();
            }
            else
            {
                MainBody.Content = new LoginView();
            }
        }

    }


    // lorsqu'on click sur les boutons SET ou DELETE LOGIN on modifit le secureSTORAGE et l'image du bottomMenu
    private async void ImageBottomMenuChange_imageMenuChange(object sender, EventArgs e)
    {
        string idFrame = (sender as Frame).AutomationId;
        if (idFrame == "set_login")
        {
            mainBottomMenu.SetImageSourceButtonRight("profil_noir.png");
            await SetStorageUser();
        }
        else if(idFrame == "delete_login")
        {
            mainBottomMenu.SetImageSourceButtonRight("profil_noir_add.png");
            await DeleteStorageUser();
        }

        
    }

    //// SET security login/password exist
    public async Task SetStorageUser()
    {
        try
        {
            // recupère "user_login" dans le secure storage
            string userLogin = await SecureStorage.Default.GetAsync("user_login");
            // test si "user_login" exist
            // si il est null assigne une valeur
            // sinon renvoi le message qu'il existe deja
            if (userLogin == null)
            {
                await SecureStorage.Default.SetAsync("user_login", user_login);
                await DisplayAlert("login", "login set : " + user_login, "ok");
            }
            else
            {
                await SecureStorage.Default.SetAsync("user_login", user_login);
                await DisplayAlert("login", "login already set : " + user_login, "ok");
            }
        }
        catch
        {
            await DisplayAlert("unable", "to set login : " + user_login, "ok");
        }

    }

    //// SET security login/password exist
    public async Task DeleteStorageUser()
    {
            try
            {
                string userLogin = await SecureStorage.Default.GetAsync("user_login");
                if (userLogin != null)
                {
                    bool success = SecureStorage.Default.Remove("user_login");
                    await DisplayAlert("login", "login deleted : " + userLogin + " " + success, "ok");
                }
                else
                {
                    await DisplayAlert("login", "login dont exist : " + userLogin, "ok");
                }
            }
            catch
            {
                await DisplayAlert("UNABLE", "value : " + user_login, "OK");
            }

    }
}
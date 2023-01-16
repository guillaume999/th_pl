using System.Text.Json;
using th_pl.Tools;

using th_pl.ViewModel;

namespace th_pl.View.Preference.Component;

public partial class PreferencesViewMain : ContentView
{
    UserPreferences userPreferences = new UserPreferences();
    public PreferencesViewMain()
	{
		InitializeComponent();
		// tools/userpreferences ???? ne vient pas ici ?????

        //UserPreferences user = new UserPreferences();
        //user = CheckFilePrefExist(user);
        //BindingContext = user;

        BindingContext = userPreferences;

    }

    private void Switch_Toggled_hasLogin(object sender, ToggledEventArgs e)
    {
        // comment verifier avant de supprimer ????????
        //bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
        string _fileName = Path.Combine(FileSystem.AppDataDirectory, "preferences.txt");
        Dictionary<string, string> dicoPref = new(userPreferences.DicoPref);
        dicoPref["hasLogin"] = e.Value.ToString();
        string jsonPreferences = JsonSerializer.Serialize(dicoPref);
        File.WriteAllText(_fileName, jsonPreferences);
        if (!e.Value)
        {
            string userLogin = SecureStorage.Default.GetAsync("user_login").ToString();
            if (userLogin != null)
            {
                bool success = SecureStorage.Default.Remove("user_login");
            }
        }
    }

    private void Switch_Toggled_hasConnexion(object sender, ToggledEventArgs e)
    {
        string _fileName = Path.Combine(FileSystem.AppDataDirectory, "preferences.txt");
        Dictionary<string, string> dicoPref = new(userPreferences.DicoPref);
        bool value = e.Value;
        dicoPref["hasConnexion"] = e.Value.ToString();

        string jsonPreferences = JsonSerializer.Serialize(dicoPref);
        File.WriteAllText(_fileName, jsonPreferences);
    }

}
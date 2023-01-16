using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace th_pl.Tools
{
    public class UserPreferences : ObservableObject //: INotifyPropertyChanged
    {


        private Dictionary<string, string> dicoPref = new();
        public Dictionary<string, string> DicoPref
        {
            get => dicoPref;
            set
            {
                dicoPref = value;
                OnPropertyChanged(); // Méthode de la classe mère
            }
        }


        public UserPreferences()
        {
            DicoExist();
        }

        public void DicoExist()
        {

            string _fileName = Path.Combine(FileSystem.AppDataDirectory, "preferences.txt");
            if (!File.Exists(_fileName))
            {
                DicoPref.Add("hasLogin", "false");
                DicoPref.Add("hasConnexion", "false");
                
                string jsonPreferences = JsonSerializer.Serialize(DicoPref);
                File.WriteAllText(_fileName, jsonPreferences);
            }
            else
            {
                string jsonPreferences = File.ReadAllText(_fileName);
                DicoPref = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonPreferences);
            }
        }


        //public event PropertyChangedEventHandler PropertyChanged;
        //string _fileName = Path.Combine(FileSystem.AppDataDirectory, "preferences.txt");

        //private string hasLogin;
        //private string hasConnexion;

        //public string HasLogin
        //{
        //    get { return hasLogin; }
        //    set { 
        //            hasLogin = value;
        //            OnPropertyChanged();
        //        }
        //}
        //public string HasConnexion
        //{
        //    get { return hasConnexion; }
        //    set { hasConnexion = value; OnPropertyChanged(); }
        //}


        //public void CheckFilePrefExist()
        //{
        //    if (!File.Exists(_fileName))
        //    {
        //        UserPreferences userPreferences = new UserPreferences();
        //        userPreferences.HasLogin = "false";
        //        userPreferences.HasConnexion = "false";
        //        string jsonPreferences = JsonSerializer.Serialize(userPreferences);
        //        File.WriteAllText(_fileName, jsonPreferences);
        //    }
        //    else if (File.Exists(_fileName))
        //    {
        //        string jsonPreferences = File.ReadAllText(_fileName);
        //        UserPreferences userPreferences = new UserPreferences();
        //        userPreferences = JsonSerializer.Deserialize<UserPreferences>(jsonPreferences);
        //    }
        //}




    }
}

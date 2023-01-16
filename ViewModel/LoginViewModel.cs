using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.ViewModel
{
    internal class LoginViewModel : ObservableObject //: BaseNotifyViewModel
    {
        //string user_login = "sampLogin";
        // SET security login/password exist
        //public async Task SetStorageUser()
        //{
        //    try
        //    {
        //        string userLogin = await SecureStorage.Default.GetAsync("user_login");

        //        if (userLogin == null)
        //        {
        //            await SecureStorage.Default.SetAsync("user_login", user_login);
        //            await DisplayAlert("login", "login set : " + user_login, "ok");
        //        }
        //        else
        //        {
        //            await DisplayAlert("login", "login already set : " + userLogin, "ok");
        //        }

        //    }
        //    catch
        //    {
        //        await DisplayAlert("UNABLE", "value : " + user_login, "OK");
        //    }

        //}



        private Dictionary<string, string> dico = new();
        public Dictionary<string, string> Dico
        {
            get => dico;
            set
            {
                dico = value;
                OnPropertyChanged(); // Méthode de la classe mère
            }
        }


        public LoginViewModel()
        {
            

            for (int i = 0; i < 10; i++)
            {
                Dico.Add($"Key{i}", $"Value{i}");
            }

        }



    }
}

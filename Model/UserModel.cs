using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class UserModel : BaseModel
    {
        // Propriété
        private string userLoginName = string.Empty;
        public string UserLoginName
        {
            get => userLoginName;
            set => SetProperty(ref userLoginName, value);
        }

        // Propriété
        private string userPassword = string.Empty;
        public string UserPassword
        {
            get => userPassword;
            set => SetProperty(ref userPassword, value);
        }

        // Propriété
        private string userPhoto = string.Empty;
        public string UserPhoto
        {
            get => userPhoto;
            set => SetProperty(ref userPhoto, value);
        }

        // Propriété
        private string userEmail = string.Empty;
        public string UserEmail
        {
            get => userEmail;
            set => SetProperty(ref userEmail, value);
        }

        // Propriété
        private string userPublic = string.Empty;
        public string UserPublic
        {
            get => userPublic;
            set => SetProperty(ref userPublic, value);
        }

        // Propriété
        private string userLevel = string.Empty;
        public string UserLevel
        {
            get => userLevel;
            set => SetProperty(ref userLevel, value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class DiverModel : BaseModel
    {
        // Propriété
        private string diverPseudo = string.Empty;
        public string DiverPseudo
        {
            get => diverPseudo;
            set => SetProperty(ref diverPseudo, value);
        }

        // Propriété
        private UserModel user;
        public UserModel User
        {
            get => user;
            set => SetProperty(ref user, value);
        }
    }
}

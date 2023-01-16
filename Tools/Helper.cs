using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Tools
{
    public class Helper
    {
        public static bool HasLogin =>
           !string.IsNullOrEmpty(SecureStorage.Default.GetAsync("user_login").GetAwaiter().GetResult());

    }

}
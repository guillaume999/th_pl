using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Tools
{
    public static class ButtonBottomLoginURL
    {
        public static event EventHandler UrlLoginButtonChange;

        public static void ChangeUrlLoginButton(object sender, EventArgs e)
        {
            UrlLoginButtonChange(sender, e);
        }
    }
}

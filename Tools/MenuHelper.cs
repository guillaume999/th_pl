using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Tools
{
    public static class MenuHelper
    {
        public static event EventHandler MenuChange;

        public static void ChangeMenu(object sender, EventArgs e)
        {
            MenuChange(sender, e);
        }
    }
}

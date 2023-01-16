using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Tools
{
    public static class ImageBottomMenuChange
    {
        public static event EventHandler imageMenuChange;

        public static void ImageChangeMenu(object sender, EventArgs e)
        {
            imageMenuChange(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class DiveSpotModel : BaseModel
    {
        // Propriété
        private string diveSpotName = string.Empty;
        public string DiveSpotName
        {
            get => diveSpotName;
            set => SetProperty(ref diveSpotName, value);
        }

        // Propriété
        // Point GPS
        private string diveSpotLocalisation = string.Empty;
        public string DiveSpotLocalisation
        {
            get => diveSpotLocalisation;
            set => SetProperty(ref diveSpotLocalisation, value);
        }

        // Propriété
        private string diveSpotPays = string.Empty;
        public string DiveSpotPays
        {
            get => diveSpotPays;
            set => SetProperty(ref diveSpotPays, value);
        }

        // Propriété
        private string diveSpotRegion = string.Empty;
        public string DiveSpotRegion
        {
            get => diveSpotRegion;
            set => SetProperty(ref diveSpotRegion, value);
        }
    }
}

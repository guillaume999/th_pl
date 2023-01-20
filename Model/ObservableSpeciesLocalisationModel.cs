using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class ObservableSpeciesLocalisationModel : BaseModel
    {
        // Propriété
        // Point GPS
        private string observableSpeciesLocalisationLocalisation = string.Empty;
        public string ObservableSpeciesLocalisationLocalisation
        {
            get => observableSpeciesLocalisationLocalisation;
            set => SetProperty(ref observableSpeciesLocalisationLocalisation, value);
        }

        // Propriété
        private string observableSpeciesLocalisationRegion = string.Empty;
        public string ObservableSpeciesLocalisationRegion
        {
            get => observableSpeciesLocalisationRegion;
            set => SetProperty(ref observableSpeciesLocalisationRegion, value);
        }

        // Propriété
        private string observableSpeciesLocalisationPays = string.Empty;
        public string ObservableSpeciesLocalisationPays
        {
            get => observableSpeciesLocalisationPays;
            set => SetProperty(ref observableSpeciesLocalisationPays, value);
        }

        // Propriété
        private int observableSpeciesLocalisationQutt;
        public int ObservableSpeciesLocalisationQutt
        {
            get => observableSpeciesLocalisationQutt;
            set => SetProperty(ref observableSpeciesLocalisationQutt, value);
        }
    }
}

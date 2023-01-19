using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class ObservableSpecies : BaseModel
    {

        // Propriété
        private string observableSpeciesName = string.Empty;
        public string ObservableSpeciesName
        {
            get => observableSpeciesName;
            set => SetProperty(ref observableSpeciesName, value);
        }

        // Propriété
        // DOIT ETRE UNE LIST !!!
        private ObservableSpeciesImage observableSpeciesImage;
        public ObservableSpeciesImage ObservableSpeciesImage
        {
            get => observableSpeciesImage;
            set => SetProperty(ref observableSpeciesImage, value);
        }

        // Propriété
        private ObservableSpeciesDescription observableSpeciesDescription;
        public ObservableSpeciesDescription ObservableSpeciesDescription
        {
            get => observableSpeciesDescription;
            set => SetProperty(ref observableSpeciesDescription, value);
        }

        // Propriété
        private ObservableSpeciesLocalisation observableSpeciesLocalisation;
        public ObservableSpeciesLocalisation ObservableSpeciesLocalisation
        {
            get => observableSpeciesLocalisation;
            set => SetProperty(ref observableSpeciesLocalisation, value);
        }
    }
}

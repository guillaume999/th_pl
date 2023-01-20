using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class ObservableSpeciesModel : BaseModel
    {

        // Propriété
        private string observableSpeciesName = string.Empty;
        public string ObservableSpeciesName
        {
            get => observableSpeciesName;
            set => SetProperty(ref observableSpeciesName, value);
        }

        //// Propriété
        //// DOIT ETRE UNE LIST !!!
        //private ObservableSpeciesImageModel observableSpeciesImage;
        //public ObservableSpeciesImageModel ObservableSpeciesImage
        //{
        //    get => observableSpeciesImage;
        //    set => SetProperty(ref observableSpeciesImage, value);
        //}

        //// Propriété
        //private ObservableSpeciesDescriptionModel observableSpeciesDescription;
        //public ObservableSpeciesDescriptionModel ObservableSpeciesDescription
        //{
        //    get => observableSpeciesDescription;
        //    set => SetProperty(ref observableSpeciesDescription, value);
        //}

        //// Propriété
        //private ObservableSpeciesLocalisationModel observableSpeciesLocalisation;
        //public ObservableSpeciesLocalisationModel ObservableSpeciesLocalisation
        //{
        //    get => observableSpeciesLocalisation;
        //    set => SetProperty(ref observableSpeciesLocalisation, value);
        //}
    }
}

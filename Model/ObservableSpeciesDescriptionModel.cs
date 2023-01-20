using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class ObservableSpeciesDescriptionModel : BaseModel
    {
        // Propriété
        private string observableSpeciesDescriptionLink = string.Empty;
        public string ObservableSpeciesDescriptionLink
        {
            get => observableSpeciesDescriptionLink;
            set => SetProperty(ref observableSpeciesDescriptionLink, value);
        }

        // Propriété
        private string observableSpeciesDescriptionEvaluation = string.Empty;
        public string ObservableSpeciesDescriptionEvaluation
        {
            get => observableSpeciesDescriptionEvaluation;
            set => SetProperty(ref observableSpeciesDescriptionEvaluation, value);
        }

        // Propriété
        private string observableSpeciesDescriptionQuttEvaluation = string.Empty;
        public string ObservableSpeciesDescriptionQuttEvaluation
        {
            get => observableSpeciesDescriptionQuttEvaluation;
            set => SetProperty(ref observableSpeciesDescriptionQuttEvaluation, value);
        }
    }
}

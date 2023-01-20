using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class ObservableSpeciesImageModel : BaseModel
    {
        // Propriété
        private string observableSpeciesImageLink = string.Empty;
        public string ObservableSpeciesImageLink
        {
            get => observableSpeciesImageLink;
            set => SetProperty(ref observableSpeciesImageLink, value);
        }

        // Propriété
        private string observableSpeciesImageEvaluation = string.Empty;
        public string ObservableSpeciesImageEvaluation
        {
            get => observableSpeciesImageEvaluation;
            set => SetProperty(ref observableSpeciesImageEvaluation, value);
        }

        // Propriété
        private string observableSpeciesImageQuttEvaluation = string.Empty;
        public string ObservableSpeciesImageQuttEvaluation
        {
            get => observableSpeciesImageQuttEvaluation;
            set => SetProperty(ref observableSpeciesImageQuttEvaluation, value);
        }
    }
}

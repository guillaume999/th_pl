using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.Model
{
    public class DiveModel : BaseModel
    {
        // Propriété
        // soit créer une liste locale dans sql light 
        // soit récupérer une liste depuis la bdd
        private string divecenter = string.Empty;
        public string Divecenter
        {
            get => divecenter;
            set => SetProperty(ref divecenter, value);
        }

        // Propriété
        private string divecenterlocalisation = string.Empty;
        public string Divecenterlocalisation
        {
            get => divecenterlocalisation;
            set => SetProperty(ref divecenterlocalisation, value);
        }

        // Propriété je voulais le mettre en "int"
        private string bateau = string.Empty;
        public string Bateau
        {
            get => bateau;
            set => SetProperty(ref bateau, value);
        }

        // Propriété je voulais le mettre en "int"
        private string moniteur = string.Empty;
        public string Moniteur
        {
            get => moniteur;
            set => SetProperty(ref moniteur, value);
        }


        // Propriété
        private DateTime date = DateTime.Now;
        public DateTime Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        // Propriété je voulais le mettre en "int"
        private string profondeur = string.Empty;
        public string Profondeur
        {
            get => profondeur;
            set => SetProperty(ref profondeur, value);
        }

        // Propriété je voulais le mettre en "int"
        private string duree = string.Empty;
        public string Duree
        {
            get => duree;
            set => SetProperty(ref duree, value);
        }

        // Propriété
        private string divespotname = string.Empty;
        public string Divespotname
        {
            get => divespotname;
            set => SetProperty(ref divespotname, value);
        }

        // Propriété
        private string divespotlocalisation = string.Empty;
        public string Divespotlocalisation
        {
            get => divespotlocalisation;
            set => SetProperty(ref divespotlocalisation, value);
        }


        // Propriété
        private string diverequipement = string.Empty;
        public string Diverequipement
        {
            get => diverequipement;
            set => SetProperty(ref diverequipement, value);
        }

        // Propriété
        private string observedSpecies = string.Empty;
        public string ObservedSpecies
        {
            get => observedSpecies;
            set => SetProperty(ref observedSpecies, value);
        }

    }
}

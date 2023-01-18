using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using th_pl.Model;

namespace th_pl.Repository
{
    public class DiveRepository : BaseRepository<DiveModel>
    {
        // Ajout des données de test (s'il n'y en a pas).
        public async void SeedData()
        {
            var currentData = await GetList();
            if (currentData.Count == 0)
            {
                await Insert(new DiveModel() { Id = 1, Date = DateTime.Now, DivespotLocalisation = "Côte Atlantique - TEST", ObservedSpecies = "Baleine - TEST" });
                await Insert(new DiveModel() { Id = 2, Date = DateTime.Now, DivespotLocalisation = "Corse - TEST", ObservedSpecies = "Tortue - TEST" });
                await Insert(new DiveModel() { Id = 3, Date = DateTime.Now, DivespotLocalisation = "Côte bretonne - TEST", ObservedSpecies = "Requin - TEST" });
            }
        }
    }
}

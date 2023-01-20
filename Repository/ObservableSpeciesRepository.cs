using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using th_pl.Model;

namespace th_pl.Repository
{
    public class ObservableSpeciesRepository : BaseRepository<ObservableSpeciesModel>
    {

        // Ajout des données de test (s'il n'y en a pas).
        public async void SeedData()
        {
            var currentData = await GetList();
            if (currentData.Count == 0)
            {
                await Insert(new ObservableSpeciesModel() { Id = 1, ObservableSpeciesName = "poisson1" });
                await Insert(new ObservableSpeciesModel() { Id = 2, ObservableSpeciesName = "poisson2" });
                await Insert(new ObservableSpeciesModel() { Id = 3, ObservableSpeciesName = "poisson3" });
            }
        }
    }
}

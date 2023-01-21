using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using th_pl.Model;
using th_pl.Repository;

namespace th_pl.ViewModel
{
    public class BestiaireMainViewModel : ObservableObject
    {
        private ObservableCollection<ObservableSpeciesModel> species;
        public ObservableCollection<ObservableSpeciesModel> Species
        {
            get => species;
            set => SetProperty(ref species, value);
        }

        private ObservableSpeciesRepository Repository { get; set; } = new();

        private ObservableSpeciesModel currentObservableSpecies;
        public ObservableSpeciesModel CurrentObservableSpecies
        {
            get => currentObservableSpecies;
            set => SetProperty(ref currentObservableSpecies, value);
        }

        public ICommand GetListCommand { get; set; }

        public ICommand SetCurrentObservableSpeciesCommand { get; set; }

        public BestiaireMainViewModel()
        {
            GetListCommand = new RelayCommand(async () => await GetList());
            //SetCurrentObservableSpeciesCommand = new RelayCommand<ObservableSpeciesModel>(SetObservableSpeciesModel);
        }

        private async Task GetList()
        {
            //Repository.SeedData();
            var list = await Repository.GetList();
            if (list != null)
            {
                Species = new ObservableCollection<ObservableSpeciesModel>(list);
            }
            else
            {
                Repository.SeedData();
                list = await Repository.GetList();
                Species = new ObservableCollection<ObservableSpeciesModel>(list);
            }
        }

        private void SetObservableSpeciesModel(ObservableSpeciesModel observableSpeciesModel)
        {
            CurrentObservableSpecies = observableSpeciesModel;
        }
    }
}

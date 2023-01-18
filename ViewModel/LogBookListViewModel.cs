using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using th_pl.Model;
using th_pl.Repository;

namespace th_pl.ViewModel
{
    // ViewModel qui sera utilisé pour afficher la liste des DiveModel
    // et le detail d'un DiveModel
    public class LogBookListViewModel : ObservableObject
    {
        private ObservableCollection<DiveModel> dives;
        public ObservableCollection<DiveModel> Dives
        {
            get => dives;
            set => SetProperty(ref dives, value);
        }

        private DiveRepository Repository { get; set; } = new();

        private DiveModel currentDive;
        public DiveModel CurrentDive
        {
            get => currentDive;
            set => SetProperty(ref currentDive, value);
        }

        public ICommand GetListCommand { get; set; }

        public ICommand SetCurrentDiveCommand { get; set; }

        public LogBookListViewModel()
        {
            GetListCommand = new RelayCommand(async () => await GetList());
            SetCurrentDiveCommand = new RelayCommand<DiveModel>(SetDiveModel);
		}

		private async Task GetList()
        {
            //Repository.SeedData();
            var list = await Repository.GetList();
            if(list != null)
			{
				Dives = new ObservableCollection<DiveModel>(list);
			}
        }

		private void SetDiveModel(DiveModel diveModel)
        {
            CurrentDive = diveModel;
        }
    }
}

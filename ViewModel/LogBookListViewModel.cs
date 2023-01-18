using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using th_pl.Model;
using th_pl.Repository;

namespace th_pl.ViewModel
{
    // ViewModel qui sera utilisé pour afficher la liste des DiveModel
    // et le detail d'un DiveModel
    public class LogBookListViewModel : ObservableObject
    {
        public ObservableCollection<DiveModel> Dives { get; set; }

        private DiveRepository Repository { get; set; } = new();

        public DiveModel CurrentDive { get; set; } = new();

        public LogBookListViewModel()
        {
            var list = Repository.GetList().GetAwaiter().GetResult();
			Dives = new ObservableCollection<DiveModel>(list);
        }

        public void SetDiveModel(DiveModel diveModel)
        {
            CurrentDive = diveModel;
        }
    }
}

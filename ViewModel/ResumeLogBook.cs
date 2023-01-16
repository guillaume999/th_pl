using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_pl.ViewModel
{
    internal class ResumeLogBook : BaseNotifyViewModel
    {
        private Dictionary<string, string> dicoResumeLogBook = new();
        public Dictionary<string, string> DicoResumeLogBook
        {
            get => dicoResumeLogBook;
            set
            {
                dicoResumeLogBook = value;
                OnPropertyChanged(); // Méthode de la classe mère
            }
        }

        private ObservableCollection<string> dataStrings = new();
        public ObservableCollection<string> DataStrings
        {
            get => dataStrings;
            set
            {
                dataStrings = value;
                OnPropertyChanged(); // Méthode de la classe mère
            }
        }

        public ResumeLogBook()
        {
            DataStrings.Add("Item1");
            DataStrings.Add("Item2");
            DataStrings.Add("Item3");
            DataStrings.Add("Item4");

            for (int i = 0; i < 4; i++)
            {
                DicoResumeLogBook.Add($"Key{i}", $"Value{i}");
            }

            //PressButtonCommand = new Command(PressButton);
        }
    }
}

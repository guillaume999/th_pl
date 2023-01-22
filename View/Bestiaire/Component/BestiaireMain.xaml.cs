using th_pl.ViewModel;
using th_pl.Model;
using th_pl.View.Bestiaire.Component;
using System.Collections.ObjectModel;
using th_pl.Repository;
using Microsoft.Maui.Controls;

namespace th_pl.View.Bestiaire.Component;

public partial class BestiaireMain : ContentView
{
    //private readonly BestiaireMainViewModel ViewModel;
    ObservableSpeciesRepository database;
    public ObservableCollection<ObservableSpeciesModel> Species { get; set; } = new();
    public BestiaireMain()
	{
		InitializeComponent();
        database = new ObservableSpeciesRepository();
        BindingContext = this;
    }

    //protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //    base.OnNavigatedTo(args);
    //    var items = await database.GetItemsAsync();
    //    MainThread.BeginInvokeOnMainThread(() =>
    //    {
    //        Species.Clear();
    //        foreach (var item in items)
    //            Species.Add(item);

    //    });
    //}



    async void OnItemAdded(object sender, EventArgs e)
    {
        var species = await database.GetItemsAsync();
        var huhu = "huhu";
        //MainThread.BeginInvokeOnMainThread(() =>
        //{
        //    Species.Clear();
        //    foreach (var item in species)
        //        Species.Add(item);

        //});
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not ObservableSpeciesModel item)
            return;

        await Shell.Current.GoToAsync(nameof(BestiaireDetails), true, new Dictionary<string, object>
        {
            ["Item"] = item
        });
    }
}
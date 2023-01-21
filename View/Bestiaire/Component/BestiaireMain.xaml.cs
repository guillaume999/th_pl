using th_pl.ViewModel;
using th_pl.Model;
using th_pl.View.Bestiaire.Component;

namespace th_pl.View.Bestiaire.Component;

public partial class BestiaireMain : ContentView
{
    private readonly BestiaireMainViewModel ViewModel;
    public BestiaireMain()
	{
		InitializeComponent();
        //ViewModel = BindingContext as BestiaireMainViewModel;
    }
    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
    //    var observableSpeciesSelected = e.Item as ObservableSpeciesModel;
    //    ViewModel.SetCurrentObservableSpeciesCommand.Execute(observableSpeciesSelected);
    //    await Navigation.PushAsync(new BestiaireDetails() { BindingContext = ViewModel });
    }

    private void ContentView_Loaded(object sender, EventArgs e)
    {
        ViewModel.GetListCommand.Execute(null);
    }
}
using th_pl.Model;
using th_pl.ViewModel;

namespace th_pl.View.Logbook.Component;

public partial class LogBookList : ContentView
{
	private LogBookListViewModel ViewModel;

	public LogBookList()
	{
		InitializeComponent();
		ViewModel = BindingContext as LogBookListViewModel;
	}

	private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var diveSelected = e.Item as DiveModel;
		ViewModel.SetDiveModel(diveSelected);
		await Navigation.PushModalAsync(new LogBookDiveDetails());
	}
}
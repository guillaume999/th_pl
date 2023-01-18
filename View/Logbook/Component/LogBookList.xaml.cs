using th_pl.Model;
using th_pl.ViewModel;

namespace th_pl.View.Logbook.Component;

public partial class LogBookList : ContentView
{
	private readonly LogBookListViewModel ViewModel;

	public LogBookList()
	{
		InitializeComponent();
		ViewModel = BindingContext as LogBookListViewModel;
	}

	private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var diveSelected = e.Item as DiveModel;
		ViewModel.SetCurrentDiveCommand.Execute(diveSelected);
		await Navigation.PushAsync(new LogBookDiveDetails() { BindingContext = ViewModel });
	}

	private void ContentView_Loaded(object sender, EventArgs e)
	{
		ViewModel.GetListCommand.Execute(null);
	}
}
using th_pl.View.Bestiaire.Component;
namespace th_pl.View.Bestiaire;

public partial class BestiaireView : ContentPage
{
	public BestiaireView()
	{
		InitializeComponent();

        var bestiaireMain = new BestiaireMain();
        Body.Content = bestiaireMain;
    }
}
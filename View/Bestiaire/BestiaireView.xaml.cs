using th_pl.View.Bestiaire.Component;
using th_pl.Tools;
namespace th_pl.View.Bestiaire;

public partial class BestiaireView : ContentPage
{
    private Dictionary<string, ContentView> dicoContentViews { get; set; }
    public BestiaireView()
	{
		InitializeComponent();

        var bestiaireMain = new BestiaireMain();
        Body.Content = bestiaireMain;
        MenuHelper.MenuChange += MenuHelper_MenuChange;
        dicoContentViews = new Dictionary<string, ContentView>
        {
            {"list.png", bestiaireMain },
            {"valid.png", new BestiaireValid() },
            {"add.png", new BestiaireAdd() }
        };
    }

    private void MenuHelper_MenuChange(object sender, EventArgs e)
    {
        string bodyAsk = (sender as Image).Source.ToString();
        int found = bodyAsk.IndexOf("/");
        string bodyPage = bodyAsk.Substring(found + 1);
        Body.Content = dicoContentViews[(bodyPage)];
    }





}
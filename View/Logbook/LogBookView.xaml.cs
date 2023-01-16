using th_pl.View.Component;
using th_pl.Tools;
using th_pl.View.Logbook.Component;

namespace th_pl.View.Logbook;

public partial class LogBookView : ContentPage
{
    private Dictionary<string, ContentView> dicoContentViews { get; set; }

    public LogBookView()
	{
		InitializeComponent();

        var logBookResume = new LogBookResume();
        Body.Content = logBookResume;
        MenuHelper.MenuChange += MenuHelper_MenuChange;
        dicoContentViews = new Dictionary<string, ContentView>
        {
            {"stats.png", logBookResume },
            {"list.png", new LogBookList() },
            {"add.png", new LogBookAdd() }
        };
    }

    private void MenuHelper_MenuChange(object sender, EventArgs e)
    {
        string bodyAsk = (sender as Image).Source.ToString();
        int found = bodyAsk.IndexOf("/");
        string bodyPage = bodyAsk.Substring(found +1);
        Body.Content = dicoContentViews[(bodyPage)];
    }

}
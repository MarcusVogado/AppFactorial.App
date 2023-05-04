using AppFactorial.Pages;
namespace AppFactorial;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new InitialPage();
	}
    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnResume()
    {
        base.OnResume();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }
}

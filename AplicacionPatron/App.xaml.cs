using AplicacionPatron.Data;

namespace AplicacionPatron;

public partial class App : Application
{
	public static CarroBDD carroRepo {get; private set;}
	public App(CarroBDD repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		carroRepo = repo;
	}
}

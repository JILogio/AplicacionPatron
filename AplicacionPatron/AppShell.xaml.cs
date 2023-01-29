using AplicacionPatron.Views;

namespace AplicacionPatron;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("AddCarro", typeof(CarroIndex));
	}
}

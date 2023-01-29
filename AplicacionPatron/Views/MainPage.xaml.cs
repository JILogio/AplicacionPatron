namespace AplicacionPatron.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void AddClicked(object sender,EventArgs e)
	{
		await Shell.Current.GoToAsync("AddCarro");
	}

	private async void ComprarClicked(object sender,EventArgs e)
	{
		await Shell.Current.GoToAsync("BuyCarro");
	}
}
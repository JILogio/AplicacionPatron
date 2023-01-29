using AplicacionPatron.Models;

namespace AplicacionPatron.Views;

public partial class CarroIndex : ContentPage
{
	Carro car = new Carro();
	public CarroIndex()
	{
		InitializeComponent();
	}

	public async void GuardarClicked(object sender, EventArgs e)
	{
		car.Marca = marca.Text;
		car.Modelo = modelo.Text;
		car.costo = decimal.Parse(cost.Text);
		if(String.IsNullOrEmpty(car.Marca) || String.IsNullOrEmpty(car.Modelo) || car.costo <= 0)
		{
			return;
		}
		App.carroRepo.AddCarro(car);
		await Shell.Current.GoToAsync("..");
	}

	public async void CancelarClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
}
using AplicacionPatron.Models;

namespace AplicacionPatron.Views;

public partial class BuyIndex : ContentPage
{
    Comprador comprador = new Comprador();
    Gerente gerente = new Gerente();
    Carro select;
	public BuyIndex()
	{
		InitializeComponent();
        C_List.ItemsSource = GetList();
        comprador.AgregarSiguiente(gerente);
	}
    private async void selected(object sender, SelectionChangedEventArgs e)
    {
        select = e.CurrentSelection[0] as Carro;
        string aprob = comprador.Procesar(select);
        string mensaje = "Ha comprado " + select.Marca + " por $ " + select.costo;
        bool resp = await DisplayAlert("Confirmar","Esta a punto de comprar un carro por: $ " + select.costo.ToString(),"Si","No");
        if(resp == true)
        {
            await DisplayAlert("Finalizado",aprob,"OK");
            App.carroRepo.DeleteCarro(select);
            C_List.ItemsSource = GetList();
        }
    }

    private static List<Carro> GetList()
    {
        List<Carro> carros = App.carroRepo.GetCarros();
        return carros;
    }
}

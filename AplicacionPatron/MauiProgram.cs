using AplicacionPatron.Data;

namespace AplicacionPatron;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		string dbPath = FileAccessHelper.GetLocalFilePath("carro.db3");
		builder.Services.AddSingleton<CarroBDD>(s => ActivatorUtilities.CreateInstance<CarroBDD>(s, dbPath));

		return builder.Build();
	}
}

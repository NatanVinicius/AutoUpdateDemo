using Microsoft.UI.Xaml;
using Velopack;

namespace AutoUpdateDemo.WinUI;

public partial class App : MauiWinUIApplication
{
	public App()
	{
		VelopackApp.Build().Run();

		InitializeComponent();
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
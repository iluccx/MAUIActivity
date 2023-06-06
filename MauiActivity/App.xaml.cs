using MauiActivity.MVVM.Views;
namespace MauiActivity;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new NavigationPage(new DatabaseView());
	}
}

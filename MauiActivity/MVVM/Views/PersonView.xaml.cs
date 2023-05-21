using MauiActivity.MVVM.Models;
namespace MauiActivity.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonView();
	}
}
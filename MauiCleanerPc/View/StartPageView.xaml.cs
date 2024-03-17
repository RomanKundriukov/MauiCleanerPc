using MauiCleanerPc.ViewModel;

namespace MauiCleanerPc.View;

public partial class StartPageView : ContentPage
{
	public StartPageView(StartPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
	}
}
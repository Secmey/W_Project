using W_Project.Services;

namespace W_Project.Pages;


public partial class LoadingPage : ContentPage
{
	private readonly IsAuthenticated _isAuthenticated;

	public LoadingPage(IsAuthenticated isAuthenticated)
	{
		InitializeComponent();
		_isAuthenticated = isAuthenticated;	
	}


	protected async override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);



		if(await _isAuthenticated.IsAuthenicatedAsync())
		{
			//User is loggin in
			// 
			//await Shell.Current.GoToAsync($"{nameof(MainPage)}");
		}

		else
		{
			//USer is not logge in 
			//await Shell.Current.GoToAsync($"{nameof(LoginPage)}")
		}
	}

	
}
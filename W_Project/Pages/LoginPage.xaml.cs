using W_Project.UserLogin;

namespace W_Project.Pages;

public partial class LoginPage : ContentPage
{
	public UserLoginViewModel UserLoginViewModel;
	public LoginPage()
	{

		InitializeComponent();
		UserLoginViewModel = new UserLoginViewModel();
		BindingContext = UserLoginViewModel;

	}

}
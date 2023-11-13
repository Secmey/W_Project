using W_Project.Pages;

namespace W_Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            // Open the Login Page when App starting
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
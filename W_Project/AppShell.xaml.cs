namespace W_Project
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Pages.Contents), typeof(Pages.Contents));
            Routing.RegisterRoute(nameof(Pages.ListingPage), typeof(Pages.ListingPage));
            Routing.RegisterRoute(nameof(Pages.LoadingPage), typeof(Pages.LoadingPage));
            Routing.RegisterRoute(nameof(Pages.LoginPage), typeof(Pages.LoginPage));
            //Routing.RegisterRoute(nameof(Pages.LoadingPage), typeof(Pages.LoginPage));

        }
    }
}
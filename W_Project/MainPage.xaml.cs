namespace W_Project
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

        }
        // Lädt die Methode OnAppearing und überschreibt diese mit SetHasBackButton
        protected override void OnAppearing()
        {
            base.OnAppearing();

            NavigationPage.SetHasBackButton(this, false);

        }
    }
}
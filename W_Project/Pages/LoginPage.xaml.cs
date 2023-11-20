using SkiaSharp.Extended.UI.Controls;

namespace W_Project.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        double TargetX = loginbutton.X + 200;

        // Erstellen Sie die Animation
        var animation = new Animation(v => lottieview.TranslationX = v, lottieview.TranslationX, TargetX);

        // Fügen Sie das Completed-Ereignis hinzu
        animation.Commit(lottieview, "LottieAnimation", 16, 2000, Easing.CubicIn, (v, c) =>
        {
            // Diese Aktion wird ausgeführt, wenn die Animation abgeschlossen ist
            var nextpage = new MainPage();
            Navigation?.PushAsync(nextpage);
        });
    }
}

  

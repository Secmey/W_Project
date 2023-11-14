using W_Project.CustomControls;
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

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderLessEntry), (handler, view) =>
            {
#if ANDROID
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
//#elif __IOS__
//                 handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
//                 handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;

#endif
            });
        }
    }
}
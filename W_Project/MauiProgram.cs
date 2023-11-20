﻿using Microsoft.Extensions.Logging;
using W_Project.CustomControls;
using W_Project.Pages;
using W_Project.Services;
using SkiaSharp.Extended.UI.Controls;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace W_Project
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            


            return builder.Build();
        }
    }
}


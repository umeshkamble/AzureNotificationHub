﻿using AzureNotificationMaui.Platforms.Android;
using AzureNotificationMaui.Services;
using Microsoft.Extensions.Logging;

namespace AzureNotificationMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })

               .RegisterServices()
               .RegisterViews();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IDeviceInstallationService, DeviceInstallationService>();
            builder.Services.AddSingleton<IPushDemoNotificationActionService, PushDemoNotificationActionService>();
            builder.Services.AddSingleton<INotificationRegistrationService>(new NotificationRegistrationService(Config.BackendServiceEndpoint, Config.ApiKey));

            return builder;
        }
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<MainPage>();
            return builder;
        }
    }
}

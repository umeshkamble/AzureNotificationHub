using AzureNotificationMaui.Models;
using AzureNotificationMaui.Services;

namespace AzureNotificationMaui
{
    public partial class App : Application
    {
        readonly IPushDemoNotificationActionService _actionService;

        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new AppShell();
        //}
        public App(IPushDemoNotificationActionService service)
        {
            InitializeComponent();

            _actionService = service;
            _actionService.ActionTriggered += NotificationActionTriggered;

            MainPage = new AppShell();
        }
        void NotificationActionTriggered(object sender, PushDemoAction e)
        {
            ShowActionAlert(e);
        }

        void ShowActionAlert(PushDemoAction action)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                MainPage?.DisplayAlert("Push notifications demo", $"{action} action received.", "OK")
                    .ContinueWith((task) =>
                    {
                        if (task.IsFaulted)
                            throw task.Exception;
                    });
            });
        }
    }
}

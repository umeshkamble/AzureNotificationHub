using AzureNotificationMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureNotificationMaui.Services
{
    public interface IPushDemoNotificationActionService : INotificationActionService
    {
        event EventHandler<PushDemoAction> ActionTriggered;
    }
}

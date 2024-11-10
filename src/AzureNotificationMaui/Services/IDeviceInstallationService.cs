using AzureNotificationMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureNotificationMaui.Services
{
    public interface IDeviceInstallationService
    {
        string Token { get; set; }
        bool NotificationsSupported { get; }
        string GetDeviceId();
        DeviceInstallation GetDeviceInstallation(params string[] tags);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureNotificationMaui.Services
{
    public interface INotificationActionService
    {
        void TriggerAction(string action);
    }
}

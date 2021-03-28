using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    
        public interface INotificationObserver
        {

            public void EmailNotification();
            public void WhatsAppNotification();
            public void SMSNotification();
            public string EventName { get; set; }
        }
    

}

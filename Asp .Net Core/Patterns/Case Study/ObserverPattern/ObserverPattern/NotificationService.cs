using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    
        public class NotificationService : INotificationService
        {

            public List<INotificationObserver> subscribers;
            public string eventName { get; set; }
            public string EventName { get => eventName; set => eventName = value; }

            public NotificationService()
            {
                subscribers = new List<INotificationObserver>();

            }

            public void Subscribe(INotificationObserver name)
            {
                subscribers.Add(name);
            }

            public void NotifyAdmins()
            {
                foreach (var i in subscribers)
                {
                    i.EventName = eventName;
                    i.EmailNotification();
                    i.WhatsAppNotification();
                    i.SMSNotification();
                }
            }

            public void UnSubscribe(INotificationObserver name)
            {
                subscribers.Remove(name);
            }
        }
    

}

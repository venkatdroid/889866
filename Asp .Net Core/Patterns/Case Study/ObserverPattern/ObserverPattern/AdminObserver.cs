
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class AdminObserver : INotificationObserver

    {

        public INotificationService notification;

        public AdminObserver(INotificationService notification)
        {
            this.notification = notification;
        }
        public string eventName { get; set; }
        public string EventName { get => eventName; set => eventName = value; }

        public void EmailNotification()
        {
            Console.WriteLine("Email Notification\nHi Admin,\nTicket Count for the event {0} exceeded", eventName);

        }

        public void SMSNotification()
        {
            Console.WriteLine("SMS Notification\nTicket Count exceeded for the event {0}", eventName);

        }

        public void WhatsAppNotification()
        {
            Console.WriteLine("WhatsApp Notification\nTicket Count exceeded for the event {0}", eventName);


        }
    }
}

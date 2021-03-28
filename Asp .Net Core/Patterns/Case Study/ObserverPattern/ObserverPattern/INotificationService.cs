using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    
        public interface INotificationService
        {
            void Subscribe(INotificationObserver observer);
            void UnSubscribe(INotificationObserver observer);
            void NotifyAdmins();
            public string EventName { get; set; }
        }
    

}

using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationService notificationObserver = new NotificationService();
            INotificationObserver adminObserver = new AdminObserver(notificationObserver);
            notificationObserver.Subscribe(adminObserver);
            Console.WriteLine("Cultral Program");
            Dictionary<string, int> events = new Dictionary<string, int>();
            events.Add("Singing Event", 28);
            events.Add("Face Painting Event",70);
            foreach (KeyValuePair<string, int> entry in events)
            {
                Console.WriteLine(entry.Key);
            }
            Console.WriteLine("Book tickets? Please enter Yes");
            string status = Console.ReadLine();
            while (status == "yes")
            {
                Console.WriteLine("Event Name");
                string eventName = Console.ReadLine();
                Console.WriteLine("Number of tickets");
                int noOfTickets = Int32.Parse(Console.ReadLine());
                int totalTickets = events[eventName] + noOfTickets;
                events[eventName] = totalTickets;
                Console.WriteLine("Wish to Continue?");
                status = Console.ReadLine();
            }
            foreach (KeyValuePair<string, int> entry in events)
            {
                if (entry.Value > 100)
                {

                    notificationObserver.EventName = entry.Key;
                    notificationObserver.NotifyAdmins();
                }
            }
            notificationObserver.UnSubscribe(adminObserver);
            foreach (KeyValuePair<string, int> entry in events)
            {
                if (entry.Value > 100)
                {
                    notificationObserver.EventName = entry.Key;
                    notificationObserver.NotifyAdmins();
                }
            }
        }
    }
}

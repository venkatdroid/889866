using System;

namespace ObserverPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();
            MessageSubscriberTwo s2 = new MessageSubscriberTwo();
            MessageSubscriberThree s3 = new MessageSubscriberThree();
            MessageSubscriberOne s4 = new MessageSubscriberOne();
            MessagePublisher p = new MessagePublisher();
            p.attach(s1);
            p.attach(s2);
            p.notifyUpdate(new Message("Initial State")); 
            p.detach(s1);
            p.attach(s3);
            p.UpdateState(1);
            p.attach(s4);
            p.UpdateState(1);

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class MessagePublisher : Subject
    {
        
        private List<Observer> observers = new List<Observer>();

        private int GetState = 1;

        public int getState { get => GetState; set => value = GetState; }

        public void attach(Observer o)
        {
            observers.Add(o);
        }

        public void detach(Observer o) {
            observers.Remove(o);
        }


        public void notifyUpdate(Message m) {
            foreach(Observer o in observers)
            {
                o.update(m);
                
            }
        }
        public void UpdateState(int stateValue)
        {
            if (stateValue==getState)
            { 
                notifyUpdate(new Message("State is Updated"));
            }
        }
    }
}
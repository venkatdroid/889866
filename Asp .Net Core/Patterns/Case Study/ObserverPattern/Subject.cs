using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface Subject
    {
        public void attach(Observer o);
        public void detach(Observer o);
        public void notifyUpdate(Message m);
        public int getState { get; set; }
    }
}

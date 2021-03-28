using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public interface IChatMediator
    {
        public void AddUser(IUser user);
        public void SendMessage(string message,IUser user);
    }

    public class ChatMediator : IChatMediator {

        public List<IUser> Users = new List<IUser>();

        public ChatMediator() { }

        public void AddUser(IUser user)
        {
            Users.Add(user);
            Console.WriteLine("USer Added"); 
            
        }

        public void SendMessage(string message ,IUser user)
        {
            foreach (var u in Users) {
                if(u != user)
                u.ReceiveMessage(message);
            }
        }
    }
}

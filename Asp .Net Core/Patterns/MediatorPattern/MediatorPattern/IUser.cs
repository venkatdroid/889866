using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public interface IUser
    {
        public void ReceiveMessage(string Message);
        public void SendMessage(String Message);
    }

    public class BasicUser : IUser {

        ChatMediator chatMediator;
        string Name;

        public BasicUser(ChatMediator chatMed, string name) {

            chatMediator = chatMed;
            Name = name;
        }

        public void ReceiveMessage(string Message)
        {
            Console.WriteLine($"Message Received  by {Name} : {Message}");
        }

        public void SendMessage(string Message)
        {
            chatMediator.SendMessage(Message,this);
        }
    }

    public class PremiumUser : IUser
    {

        ChatMediator chatMediator;
        string Name;

        public PremiumUser(ChatMediator chatMed, string name)
        {

            chatMediator = chatMed;
            Name = name;
        }

        public void ReceiveMessage(string Message)
        {
            Console.WriteLine($"Message Received  by {Name} : {Message}");
        }

        public void SendMessage(string Message)
        {
            chatMediator.SendMessage(Message, this);
        }
    }
}

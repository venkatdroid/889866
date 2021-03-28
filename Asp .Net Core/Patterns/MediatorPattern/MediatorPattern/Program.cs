using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator ChatMed = new ChatMediator();
            IUser Sam = new BasicUser(ChatMed, "Sam");
            IUser Ram = new BasicUser(ChatMed, "Ram");
            IUser Tam = new BasicUser(ChatMed, "Tam");
            IUser Pam = new PremiumUser(ChatMed, "Pam");

            ChatMed.AddUser(Sam);
            ChatMed.AddUser(Ram);
            ChatMed.AddUser(Tam);
            ChatMed.AddUser(Pam);

            Console.WriteLine();

            Sam.SendMessage("Hello All !!!");
            Console.WriteLine();
            Console.Read();

        }
    }
}

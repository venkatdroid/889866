using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory mer = new MercedesFactory();
            Client merCl = new Client(mer);

            Console.WriteLine("********* MERCEDES **********");
            Console.WriteLine(merCl.GetHeadLightDetails());
            Console.WriteLine(merCl.GetTireDetails());

            Factory aud = new AudiFactory();
            Client audCl = new Client(aud);

            Console.WriteLine("********* AUDI **********");
            Console.WriteLine(audCl.GetHeadLightDetails());
            Console.WriteLine(audCl.GetTireDetails());
        }
    }
}

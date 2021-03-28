using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable bugattiVeyron = new BugattiVeyron(); 
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);

            Console.WriteLine("Car price in USD :"+bugattiVeyron.getPrice());
            Console.WriteLine();
            Console.WriteLine("Car price in Euros :"+bugattiVeyronAdapter.getPrice());
        }
    }
}

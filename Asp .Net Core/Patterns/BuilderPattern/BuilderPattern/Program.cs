using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder b1 = new ChildPackage();
            Builder b2 = new AdultPackage();

            Console.WriteLine("--------Child Package--------");
            director.Construct(b1);
            Product p1 = b1.GetProduct();
            p1.ShowProducts();

            Console.WriteLine();

            Console.WriteLine("--------Adult Package--------");
            director.Construct(b2);
            Product p2 = b2.GetProduct();
            p2.ShowProducts();

            Console.ReadKey();
        }
    }
}

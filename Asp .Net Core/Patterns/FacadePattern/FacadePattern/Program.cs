using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker sm = new ShapeMaker();

            sm.drawCircle();
            Console.WriteLine();
            sm.drawRectangle();
            Console.WriteLine();
            sm.drawSquare();
            Console.WriteLine();
        }
    }
}

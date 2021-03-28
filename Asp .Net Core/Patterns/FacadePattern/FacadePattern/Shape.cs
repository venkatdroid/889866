using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    interface Shape
    {
        public void draw();
    }

    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle !!");
        }
    }

    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle !!");
        }
    }
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Square !!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class ShapeMaker
    {
        Shape cir ;
        Shape rec ;
        Shape sqr ; 

        public ShapeMaker() {
            cir = new Circle();
            rec = new Rectangle();
            sqr = new Square();
        }

        public void drawCircle() {
            cir.draw();
        }

        public void drawRectangle()
        {
            rec.draw();
        }

        public void drawSquare()
        {
            sqr.draw();
        }
    }
}

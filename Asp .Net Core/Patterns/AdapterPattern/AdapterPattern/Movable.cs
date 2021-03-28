using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface Movable
    { // returns speed in MPH 
        double getSpeed();
        double getPrice();
    }


    public class BugattiVeyron : Movable {
        
        public double getSpeed() 
        { 
        return 268; 
        }

        public double getPrice() {

            return 100000;
        }

}
}
    

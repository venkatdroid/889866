using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class HeadLight
    {
        public abstract string getHeadLightDetails();
    }

    class MercedesHeadlight : HeadLight {
        
        public override string getHeadLightDetails()
        {
            /*Console.WriteLine("Mercedes Headlight");*/
            return "Mercedes Headlight";
        }

        
    
    }

    class AudiHeadlight : HeadLight
    {

        public override string getHeadLightDetails()
        {
            return "Audi Headlight";
        }



    }
}

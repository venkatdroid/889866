using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class Tire
    {
        public abstract string getTireDetails();
    }

    class MercedesTire : Tire
    {
        public override string getTireDetails()
        {
            return "Mercedes Tires";
        }
    }

    class AudiTire : Tire
    {
        public override string getTireDetails()
        {
            return "Audi Tires";
        }
    }
}

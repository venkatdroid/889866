using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class Factory
    {
        public abstract HeadLight makeHeadlight();
        public abstract Tire makeTire();
    }

    class MercedesFactory : Factory {

        public  override HeadLight makeHeadlight() {
            HeadLight mh = new MercedesHeadlight();
            return mh;
        
        }

        public override Tire makeTire()
        {
            Tire mt = new MercedesTire();
            return mt;
        }
    }

    class AudiFactory : Factory
    {

        public override HeadLight makeHeadlight()
        {
            HeadLight ah = new AudiHeadlight();
            return ah;

        }

        public override Tire makeTire()
        {
            Tire at = new AudiTire();
            return at;
        }
    }
}

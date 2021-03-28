using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Client
    {
        HeadLight hl;
        Tire tr;

        public Client(Factory factory) {

            hl = factory.makeHeadlight();
            tr = factory.makeTire();
        }

        public string GetHeadLightDetails() {

            return hl.getHeadLightDetails();
        }

        public string GetTireDetails() {

            return tr.getTireDetails();
        }
    }
}

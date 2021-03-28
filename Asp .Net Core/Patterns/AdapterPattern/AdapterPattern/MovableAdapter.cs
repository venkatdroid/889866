using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface MovableAdapter
    {
        double getSpeed();
        double getPrice();
    }

    public class MovableAdapterImpl : MovableAdapter {

        private Movable luxuryCars;

        public MovableAdapterImpl(Movable lc) {

            luxuryCars = lc;
        }

        public double getSpeed() {

            return convertMPHtoKMPH(luxuryCars.getSpeed());
        }

        public double getPrice() {

            return convertUSDtoEuro(luxuryCars.getPrice());

        }

        public double convertMPHtoKMPH(double mph) {

            return mph * 1.60934;
        }

        public double convertUSDtoEuro(double usd) {

            return usd * 0.84;
        }
    }
}

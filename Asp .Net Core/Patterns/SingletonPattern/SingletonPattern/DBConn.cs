using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class DBConn
    {
        private static DBConn instance = null;

        private DBConn() { 
        
        }

        /*public DBConn Instance {
            get {
                if (instance == null)
                  instance = getInstance();

                return instance;
            }
        }*/

        public static DBConn  getInstance() {

            if (instance == null)
                instance = new DBConn();
            return instance;
        }
    }


}

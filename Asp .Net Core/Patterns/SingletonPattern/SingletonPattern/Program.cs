using System;

namespace SingletonPattern
{
    class Program
    {
        public static void Main(string[] arg){
        DBConn d1 = DBConn.getInstance();
        DBConn d2 = DBConn.getInstance();

            if (d1 == d2)
                Console.WriteLine("d1 == d2 Same Instances");
            else
                Console.WriteLine("Different Instances");


       }

    }
}

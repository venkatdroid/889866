using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class Product
    {
        List<string> productItems = new List<string>();

        public void Add(string item) {

            productItems.Add(item);
        }

        public void ShowProducts() {
            Console.WriteLine("--------Product Items--------");
            foreach (string item in productItems) {
                Console.WriteLine(item);
            }
        }
    }
}

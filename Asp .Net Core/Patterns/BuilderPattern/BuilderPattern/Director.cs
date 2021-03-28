using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class Director
    {
        public void Construct(Builder builder) {

            builder.AddSweets();
            builder.AddSavories();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    abstract class Builder

    {
        public abstract void AddSweets();
        public abstract void AddSavories();
        public abstract Product GetProduct();
    }

    class ChildPackage : Builder
    {
        Product _product = new Product();

        public override void AddSavories()
        {
            _product.Add("1 Savory");
        }

        public override void AddSweets()
        {
            _product.Add("2 Sweets");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }

    class AdultPackage : Builder
    {
        Product _product = new Product();

        public override void AddSavories()
        {
            _product.Add("2 Savories");
        }

        public override void AddSweets()
        {
            _product.Add("2 Sweets");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}

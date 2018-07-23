using System;
using System.Collections.Generic;
using System.Text;

namespace challenge2
{
    class ConcreteFactoryY: AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            ProductA product = new ProductAY();
            return product;
        }

        public override ProductB CreateProductB()
        {
            ProductB product = new ProductBY();
            return product;
        }
    }
}

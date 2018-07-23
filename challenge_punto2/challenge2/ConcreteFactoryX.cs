using System;
using System.Collections.Generic;
using System.Text;

namespace challenge2
{
    class ConcreteFactoryX: AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            ProductA product = new ProductAX();
            return product;
        }

        public override ProductB CreateProductB()
        {
            ProductB product = new ProductBX();
            return product;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace challenge2
{
    enum Types
    {
        X,
        Y
    }

    abstract class AbstractFactory
    {
        public abstract ProductA CreateProductA();
        public abstract ProductB CreateProductB();

        public static AbstractFactory GetFactory(Types t)
        {
            AbstractFactory factory = new ConcreteFactoryX();
            switch (t)
            {
                case Types.X:
                    factory = new ConcreteFactoryX();
                break;
                case Types.Y:
                    factory = new ConcreteFactoryX();
                break;
            }
            return factory;
        }
    }

}

using System;

namespace challenge2
{
    class Client
    {
        private static AbstractFactory FactoryX = AbstractFactory.GetFactory(Types.X);
        private static AbstractFactory FactoryY = AbstractFactory.GetFactory(Types.Y);

        static void Main(string[] args)
        {

            ProductA productAX = FactoryX.CreateProductA();
            ProductA productAY = FactoryY.CreateProductA();
            ProductB productBX = FactoryX.CreateProductB();
            ProductB productBY = FactoryY.CreateProductB();

            Console.WriteLine(productAX.getName());
            Console.WriteLine(productBX.getName());
            Console.WriteLine(productAY.getName());
            Console.WriteLine(productBY.getName());
        }
    }
}

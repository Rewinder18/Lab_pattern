using System;

namespace KosnikBet.Patterns.AbstractFactory
{
    internal interface IFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    internal class FirstFactory: IFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductAForFirstFactory();
        }

        public IProductB CreateProductB()
        {
            return new ProductBForFirstFactory();
        }
    }

    internal class SecondFactory: IFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductAForSecondFactory();
        }
        public IProductB CreateProductB()
        {
            return new ProductBForSecondFactory();
        }
    }
}

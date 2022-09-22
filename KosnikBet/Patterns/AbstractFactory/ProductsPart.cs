using System;

namespace KosnikBet.Patterns.AbstractFactory
{
    internal interface IProductA
    {
        void DoSomethingWithProductA();
    }

    internal interface IProductB
    {
        void DoSomethingWithProductB();
    }

    internal class ProductAForFirstFactory: IProductA
    {
        public void DoSomethingWithProductA()
        {
            throw new NotImplementedException();
        }
    }

    internal class ProductBForFirstFactory: IProductB
    {
        public void DoSomethingWithProductB()
        {
            throw new NotImplementedException();
        }
    }

    internal class ProductAForSecondFactory: IProductA
    {
        public void DoSomethingWithProductA()
        {
            throw new NotImplementedException();
        }
    }

    internal class ProductBForSecondFactory: IProductB
    {
        public void DoSomethingWithProductB()
        {
            throw new NotImplementedException(); 
        }
    }
}

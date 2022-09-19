namespace KosnikBet.Patterns.FactoryMethod
{
    internal abstract class AbstractFactory
    {
        public abstract IProduct CreateProduct();
    }

    internal class FirstFactory: AbstractFactory
    {
        public override IProduct CreateProduct()
        {
            return new FirstProduct();
        }
    }

    internal class SecondFactory: AbstractFactory
    {
        public override IProduct CreateProduct()
        {
            return new SecondProduct();
        }
    }
}

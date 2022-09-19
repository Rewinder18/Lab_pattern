namespace KosnikBet.Patterns.FactoryMethod
{
    internal interface IProduct
    {
        void DoSomething();
    }

    internal class FirstProduct: IProduct
    {
        public void DoSomething()
        {
            
        }
    }
    internal class SecondProduct: IProduct
    {
        public void DoSomething()
        {

        }
    }
}

namespace KosnikBet.Patterns.Singletone
{
    internal sealed class Singletone
    {
        private static Singletone _instance;

        private Singletone()
        {

        }

        public static Singletone GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singletone();
            }

            return _instance;
        }
    }
}

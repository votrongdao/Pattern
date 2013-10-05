namespace Singelton
{
    /// <summary>
    /// Singleton realizaiotn in simple type
    /// For using with theard need realise MethodImpl attribute or use lock() 
    /// </summary>
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton(){}

        public static Singleton GetSingleton
        {
            get { return _instance ?? (_instance = new Singleton()); }
        }
    }
}

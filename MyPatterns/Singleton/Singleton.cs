namespace Singleton
{
    /// <summary>
    /// Singleton might be useful when we need to create one or only one instance (or number of instances shouldn't exceed fixed number).
    /// This is the only situation when this pattern can be used and you should think twice before implementing it.
    /// Problems:
    /// - singleton violates SRP;
    /// - antipattern called «singletonism» based on unsing singleton pattern all over the places;
    /// - works badly with multi-threading.
    /// </summary>
    public class Singleton
    {
        private static Singleton _instance;

        private string _name;
        private Singleton(string name)
        {
            _name = name;
        }

        public static Singleton GetInstance(string name)
        {
            if (_instance == null)
            {
                _instance = new(name);
            }
            return _instance;
        }

        public string GetName()
        {
            return _name;
        }
    }
}

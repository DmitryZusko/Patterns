namespace State
{
    internal class Program
    {
        /// <summary>
        /// Sometimes behavoiral of the class depends on it's state. If it changes frequently or we have a large number of 
        /// states - State pattern could be a good solution. We take out state fields and depending methods to a separate 
        /// classes that inherence «IState» interface. So when we need to switch between states, we just pass a new 
        /// state object.
        /// </summary>
        static void Main(string[] args)
        {
            var player = new Player { Weapon = new Sword()};
            for (int i = 0; i < 10; i++)
            {
                player.DisplayActions();
                player.DoSomething(Console.ReadLine());
            }

            player.Weapon = new Bow();
            for (int i = 0; i < 10; i++)
            {
                player.DisplayActions();
                player.DoSomething(Console.ReadLine());
            }
        }
    }
}
namespace State
{
    public class Bow : IWeapon
    {
        private int _arrowNumber = 1;
        public void Attack()
        {
            Console.WriteLine($"You've shot {_arrowNumber} arrow(-s)");
            _arrowNumber = 1;
        }

        public void LoadBow() 
        {
            _arrowNumber++;
            Console.WriteLine("You've loaded one arrow");
        }

        public void Evade()
        {
            Console.WriteLine("You are trying to evade an enemy attack");
        }

        public void DisplayActions()
        {
            Console.WriteLine($"1 - {nameof(Attack)}, 2 - {nameof(LoadBow)}, 3 - {nameof(Evade)}");
        }

        public void DoSomething(string action)
        {
            switch (action)
            {
                case "1":
                    {
                        Attack();
                        break;
                    }
                case "2":
                    {
                        LoadBow();
                        break;
                    }
                case "3":
                    {
                        Evade();
                        break;
                    }
                default: { break; }
            }
        }
    }
}
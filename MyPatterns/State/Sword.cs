namespace State
{
    public class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("You attacked with a light attack");
        }

        public void AttackHeavy()
        {
            Console.WriteLine("You attacked with a heavy attack");
        }

        public void Block()
        {
            Console.WriteLine("You are blocking");
        }

        public void DisplayActions()
        {
            Console.WriteLine($"1 - {nameof(Attack)}, 2 - {nameof(AttackHeavy)}, 3 - {nameof(Block)}");
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
                        AttackHeavy();
                        break;
                    }
                case "3":
                    {
                        Block();
                        break;
                    }
                default: { break; }
            }
        }
    }
}
namespace State
{
    public interface IWeapon
    {
        public void Attack();
        public void DisplayActions();

        public void DoSomething(string action);
    }
}
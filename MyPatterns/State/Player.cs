namespace State
{
    public class Player
    {
        public IWeapon Weapon { get; set; }

        public void DisplayActions()
        {
            Weapon.DisplayActions();
        }
        public void DoSomething(string action)
        {
            Weapon.DoSomething(action);
        }
    }
}
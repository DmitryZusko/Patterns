namespace Composite
{
    public class Duck : IDuck
    {
        public void SayQuack()
        {
            Console.WriteLine("Quack-Quack, motherfucker!");
        }
    }
}
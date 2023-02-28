namespace Composite
{
    public class DuckPack : IDuck
    {
        private List<IDuck> _duckPack;
        public DuckPack(List<IDuck> duckPack)
        {
            _duckPack = duckPack;
        }
        public void SayQuack()
        {
            foreach (var duck in _duckPack)
            {
                duck.SayQuack();
            }
        }
    }
}
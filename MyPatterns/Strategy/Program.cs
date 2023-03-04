namespace Strategy
{
    internal class Program
    {
        /// <summary>
        /// Strategy pattern allows us to change an algorithm of a concrete method in runtime. It's pretty same to the 
        /// State pattern, but algorithm of a method doesn't depends on a state of object; behavior is chosen by a user.
        /// </summary>
        static void Main(string[] args)
        {
            var values = new List<int> { 1, 8, 3, 4, 2, 9, 0, 7 };
            Console.WriteLine("Initial list:");
            foreach (var item in values)
            {
                Console.Write(item);
            }
            var container = new Container { Values = values, SortStartegy = new BubbleSortStrategy() };
            var result = container.Sort();
            foreach (var item in result)
            {
                Console.Write(item);
            }

            container = new Container { Values = values, SortStartegy = new MergeSortStrategy() };
            result = container.Sort();
            foreach (var item in result)
            {
                Console.Write(item);
            }

            container = new Container { Values = values, SortStartegy = new QuickSortStartegy() };
            result = container.Sort();
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
    }
}
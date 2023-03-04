namespace Strategy
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> values)
        {
            Console.WriteLine("\n\nBubbleSort!");
            for (int i = 0; i < values.Count() - 1; i++)
            {
                for (int j = i + 1; j < values.Count(); j++)
                {
                    if (values[j] < values[i])
                    {
                        (values[i], values[j]) = (values[j], values[i]);
                    }
                }
            }
            return values;
        }
    }
}
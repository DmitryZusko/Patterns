namespace Strategy
{
    public class Container
    {
        public List<int> Values { get; set; }
        public ISortStrategy SortStartegy { private get; set; }

        public List<int> Sort()
        {
            return SortStartegy.Sort(Values);
        }
    }
}
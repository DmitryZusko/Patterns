namespace Strategy
{
    public class MergeSortStrategy : ISortStrategy
    {
        private List<int> _values;
        public List<int> Sort(List<int> values)
        {
            Console.WriteLine("\n\nMergeSort!");
            if (values.Count < 2)
            {
                return values;
            }
            _values = values;
            MergeSort(0, values.Count - 1);
            return _values;
        }

        private void MergeSort(int leftIndex, int righIndex)
        {
            if (leftIndex < righIndex)
            {
                int middleIndex = (leftIndex + righIndex) / 2;
                MergeSort(leftIndex, middleIndex);
                MergeSort(middleIndex + 1, righIndex);
                MergeGlue(leftIndex, middleIndex, righIndex);
            }
        }

        private void MergeGlue(int leftIndex, int middleIndex, int rightIndex)
        {
            var buffer = new List<int>();
            var left = leftIndex;
            var right = middleIndex + 1;

            while (left <= middleIndex && right <= rightIndex)
            {
                if (_values[left] < _values[right])
                {
                    buffer.Add(_values[left]);
                    left++;
                }
                else
                {
                    buffer.Add(_values[right]);
                    right++;
                }
            }

            if (left <= middleIndex)
            {
                buffer.AddRange(_values.GetRange(left, middleIndex - left + 1));
            }

            if (right <= rightIndex)
            {
                buffer.AddRange(_values.GetRange(right, rightIndex - right + 1));
            }

            var result = new List<int>();
            result.AddRange(_values.GetRange(0, leftIndex));
            result.AddRange(buffer);
            result.AddRange(_values.GetRange(rightIndex + 1, _values.Count - rightIndex - 1));

            _values = result;
        }
    }
}
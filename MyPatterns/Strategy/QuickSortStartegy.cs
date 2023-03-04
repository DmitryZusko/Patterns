namespace Strategy
{
    public class QuickSortStartegy : ISortStrategy
    {
        private List<int> _values;
        public List<int> Sort(List<int> values)
        {
            Console.WriteLine("\n\nQuickSort!");
            _values = values;
            QuickSort(0, _values.Count - 1);
            return _values;
        }

        private void QuickSort(int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }
            var pivotIndex = GetPivotIndex(leftIndex, rightIndex);
            QuickSort(leftIndex, pivotIndex - 1);
            QuickSort(pivotIndex + 1, rightIndex);
        }

        private int GetPivotIndex(int leftIndex, int rightIndex)
        {
            var currentPivotIndex = leftIndex - 1;
            for (int i = leftIndex; i < rightIndex; i++)
            {
                if (_values[i] < _values[rightIndex])
                {
                    currentPivotIndex++;
                    (_values[i], _values[currentPivotIndex]) = (_values[currentPivotIndex], _values[i]);
                }
            }

            currentPivotIndex++;
            (_values[currentPivotIndex], _values[rightIndex]) = (_values[rightIndex], _values[currentPivotIndex]);

            return currentPivotIndex;
        }
    }
}
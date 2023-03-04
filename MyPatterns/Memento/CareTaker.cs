namespace Memento
{
    public class CareTaker
    {
        public IVeryImportant ImportantClass { get; set; }
        public Dictionary<DateTime, IMemento> BackUpHistory { get; } = new Dictionary<DateTime, IMemento>();

        public void BackUp()
        {
            BackUpHistory.Add(DateTime.Now, ImportantClass.MakeSnapshot());
        }

        public void RestoreLast()
        {
            var lastKey = BackUpHistory.Last().Key;
            BackUpHistory[lastKey].Restore(ImportantClass);
            BackUpHistory.Remove(lastKey);
        }

        public void ShowHistory()
        {
            foreach (var item in BackUpHistory)
            {
                Console.WriteLine($"{item.Key} -- {item.Value.GetFields()}");
            }
        }
    }
}
namespace Bridge
{
    public class WordImporter : IImporter
    {
        private IReport _report;

        public WordImporter(IReport report)
        {
            _report = report;
        }

        public void Import()
        {
            Console.WriteLine($"Importing into word:" +
                $"\n{_report.GetHeader()}" +
                $"\n{_report.GetBody()}" +
                $"\n{_report.GetFooter()}");
        }

        public void SetReport(IReport report)
        {
            _report = report;
        }
    }
}
namespace Bridge
{
    public class PDFImporter : IImporter
    {
        private IReport _report;
        public PDFImporter(IReport report)
        {
            _report = report;
        }
        public void Import()
        {
            Console.WriteLine($"Importing into PDF:" +
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
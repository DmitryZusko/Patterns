namespace Bridge
{
    internal class Program
    {
        /// <summary>
        /// Bridge pattern become handy when logic have two axises of change. In this example we can easily add new
        /// types of report or new importers without changin any line of code in already existing ones. All we need 
        /// is just create new class. 
        /// The only concern is really big and hard to figure out realization. 
        /// </summary>
        static void Main(string[] args)
        {
            var dailyReport = new DailyReport();
            dailyReport.CreateHeader();
            dailyReport.CreateBody();
            dailyReport.CreateFooter();

            var weeklyReport = new WeeklyReport();
            weeklyReport.CreateHeader();
            weeklyReport.CreateBody();
            weeklyReport.CreateFooter();

            IImporter importer = new PDFImporter(dailyReport);
            importer.Import();

            importer.SetReport(weeklyReport);
            importer.Import();

            importer = new WordImporter(dailyReport);
            importer.Import();

            importer.SetReport(weeklyReport);
            importer.Import();

            Console.ReadKey();
        }
    }
}
namespace Bridge
{
    public class WeeklyReport : IReport
    {
        private string _header;
        private string _body;
        private string _footer;

        public void CreateBody()
        {
            _body = "Weekly report body";
        }

        public void CreateFooter()
        {
            _footer = "Weekly report footer";
        }

        public void CreateHeader()
        {
            _header = "Weekly report header";
        }

        public string GetHeader() => _header;
        public string GetBody() => _body;
        public string GetFooter() => _footer;
    }
}
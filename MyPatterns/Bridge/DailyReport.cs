namespace Bridge
{
    public class DailyReport : IReport
    {
        private string _header;
        private string _body;
        private string _footer;
        public void CreateBody()
        {
            _body = "Daily report body";
        }

        public void CreateFooter()
        {
            _footer = "Daily report footer";
        }

        public void CreateHeader()
        {
            _header = "Daily report header";
        }

        public string GetHeader() => _header;
        public string GetBody() => _body;
        public string GetFooter() => _footer;
    }
}
namespace Bridge
{
    public interface IImporter
    {
        public void Import();
        public void SetReport(IReport report);
    }
}
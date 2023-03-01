using System.Reflection.PortableExecutable;

namespace Bridge
{
    public interface IReport
    {
        public void CreateHeader();
        public void CreateBody();
        public void CreateFooter();
        public string GetHeader();
        public string GetBody();
        public string GetFooter();

    }
}
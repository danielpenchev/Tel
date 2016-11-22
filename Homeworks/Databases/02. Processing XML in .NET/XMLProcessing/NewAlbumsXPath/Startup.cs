using System.Xml;

namespace NewAlbumsXPath
{
    class Startup
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");
            var query = "/catalogue/album[year>2001]/name";

            var albumNames = doc.SelectNodes(query);

            foreach (XmlNode name in albumNames)
            {
                System.Console.WriteLine(name.InnerText);
            }
        }
    }
}

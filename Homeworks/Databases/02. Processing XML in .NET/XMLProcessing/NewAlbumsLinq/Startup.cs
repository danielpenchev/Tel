using System;
using System.Linq;
using System.Xml.Linq;

namespace NewAlbumsLinq
{
    class Startup
    {
        static void Main()
        {
            var doc = XDocument.Load("../../../catalogue.xml");

            var albumsNodes = from album in doc.Descendants("album")
                              where int.Parse(album.Element("year").Value) > 2001
                              select album.Element("name").Value;

            Console.WriteLine(string.Join(Environment.NewLine, albumsNodes));
        }
    }
}

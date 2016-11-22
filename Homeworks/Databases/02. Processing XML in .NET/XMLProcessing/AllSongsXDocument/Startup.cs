﻿using System.Linq;
using System.Xml.Linq;

namespace AllSongsXDocument
{
    class Startup
    {
        static void Main()
        {
            var doc = XDocument.Load("../../../catalogue.xml");
            var albums = doc.Element("catalogue").Elements("album");

            var titles = from title in albums.Descendants("title") select title.Value;

            foreach (var title in titles)
            {
                System.Console.WriteLine(title);
            }
        }
    }
}

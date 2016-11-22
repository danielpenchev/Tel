using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextToXml
{
    class Startup
    {
        static void Main()
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                person.Name = reader.ReadLine();
                person.PhoneNumber = reader.ReadLine();
                person.Address = reader.ReadLine();
            }

            var personElement = new XElement("person",
                new XElement("name", person.Name),
                new XElement("phoneNumber", person.PhoneNumber),
                new XElement("address", person.Address));

            personElement.Save("../../person.xml");

            var currentDir = Directory.GetCurrentDirectory();
            var savedDir = currentDir.Substring(0, currentDir.IndexOf("bin\\Debug"));
            Console.WriteLine("person saved as" + savedDir + "person.xml");
        }
    }
}
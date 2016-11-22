using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Uri url = new Uri(input);
            var protocol = url.Scheme;
            var address = url.Authority;
            var resource = url.PathAndQuery;

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", address);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}

namespace Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Startup
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Svetlin", 25);
            Person secondPerson = new Person("Cuklev", 21);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}

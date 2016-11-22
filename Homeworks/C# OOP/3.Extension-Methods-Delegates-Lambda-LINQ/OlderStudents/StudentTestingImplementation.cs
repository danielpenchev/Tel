namespace OlderStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StudentTestingImplementation
    {
        public static void FirstNameBeforeLastName(Students[] array)
        {
            var students =
                from stud in array
                where stud.FirstName.CompareTo(stud.LastName) == -1
                select stud;

            Console.WriteLine("Students whos first name is before its last name alphabetically: ");

            foreach (var element in students)
            {
                Console.WriteLine("{0} {1}", element.FirstName, element.LastName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void StudentsWithGivenAge(Students[] array)
        {
            var students =
                from stud in array
                where (stud.Age >= 18 && stud.Age <= 24)
                select stud;

            Console.WriteLine("Students with age between 18 and 24: ");

            foreach (var element in students)
            {
                Console.WriteLine("{0} {1} {2}", element.FirstName, element.LastName, element.Age);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void StudentsUsingLambda(Students[] array)
        {
            var students = array.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName);
            Console.WriteLine("Sort students, using lambda expressions");

            foreach (var element in students)
            {
                Console.WriteLine("{0} {1}", element.FirstName, element.LastName);
            }
        }

        public static void SortStudentsUsingLINQ(Students[] array)
        {
            var students =
                from stud in array
                orderby stud.FirstName descending, stud.LastName descending
                select stud;

            Console.WriteLine("Sorting students using LINQ: ");

            foreach (var element in array)
            {
                Console.WriteLine("{0} {1}", element.FirstName, element.LastName);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroup
{
    public class StudentsGroupRun
    {
        static void Print(IEnumerable<Student> students)
        {
            foreach (var element in students)
            {
                Console.WriteLine("Name: {0} {1} \nFN: {2} \nPhone number: {3} \nMail: {4} \nGroup: {5} \nMarks: ",
                    element.FirstName,
                    element.LastName,
                    element.FN,
                    element.PhoneNumber,
                    element.Email,
                    element.Marks);

                foreach (var item in element.Marks)
                {
                    Console.WriteLine("{0}", item);
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("---------------");
        }

        static void SelectStudentsByGroupNumberWithLINQ(List<Student> array)
        {
            var students =
                from stud in array
                where stud.GroupNumber.GroupNumber == 2
                orderby stud.FirstName
                select stud;

            Console.WriteLine("Students from group number 2 are: (Using LINQ query) ");
            Print(students);
        }


        static void SelectStudentsByGroupNumberWithLambda(List<Student> array)
        {
            var students = array.Where(x => (x.GroupNumber.GroupNumber == 2)).OrderBy(x => x.FirstName);
            Console.WriteLine("Students from group 2 are: (Using Lambda expressions) ");
            Print(students);
        }

        static void ExtractStudentsByEmail(List<Student> array)
        {
            var students =
                from stud in array
                where stud.Email.EndsWith("abv.bg")
                select stud;

            Console.WriteLine("Students with e-mail: abv.bg");
            Print(students);
        }

        static void ExtractStudentsWithPhoneInSofia(List<Student> array)
        {
            var students =
                from stud in array
                where stud.PhoneNumber.StartsWith("02")
                select stud;

            Console.WriteLine("Students with phone number in Sofia: ");
            Print(students);
        }

        static void ExtractStudentsWithExcellentGrade(List<Student> array)
        {
            int searchedMark = 6;

            var students =
                from stud in array
                where stud.Marks.Contains(searchedMark)
                select new { FullName = stud.FirstName + " " + stud.LastName, Marks = stud.Marks };

            Console.WriteLine("Students with at least one excellent grade: ");

            foreach (var element in students)
            {
                Console.WriteLine("Full name: {0}", element.FullName);
                Console.Write("Marks: ");

                foreach (var item in element.Marks)
                {
                    Console.Write("{0} ", item);
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("---------------");
        }

        static void ExtractStudentsWithTwoPoorMarks(List<Student> array)
        {
            var searchedMark = 2;
            var timesFound = 2;

            var students =
                from stud in array
                where stud.Marks.Count(x => x == searchedMark) == timesFound
                select new { FullName = stud.FirstName + " " + stud.LastName, Marks = stud.Marks };

            Console.WriteLine("Students with two poor marks: ");

            foreach (var element in students)
            {
                Console.WriteLine("Full name: {0}", element.FullName);
                Console.Write("Marks: ");

                foreach (var item in element.Marks)
                {
                    Console.Write("{0}", item);
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("---------------");
        }

        static void ExtractStudentsMarks(List<Student> array)
        {
            var students =
                from stud in array
                where stud.FN.EndsWith("06")
                select stud;

            Console.WriteLine("Students marks enrolled in 2006: ");
            Print(students);
        }

        static void ExtractStudentsFromMathematicsDepartment(List<Student> array)
        {
            var students =
                from stud in array
                where stud.GroupNumber.DepartmentName == "Mathematics"
                select stud;

            Console.WriteLine("Students from \"Mathematics\" department: ");
            Print(students);
        }

        public static void Testing()
        {
            List<Student> list = new List<Student>()
            {
                new Student("Kristiyan", "Cuklev", "1234", "08888888888", "cuklev@abv.bg", new List<int> {6,6,6,6,6 }, new Group(2, "Computing")),
                new Student("Kon", "Simeonov", "1235", "0888111111", "kon@abv.bg", new List<int> { 2,3,4,5,6}, new Group(2, "Mathematics")),
                new Student("Doncho", "Donchov", "0101", "0888333333", "dokata@abv.bg", new List<int> { 5,6,5,6,5,6}, new Group(2, "Mathematics")),
                new Student("Svetlin", "Nacho", "1111", "0888062062", "naka@abv.bg", new List<int> { 7,7,7,7,7,7}, new Group(2, "Mathematics")),
                new Student("Kolio", "Kostov", "1212", "0000000001", "kaica@abv.bg", new List<int> { 6,6,6,6,6,6 }, new Group(2, "Mathematics")),
                new Student("Lionel", "Messi", "1112", "1010101010", "mesq@abv.bg", new List<int> { 2,2,2,2,2,2}, new Group(2, "Mathematics"))
            };

            SelectStudentsByGroupNumberWithLINQ(list);
            SelectStudentsByGroupNumberWithLambda(list);
            ExtractStudentsByEmail(list);
            ExtractStudentsWithPhoneInSofia(list);
            ExtractStudentsWithExcellentGrade(list);
            ExtractStudentsWithTwoPoorMarks(list);
            ExtractStudentsMarks(list);
            ExtractStudentsFromMathematicsDepartment(list);
        }
    }
}

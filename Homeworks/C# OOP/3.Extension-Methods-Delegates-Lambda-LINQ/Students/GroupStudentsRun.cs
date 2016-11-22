namespace GroupStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GroupStudentsRun
    {
        static void Print(IEnumerable<IEnumerable<GroupStudents>> array)
        {
            foreach (var group in array)
            {
                foreach (var element in group)
                {
                    Console.WriteLine("Full name: {0} {1} \nGroup name: {2}", element.FirstName, element.LastName, element.GroupName);
                }

                Console.WriteLine();
            }

            Console.WriteLine("--------------------------");
        }

        static void GroupStudentsByGroupNameUsingLINQ(List<GroupStudents> array)
        {
            var students =
                from stud in array
                group stud by stud.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;

            Console.WriteLine("Print students grouped by GroupName: (Using Linq query.) ");
            Print(students);
        }

        static void GroupStudentsByGroupNameUsingLambda(List<GroupStudents> array)
        {
            var students = array.GroupBy(x => x.GroupName).OrderBy(y => y.Key);
            Console.WriteLine("Print students grouped by GroupName: (Using Lambda expression.) ");
            Print(students);
        }

        public static void Testing()
        {
            List<GroupStudents> list = new List<GroupStudents>()
            {
                new GroupStudents("Kristiyan", "Cuklev", "Telerik"),
                new GroupStudents("Kon", "Sim", "Telerik"),
                new GroupStudents("Svetlin", "Nakov", "SoftUni"),
                new GroupStudents("Nikolay", "Kostov", "Hmmmmm"),
                new GroupStudents("Boiko", "Borisov", "GERB"),
                new GroupStudents("Slavi", "Trifonov", "bTV"),
                new GroupStudents("Hristo", "Stoichkov", "Telerik"),
            };

            GroupStudentsByGroupNameUsingLambda(list);
            GroupStudentsByGroupNameUsingLINQ(list);
        }
    }
}

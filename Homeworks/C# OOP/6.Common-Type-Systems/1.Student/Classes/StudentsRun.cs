namespace Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class StudentsRun
    {
        public static void Testing()
        {
            Student firstStudent = new Student("Plamen", "Svetlozarov", "Georgiev", 6612331, "Ruse", "08812345", "itplamen@gmail.com", 4, Universities.RU, Faculties.EEA, Specialties.KST);
            Student secondStudent = new Student("Pesho", "Petrov", "Ivanov", 113123, "Sofia", "0881111", "pesho@abv.bg", 1, Universities.SU, Faculties.Law, Specialties.Law);

            Console.WriteLine("First student equal to second student? {0}", Student.Equals(firstStudent, secondStudent)); // False
            Console.WriteLine("First student == second student? {0}", firstStudent == secondStudent); // False
            Console.WriteLine("Firs student != second student? {0}", firstStudent != secondStudent); // True
            Console.WriteLine();

            Student thirdStudent = new Student("Plamen", "Svetlozarov", "Georgiev", 6612331, "Ruse", "08812345", "itplamen@gmail.com", 4, Universities.RU, Faculties.EEA, Specialties.KST);

            Console.WriteLine("First student equal to third student? {0}", Student.Equals(firstStudent, thirdStudent)); // True
            Console.WriteLine("First student == third student? {0}", firstStudent == thirdStudent); // True;
            Console.WriteLine("First student != third student? {0}", firstStudent != thirdStudent); // False
            Console.WriteLine();

            Student cloned = firstStudent.Clone();
            Console.WriteLine("Cloned: ");
            Console.WriteLine(cloned);

            int compareStudents = firstStudent.CompareTo(secondStudent);
            Console.WriteLine("Compare result: " + compareStudents);
        }
    }
}

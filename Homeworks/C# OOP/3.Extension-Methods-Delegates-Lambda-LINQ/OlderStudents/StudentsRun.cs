namespace OlderStudents
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
            Students[] arrayOfStudents =
            {
                new Students("Kristiyan", "Cuklev", 20),
                new Students("Kon", "Simeonov", 21),
                new Students("Pesho", "Ot Akademiyata", 25),
                new Students("Gosho", "Ot Akademiyata", 26),
                new Students("Svetlin", "Nakov", 35)
            };

            StudentTestingImplementation.FirstNameBeforeLastName(arrayOfStudents);
            StudentTestingImplementation.StudentsWithGivenAge(arrayOfStudents);
            StudentTestingImplementation.StudentsUsingLambda(arrayOfStudents);
            StudentTestingImplementation.SortStudentsUsingLINQ(arrayOfStudents);
        }
    }
}

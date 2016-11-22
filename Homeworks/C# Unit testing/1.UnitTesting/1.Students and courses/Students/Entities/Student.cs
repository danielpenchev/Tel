using System;

namespace Students.Entities
{
    public class Student
    {
        private const int MinValidValue = 10000;
        private const int MaxValidValue = 99999;
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(Validator.StringIsInvalid(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get { return this.uniqueNumber; }
            set
            {
                if (!Validator.IdIsInRange(value, Student.MinValidValue, Student.MaxValidValue))
                {
                    throw new ArgumentException(string.Format("Student ID must be in range [{0} - {1}]", Student.MinValidValue, Student.MaxValidValue));
                }

                this.uniqueNumber = value;
            }
        }

        public void AttendCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            course.RemoveStudent(this);
        }
    }
}

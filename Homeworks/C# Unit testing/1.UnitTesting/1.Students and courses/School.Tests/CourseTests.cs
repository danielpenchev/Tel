namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Students.Entities;
    using System.Linq;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CourseShouldNotThrowError()
        {
            var course = new Course("CT");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWithNullName()
        {
            var course = new Course(null);
        }

        [TestMethod]
        public void CourseShouldReturnNameCorrectly()
        {
            var course = new Course("CT");

            Assert.AreEqual("CT", course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWithEmptyName()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void CourseShouldAddStudentCorrectly()
        {
            var course = new Course("CT");
            var student = new Student("Lesho", 10000);
            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenNullStudentAdded()
        {
            var course = new Course("CT");
            Student student = null;
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenExistingStudentAdded()
        {
            var course = new Course("CT");
            Student student = new Student("Lesho", 10000);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenMoreThanPossibleStudentsAdded()
        {
            var course = new Course("CT");

            for (int i = 0; i < 50; i++)
            {
                course.AddStudent(new Student(i.ToString(), 10000 + 1));
            }
        }

        [TestMethod]
        public void CourseShouldRemoveStudentCorrectly()
        {
            var course = new Course("CT");
            var student = new Student("Lesho", 10000);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count());
        }
    }
}

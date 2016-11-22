using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students.Entities;
using System.Linq;

namespace School.Tests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void SchoolShouldNotThrowException()
        {
            var school = new SchoolClass("Telerik");
        }

        [TestMethod]
        public void SchoolShouldReturnNameCorrectly()
        {
            var school = new SchoolClass("Telerik");
            Assert.AreEqual("Telerik", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNameIsNull()
        {
            var school = new SchoolClass(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNameIsEmpty()
        {
            var school = new SchoolClass(string.Empty);
        }

        [TestMethod]
        public void SchoolShouldAddStudentCorrectli()
        {
            var school = new SchoolClass("Telerik");
            var student = new Student("Lesho", 10000);
            school.AddStudent(student);
            Assert.AreSame(student, school.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNullStudentAdded()
        {
            var school = new SchoolClass("Telerik");
            Student student = null;
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenExistingStudentAdded()
        {
            var school = new SchoolClass("Telerik");
            var student = new Student("Lesho", 10000);
            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolShouldThrowExceptionWhenAddingStudentWithDuplicatedUniqueNumber()
        {
            var school = new SchoolClass("Telerik");
            var student = new Student("Kolio", 10000);
            var otherStudent = new Student("Pesho", 10000);
            school.AddStudent(student);
            school.AddStudent(otherStudent);
        }

        [TestMethod]
        public void SchoolShouldAddCourseCorrectly()
        {
            var school = new SchoolClass("Telerik");
            var course = new Course("CT");
            school.AddCourse(course);
            Assert.AreSame(course, school.Courses.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNullCourseAdded()
        {
            var school = new SchoolClass("Telerik");
            Course course = null;
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenExistingCourseAdded()
        {
            var school = new SchoolClass("Telerik");
            var course = new Course("CT");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void SchoolShouldRemoveStudentCorrectly()
        {
            var school = new SchoolClass("Telerik");
            var student = new Student("Pesho", 10000);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.IsTrue(school.Students.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenRemovingNullStudent()
        {
            var school = new SchoolClass("Telerik");
            Student student = null;
            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenRemovingNotExistingStudent()
        {
            var school = new SchoolClass("Telerik");
            var student = new Student("Pesho", 10000);
            school.RemoveStudent(student);
        }

        [TestMethod]
        public void SchoolShouldRemoveCourseCorrectly()
        {
            var school = new SchoolClass("Telerik");
            var course = new Course("CT");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenRemovingNullCourse()
        {
            var school = new SchoolClass("Telerik");
            Course course = null;
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionWhenRemovingNotExistingCrouse()
        {
            var school = new SchoolClass("Telerik");
            var course = new Course("CT");
            school.RemoveCourse(course);
        }
    }
}

namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Students.Entities;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentShouldNotThrowAnException()
        {
            var student = new Student("Pesho", 11111);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedName()
        {
            var student = new Student("Pesho", 11111);
            Assert.AreEqual("Pesho", student.Name);
        }
        
        [TestMethod]
        public void StudentShouldReturnExpectedUniqueNumber()
        {
            var student = new Student("Pesho", 10000);
            Assert.AreEqual(10000, student.UniqueNumber);
        }
         
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowAnExceptionForNullName()
        {
            var student = new Student(null, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowNullReferenceExceptionForEmptyName()
        {
            var student = new Student(string.Empty, 11111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowArgumentExceptionForInvalidUniqueNumber_Low()
        {
            var student = new Student("Pesho", 123);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowArgumentExceptionForInvalidUniqueNumber_High()
        {
            var student = new Student("Pesho", 123123);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenAttendingCourse()
        {
            var student = new Student("Pesho", 10000);
            var course = new Course("KPK");
            student.AttendCourse(course);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenLeavesCourse()
        {
            var student = new Student("Lesho", 12312);
            var course = new Course("KPK");
            student.AttendCourse(course);
            student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenAttendintNullCourse()
        {
            var student = new Student("Lesho", 12312);
            Course course = null;
            student.AttendCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenLeavingNullCourse()
        {
            var student = new Student("Lesho", 12312);
            Course course = null;
            student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenRemovingNullStudent()
        {
            var course = new Course("CT");
            Student student = null;
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenRemovingUnexistingStudent()
        {
            var course = new Course("CT");
            Student student = new Student("Lesho", 10000);
            course.RemoveStudent(student);
        }
    }
}

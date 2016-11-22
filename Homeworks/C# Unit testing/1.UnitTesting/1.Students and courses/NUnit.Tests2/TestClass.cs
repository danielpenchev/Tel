namespace NUnit.Tests2
{
    using NUnit.Framework;
    using Students.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class TestClass
    {
        [Test]
        public void NUnitStudentShouldNotThrowAnException()
        {
            var student = new Student("Gergi", 10000);
        }

        [Test]
        public void NUnitStudentShouldReturnExpectedName()
        {
            var student = new Student("Pesho", 10000);

            var expected = "Pesho";
            var actual = student.Name;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NUnitStudentShouldReturnExpectedUniqueNumber()
        {
            var student = new Student("Pesho", 10000);

            var expected = 10000;
            var actual = student.UniqueNumber;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(null)]
        public void NUnitStudentShouldThrowExceptionForNullName(string name)
        {
            var student = new Student(name, 10000);
            Assert.Throws<ArgumentException>(() => );
        }
    }
}

using NUnit.Framework;
using Students.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class CourseTests
    {
        [Test]
        public void StudentShouldThrowExceptionForNullName()
        {
            var student = new Student(null, 11111);

            Assert.Throws<ArgumentException>(() => CheckIfNullOrEmpty(student.Name));
        }

        public void CheckIfNullOrEmpty(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                throw new ArgumentException();
            }
        }
    }
}

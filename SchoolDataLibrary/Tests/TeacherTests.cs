using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestFixture]
    public class TeacherTests
    {
        [Test]
        public void Teacher_GetFullName_ReturnsCorrectFullName()
        {
            // Arrange
            var teacher = new Teacher { FirstName = "John", LastName = "Doe" };

            // Act
            string fullName = teacher.GetFullName();

            // Assert
            Assert.AreEqual("John Doe", fullName);
        }
    }
}

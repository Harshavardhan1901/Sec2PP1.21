using NUnit.Framework;

namespace SchoolDataLibrary.Tests
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
            NUnit.Framework.Assert.AreEqual("John Doe", fullName);
        }

    }
}
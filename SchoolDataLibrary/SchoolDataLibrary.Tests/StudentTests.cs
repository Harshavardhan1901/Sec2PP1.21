using NUnit.Framework;

namespace SchoolDataLibrary.Tests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void Student_GetFullName_ReturnsCorrectFullName()
        {
            // Arrange
            var student = new Student { FirstName = "Alice", LastName = "Johnson" };

            // Act
            string fullName = student.GetFullName();

            // Assert
            NUnit.Framework.Assert.AreEqual("Alice Johnson", fullName);
        }

    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataLibrary.Tests
{
    [TestFixture]
    public class SubjectTests
    {
        [Test]
        public void Subject_GetSubjectName_ReturnsCorrectName()
        {
            // Arrange
            var subject = new Subject("Mathematics");

            // Act
            string subjectName = subject.GetSubjectName();

            // Assert
            NUnit.Framework.Assert.AreEqual("Mathematics", subjectName);
        }

    }
}

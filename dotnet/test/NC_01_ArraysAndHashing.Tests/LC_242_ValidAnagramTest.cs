using NC_01_ArraysAndHashing.LC_242_ValidAnagram;

namespace NC_01_ArraysAndHashing.Tests
{
    [TestFixture]
    internal class LC_242_ValidAnagramTest
    {
        [Test]
        [TestCase("racecar", "carrace", true)]
        [TestCase("jar", "jam", false)]
        public void ValidAnagram_WithVariousInputs_ReturnsExpectedResults(string s, string t, bool expected)
        {
            // Arrange
            // Arranged from the test case data

            // Act
            bool actual = Program.IsAnagram(s, t);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

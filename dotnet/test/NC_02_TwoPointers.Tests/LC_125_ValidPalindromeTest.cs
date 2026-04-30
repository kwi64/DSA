using NC_02_TwoPointers.LC_125_ValidPalindrome;

namespace NC_02_TwoPointers.Tests;

[TestFixture]
public class LC_125_ValidPalindromeTest
{
    [Test]
    [TestCase("A man, a plan, a canal: Panama", true)]
    [TestCase("race a car", false)]
    [TestCase(" ", true)]
    [TestCase(".,", true)]
    [TestCase("0P", false)]
    public void IsPalindrome_WithVariousInputs_ReturnsExpectedResult(string s, bool expected)
    {
        // Arrange

        // Act
        bool actual = Program.IsPalindrome(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

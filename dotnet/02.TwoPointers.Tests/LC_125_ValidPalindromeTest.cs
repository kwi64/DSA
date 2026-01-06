using TwoPointers;

namespace TwoPointers.Tests;

[TestFixture]
public class LC_125_ValidPalindromeTest
{
    [Test]
    [TestCase("A man, a plan, a canal: Panama", true)]
    [TestCase("race a car", false)]
    [TestCase(" ", true)]
    [TestCase(".,", true)]
    [TestCase("0P", false)]
    public void Question_ValidPalindrome_Should(string s, bool expected)
    {
        // Arrange

        // Act
        bool actual = LC_125_ValidPalindrome.IsPalindrome(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

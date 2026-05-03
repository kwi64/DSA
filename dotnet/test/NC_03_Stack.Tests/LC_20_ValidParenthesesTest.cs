using NC_03_Stack.LC_20_ValidParentheses;

namespace NC_03_Stack.Tests;

[TestFixture]
public class LC_20_ValidParenthesesTest
{
    [Test]
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    [TestCase("([])", true)]
    [TestCase("([)]", false)]
    [TestCase("[", false)]
    [TestCase("]", false)]
    public void IsValid_WithVariousBracketCombinations_ReturnsExpectedResult(string s, bool expected)
    {
        // Arrange

        // Act
        bool actual = Program.IsValid(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

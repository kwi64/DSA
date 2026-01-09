namespace _03_Stack.Tests;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    [TestCase("([])", true)]
    [TestCase("([)]", false)]
    [TestCase("[", false)]
    [TestCase("]", false)]
    public void IsValid_WhenEvaluatingBracketCombinations_ReturnsExpectedResult(string s, bool expected)
    {
        // Arrange

        // Act
        bool actual = LC_20_ValidParentheses.IsValid(s);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

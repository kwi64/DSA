using Arrays;
using NUnit.Framework.Legacy;

namespace Arrays.Tests;

[TestFixture]
class LC_217_ContainsDuplicateTest
{
    [Test]
    [TestCase(new int[]{1, 2, 3, 1}, true)]
    [TestCase(new int[]{1, 2, 3, 4}, false)]
    [TestCase(new int[]{1, 1, 1, 3, 3, 4, 3, 2, 4, 2}, true)]
    public void ContainsDuplicate_ReturnTrue(int[] nums, bool expected)
    {
        // Arrange
        // Arranged from the test case data

        // Act
        bool actual = LC_217_ContainsDuplicate.Question(nums);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
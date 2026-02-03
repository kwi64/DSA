namespace _04_BinarySearch.Tests;

public class LC_704_BinarySearchTest
{
    [Test]
    [TestCase(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [TestCase(new int[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    public void Search_TargetExistsOrNotInSortedInputs_ReturnsExpectedResult(int[] nums, int target, int expected)
    {
        // Arrange

        // Act
        int actual = LC_704_BinarySearch.Search(nums, target);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

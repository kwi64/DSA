using NC_02_TwoPointers.LC_167_TwoSum2Sorted;

namespace NC_02_TwoPointers.Tests
{
    [TestFixture]
    internal class LC_167_TwoSum2Sorted
    {
        [Test]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 3, 4 }, 6, new int[] { 1, 3 })]
        [TestCase(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
        public void TwoSum_WithVariousInputs_ReturnsExpectedResult(int[] numbers, int target, int[] expected)
        {
            // Arrange
            // Arranged from the provided test cases

            // Act
            int[] actual = Program.TwoSum(numbers, target);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

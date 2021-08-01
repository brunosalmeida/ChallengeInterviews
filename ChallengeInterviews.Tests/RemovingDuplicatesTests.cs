using Xunit;

namespace ChallengeInterviews.Tests
{
    public class RemovingDuplicatesTests
    {
        [Fact]
        public void GivenDuplicatedNumbersShouldReturnNumbersWithouDuplicateds()
        {
            var numbers = new int[]
            {
                1, 2, 2, 3, 34, 4, 4, 55, 66, 6, 7, 8, 8, 9, 0, 1
            };

            var expected = new int[]
            {
                3, 34, 55, 66, 6, 7, 9, 0
            };

            var result = RemovingDuplicates.Remove(numbers);

            Assert.Equal(expected, result);
        }
    }
}
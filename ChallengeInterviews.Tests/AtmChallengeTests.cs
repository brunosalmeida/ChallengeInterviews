using System;
using Xunit;

namespace ChallengeInterviews.Tests
{
    public class AtmChallengeTests
    {
        [Fact]
        public void AskedFor150EurosShouldReturn100EuroBillAnd50EuroBill()
        {
            var result = AtmChallenge.Withdraw(150);
            
            Assert.True(result.Length > 0);
            Assert.True(result.Length == 2);
            Assert.True(result[0] == 100);
            Assert.True(result[1] == 50);
        }
    }
}
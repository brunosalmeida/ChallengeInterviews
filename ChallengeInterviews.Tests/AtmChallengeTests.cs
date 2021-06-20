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

            Assert.Equal(2, result.Length);
            Assert.Equal(100, result[0]);
            Assert.Equal(50, result[1]);
        }

        [Fact]
        public void AskedFor120EurosShouldReturn100EuroBillAndTwo10EuroBills()
        {
            var result = AtmChallenge.Withdraw(120);

            Assert.Equal(3, result.Length);
            Assert.Equal(100, result[0]);
            Assert.Equal(10, result[1]);
            Assert.Equal(10, result[2]);
        }

        [Fact]
        public void AskedFor170EurosShouldReturn100EuroBillAnd50EuroBillTwo10EuroBills()
        {
            var result = AtmChallenge.Withdraw(170);

            Assert.Equal(4, result.Length);
            Assert.Equal(100, result[0]);
            Assert.Equal(50, result[1]);
            Assert.Equal(10, result[2]);
            Assert.Equal(10, result[3]);
        }

        [Fact]
        public void AskedFor70EurosShouldReturn50EuroTwo10EuroBills()
        {
            var result = AtmChallenge.Withdraw(70);

            Assert.Equal(3, result.Length);
            Assert.Equal(50, result[0]);
            Assert.Equal(10, result[1]);
            Assert.Equal(10, result[2]);
        }

        [Fact]
        public void AskedFor40EurosShouldReturnFour10EuroBills()
        {
            var result = AtmChallenge.Withdraw(40);

            Assert.Equal(4, result.Length);
            Assert.Equal(10, result[0]);
            Assert.Equal(10, result[1]);
            Assert.Equal(10, result[2]);
            Assert.Equal(10, result[3]);
        }

        [Fact]
        public void AskedFor1000EurosShouldReturnTen100EuroBills()
        {
            var result = AtmChallenge.Withdraw(1000);

            Assert.Equal(10, result.Length);
            Assert.Equal(100, result[0]);
            Assert.Equal(100, result[1]);
            Assert.Equal(100, result[2]);
            Assert.Equal(100, result[3]);
            Assert.Equal(100, result[4]);
            Assert.Equal(100, result[5]);
            Assert.Equal(100, result[6]);
            Assert.Equal(100, result[7]);
            Assert.Equal(100, result[8]);
            Assert.Equal(100, result[9]);
        }

        [Fact]
        public void AskedFor25EurosShouldReturnError()
        {
            var exception = Record.Exception(() => AtmChallenge.Withdraw(25));
            Assert.NotNull(exception);
            Assert.Equal("No bills available", exception.Message);
            Assert.IsType<Exception>(exception);
        }
        
        [Fact]
        public void AskedFor10EurosShouldReturn10EurosBill()
        {
            var result = AtmChallenge.Withdraw(10);

            Assert.Single(result);
            Assert.Equal(10, result[0]);
        }
        
        [Fact]
        public void AskedFor50EurosShouldReturn50EurosBill()
        {
            var result = AtmChallenge.Withdraw(50);

            Assert.Single(result);
            Assert.Equal(50, result[0]);
        }
        
        [Fact]
        public void AskedFor100EurosShouldReturn100EurosBill()
        {
            var result = AtmChallenge.Withdraw(100);

            Assert.Single(result);
            Assert.Equal(100, result[0]);
        }
    }
}
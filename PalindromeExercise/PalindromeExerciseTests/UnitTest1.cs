using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("burritoman", false)]
        [InlineData("basketball", false)]
        [InlineData("level", true)]
        [InlineData("radar", true)]
        public void PalindromeTest(string word, bool expected)
        {
            WordSmith instance = new WordSmith();

            bool actual = instance.IsAPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}

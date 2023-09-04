using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData( "racecar", true)]
        [InlineData( "animal", false)]
        [InlineData( "rotator", true)]
        [InlineData( "borrow", false)]
        [InlineData( "level", true)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var result = test.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}

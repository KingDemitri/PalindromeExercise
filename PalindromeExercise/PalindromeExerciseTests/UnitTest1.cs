using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("dEmitri",false)]
        [InlineData("breAd",false)]
        [InlineData("Mom",true)]
        [InlineData("Shave",false)]
        [InlineData("always",false)]
        [InlineData("motel",false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var instance = new WordSmith();
            //Act
            var actual = instance.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

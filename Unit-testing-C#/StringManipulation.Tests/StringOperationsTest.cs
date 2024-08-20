using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            //Arrange
            var strOperation = new StringOperations();
            //Act
            var result = strOperation.ConcatenateStrings("Hello", "World");
            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void IsPalindromeTest_True()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("ama");

            //assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeTest_False()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("hello");

            //Assert
            Assert.False(result);
        }
    }
}

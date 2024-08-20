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
            Assert.Equal("Hello World", result);
        }
    }
}

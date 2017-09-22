using System;
using Xunit;
using FibonacciClass;

namespace FibonacciClass.Tests
{
    public class FibonacciTest
    {
        [Fact]
        public void TestFibonacci()
        {
            //Arrange
            Fibonacci obj = new Fibonacci();

            //Act
            int result = obj.Check(10);

            //Assert
            Assert.IsType<int>(result);
            Assert.Equal(144,result);
            Assert.NotEqual(133,result);
             
        }
    }
}

using System;
using Xunit;
using ArrayClass;

namespace ArrayClass.Tests
{
    public class ArrayTest
    {
        [Fact]
        public void TestArray()
        {
            //Arrange
            Array obj = new Array();

            //Act
            int var = obj.enterSize(2);
            //int varNeg = obj.enterSize(4.5);
            bool vari = obj.showArray(9);
            bool variNeg = obj.showArray(14);

            //Assert
            Assert.IsType<int>(var);
           // Assert.IsNotType<int>(variNeg);
            Assert.True(vari);
            Assert.False(variNeg);
        }
    }
}

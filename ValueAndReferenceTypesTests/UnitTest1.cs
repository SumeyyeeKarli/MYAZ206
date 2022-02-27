using ValueAndReferenceType;
using Xunit;

namespace ValueAndReferenceTypesTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReferenceTypeTest()
        {
            //Arrange
            var p1 = new ReferenceType(3, 4);
            var p2 = p1;

            //Act
            p2.X = 10;

            //Assert
            Assert.NotEqual(p1.X,p2.X);
        }

        [Fact]
        public void ValueTypeTest()
        {
            //Arrange
            var p1= new ReferenceType(3, 4);
            var p2= p1;

            //Act
            p2.X = 10;

            //Assert
            Assert.NotEqual(p1.X ,p2.X);
        }
    }
}
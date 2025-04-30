

using System.Drawing;

namespace CICDpractice.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CorrectCircleTest()
        {
            var circle = new GeometricOperations.Circle(5);

            Assert.Equal(2 * Math.PI * 5, circle.GetPerimeter());
            Assert.Equal(Math.PI * 25, circle.GetArea());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void ShouldThrowExceptionCircle(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new GeometricOperations.Circle(radius));
        }

        [Fact]
        public void CorrectRectangleTest()
        {
            var rectangle = new GeometricOperations.Rectangle(5);
            Assert.Equal(20, rectangle.GetPerimeter());
            Assert.Equal(25, rectangle.GetArea());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void ShouldThrowExceptionRectangle(double side)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new GeometricOperations.Circle(side));
        }

        [Fact]
        public void CorrectTriangleTest()
        {
            var triangle = new GeometricOperations.Triangle(3,4,5);
            Assert.Equal(12, triangle.GetPerimeter());
            Assert.Equal(6, triangle.GetArea());
        }

        [Theory]
        [InlineData(0,2,3)]
        [InlineData(-2,3,4)]

        public void ShouldThrowArgumentOutOfRangeExceptionTriangle(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                new GeometricOperations.Triangle(a,b,c));
        }

        [Fact]
        public void ShouldThrowArgumentExceptionTriangle()
        {
            Assert.Throws<ArgumentException>(() =>
                new GeometricOperations.Triangle(1,2,3));
        }
    }
}
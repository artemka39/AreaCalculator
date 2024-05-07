using ShapeAreaCalculator.Common;
using ShapeAreaCalculator.Common.Models;
using FluentAssertions;
using NUnit.Framework;

namespace ShapeAreaCalculator.Tests
{
    [TestFixture]
    public class ShapeFactoryTest
    {
        [Test]
        public void CreateShape_CreateCircleTest()
        {
            //Arrange
            var shapeParams = new List<double> { 1 };
            var shapeFactory = new ShapeFactory();
            var expectedShape = new Circle(1);

            //Act
            var actualShape = shapeFactory.CreateShape(shapeParams);

            //Assert
            actualShape.Should().BeEquivalentTo(expectedShape);
        }

        [Test]
        public void CreateShape_CreateTriangleTest()
        {
            //Arrange
            var shapeParams = new List<double> { 3, 4, 5 };
            var shapeFactory = new ShapeFactory();
            var expectedShape = new Triangle(3, 4, 5);

            //Act
            var actualShape = shapeFactory.CreateShape(shapeParams);

            //Assert
            actualShape.Should().BeEquivalentTo(expectedShape);
        }

        [Test]
        public void CreateShape_InvalidParametersCount()
        {
            //Arrange
            var shapeParams = new List<double> { 2, 2 };
            var shapeFactory = new ShapeFactory();

            //Act
            var shapeCreationFunc = () => shapeFactory.CreateShape(shapeParams);

            //Assert
            shapeCreationFunc.Should()
                .Throw<NotImplementedException>()
                .WithMessage("Can't create shape with this count of params");
        }

        [Test]
        public void CreateShape_EmptyParametersList()
        {
            //Arrange
            var shapeParams = new List<double>();
            var shapeFactory = new ShapeFactory();

            //Act
            var shapeCreationFunc = () => shapeFactory.CreateShape(shapeParams);

            //Assert
            shapeCreationFunc.Should()
                .Throw<ArgumentException>()
                .WithMessage("You didn't input any parameter");
        }

        [Test]
        public void CreateShape_InvalidParameterNotPositive()
        {
            //Arrange
            var shapeParams = new List<double> { -1 };
            var shapeFactory = new ShapeFactory();

            //Act
            var shapeCreationFunc = () => shapeFactory.CreateShape(shapeParams);

            //Assert
            shapeCreationFunc.Should()
                .Throw<ArgumentException>()
                .WithMessage("Parameters must be posisitve");
        }
    }
}

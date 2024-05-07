using ShapeAreaCalculator.Common;
using FluentAssertions;
using ShapeAreaCalculator.Backend.AreaCalculators;
using ShapeAreaCalculator.Backend;
using NUnit.Framework;

namespace ShapeAreaCalculator.Tests
{
    [TestFixture]
    public class AreaCalculatorTest
    {
        [Test]
        public void CalculateArea_ForCircle()
        {
            //Arrange
            var shapeParams = new List<double> { 1 };
            var areaCalculator = new AreaCalculator(new ShapeFactory());
            var expectedCalculationResult = new CalculationResult
            {
                ShapeType = ShapeTypes.Circle.ToString(),
                Area = 2 * Math.PI * 1
            };

            //Act
            var actualCalculationResult = areaCalculator.CalculateArea(shapeParams);

            //Assert
            actualCalculationResult.Should().BeEquivalentTo(expectedCalculationResult);
        }

        [Test]
        public void CalculateArea_ForTriangle()
        {
            //Arrange
            var shapeParams = new List<double> { 3, 4, 5 };
            var areaCalculator = new AreaCalculator(new ShapeFactory());
            var expectedCalculationResult = new CalculationResult
            {
                ShapeType = ShapeTypes.Triangle.ToString(),
                Area = 6
            };

            //Act
            var actualCalculationResult = areaCalculator.CalculateArea(shapeParams);

            //Assert
            actualCalculationResult.Should().BeEquivalentTo(expectedCalculationResult);
        }

        [Test]
        public void CalculateArea_InvalidParametersCount()
        {
            //Arrange
            var shapeParams = new List<double> { 2, 2 };
            var areaCalculator = new AreaCalculator(new ShapeFactory());
            //Act
            var calculateAreaFunc = () => areaCalculator.CalculateArea(shapeParams);

            //Assert
            calculateAreaFunc.Should()
                .Throw<NotImplementedException>();
        }
    }
}
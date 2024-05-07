using FluentAssertions;
using ShapeAreaCalculator.Backend;
using ShapeAreaCalculator.Backend.AreaCalculators;
using ShapeAreaCalculator.Common;
using ShapeAreaCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Tests
{
    [TestFixture]
    public class CircleAreaCalculatorTest
    {
        [Test]
        public void CalculateArea_ForCircle()
        {
            //Arrange
            var circleAreaCalculator = new CircleAreaCalculator(new Circle(1));
            var expectedCircleArea = new CalculationResult
            {
                ShapeType = ShapeTypes.Circle.ToString(),
                Area = 2 * Math.PI * 1
            };

            //Act
            var actualCircleArea = circleAreaCalculator.CalculateArea();

            //Assert
            actualCircleArea.Should().BeEquivalentTo(expectedCircleArea);
        }
    }
}

using ShapeAreaCalculator.Backend.AreaCalculators;
using ShapeAreaCalculator.Backend;
using ShapeAreaCalculator.Common.Models;
using ShapeAreaCalculator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace ShapeAreaCalculator.Tests
{
    [TestFixture]
    public class TriangleAreaCalculatorTest
    {
        [Test]
        public void CalculateArea_ForTriangle()
        {
            //Arrange
            var triangleAreaCalculator = new TriangleAreaCalculator(new Triangle(3, 4, 5));
            var expectedTriangleArea = new CalculationResult
            {
                ShapeType = ShapeTypes.Triangle.ToString(),
                Area = 6
            };

            //Act
            var actualTriangleArea = triangleAreaCalculator.CalculateArea();

            //Assert
            actualTriangleArea.Should().BeEquivalentTo(expectedTriangleArea);
        }
    }
}

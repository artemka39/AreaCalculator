using ShapeAreaCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Backend.AreaCalculators
{
    public class TriangleAreaCalculator
    {
        private Triangle triangle;
        public TriangleAreaCalculator(Shape shape)
        {
            this.triangle = (Triangle)shape;
        }
        public CalculationResult CalculateArea()
        {
            ValidateSides();
            var semiPerimeter = CalculateSemiPerimeter(triangle);
            var area = Math.Sqrt(
                semiPerimeter *
                (semiPerimeter - triangle.A) *
                (semiPerimeter - triangle.B) *
                (semiPerimeter - triangle.C));
            return new CalculationResult
            {
                ShapeType = triangle.ShapeType.ToString(),
                Area = area
            };
        }
        private double CalculateSemiPerimeter(Triangle triangle)
        {
            return (triangle.A + triangle.B + triangle.C)/2;
        }
        private void ValidateSides()
        {
            if ((triangle.A + triangle.B <= triangle.C)||
                (triangle.A + triangle.C <= triangle.B)||
                (triangle.B + triangle.C <= triangle.A))
            {
                throw new ArgumentException("Sum of two sides must be greater than third side");
            }
        }
    }
}

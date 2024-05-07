using ShapeAreaCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Backend.AreaCalculators
{
    public class CircleAreaCalculator
    {
        private Circle circle;
        public CircleAreaCalculator(Shape shape)
        {
            this.circle = (Circle)shape;
        }

        public CalculationResult CalculateArea()
        {
            var area = 2 * Math.PI * circle.Radius;
            return new CalculationResult
            {
                ShapeType = circle.ShapeType.ToString(),
                Area = area
            };
        }
    }
}

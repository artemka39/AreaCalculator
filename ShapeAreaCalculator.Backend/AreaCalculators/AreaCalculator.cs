using ShapeAreaCalculator.Common;
using ShapeAreaCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Backend.AreaCalculators
{
    public class AreaCalculator
    {
        private readonly ShapeFactory shapeFactory;
        public AreaCalculator(ShapeFactory shapeFactory)
        {
            this.shapeFactory = shapeFactory;
        }
        public CalculationResult CalculateArea(List<double> shapeParams)
        {
            var shape = shapeFactory.CreateShape(shapeParams);
            return shape.ShapeType switch
            {
                ShapeTypes.Circle => new CircleAreaCalculator(shape).CalculateArea(),
                ShapeTypes.Triangle => new TriangleAreaCalculator(shape).CalculateArea()
            };
        }
    }
}

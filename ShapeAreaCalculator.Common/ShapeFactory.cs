using ShapeAreaCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Common
{
    public class ShapeFactory
    {
        public Shape CreateShape(List<double> shapeParams)
        {
            ValidateShapeParams(shapeParams);
            return shapeParams.Count switch
            {
                1 => new Circle(shapeParams[0]),
                3 => new Triangle(shapeParams[0], shapeParams[1], shapeParams[2]),
                _ => throw new NotImplementedException("Can't create shape with this count of params")
            };
        }
        private void ValidateShapeParams(List<double> shapeParams)
        {
            if (shapeParams.Count == 0)
            {
                throw new ArgumentException("You didn't input any parameter");
            }
            foreach (var shapeParam in shapeParams)
            {
                if (shapeParam <= 0)
                {
                    throw new ArgumentException("Parameters must be posisitve");
                }
            }
        }
    }
}

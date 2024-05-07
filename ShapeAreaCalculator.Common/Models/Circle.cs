using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Common.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double Radius)
        {
            ShapeType = ShapeTypes.Circle;
            this.Radius = Radius;
        }
    }
}

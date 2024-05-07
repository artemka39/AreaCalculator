using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Common.Models
{
    public class Triangle : Shape
    {
        public bool IsRectangular { get; private set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double A, double B, double C)
        {
            ShapeType = ShapeTypes.Triangle;
            IsRectangular = CheckIsRectangular();
            this.A = A;
            this.B = B;
            this.C = C;
        }

        private bool CheckIsRectangular()
        {
            var squaredSides = new List<double> { A, B, C }.Select(side => Math.Pow(side, 2)).ToList();
            var maxSquaredSide = squaredSides.Max();
            squaredSides.Remove(maxSquaredSide);
            return maxSquaredSide == squaredSides[0] + squaredSides[1];
        }
    }
}

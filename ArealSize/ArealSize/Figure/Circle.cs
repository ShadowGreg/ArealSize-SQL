using ArealSize.Abstractions;

namespace ArealSize.Figure {
    /// <summary>
    /// Represents a circle figure that implements the IFigure interface.
    /// </summary>
    public class Circle: IFigure {
        private readonly double _radius; // Radius of the circle

        /// <summary>
        /// Initializes a new instance of the Circle class with the given radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        public Circle(double radius)
        {
            if (radius <= 0 || Double.IsNaN(radius) || Double.IsPositiveInfinity(radius) ||
                Double.IsNegativeInfinity(radius))
            {
                throw new ArgumentException("Radius must be more than zero");
            }

            _radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle using the formula: π * radius^2.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public double GetArea()
        {
            double area = Math.PI * _radius * _radius;
            if (Double.IsInfinity(area))
            {
                throw new ArithmeticException("Area calculation resulted in overflow");
            }

            return area;
        }
    }
}
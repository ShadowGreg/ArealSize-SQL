using ArealSize.Abstractions;

namespace ArealSize.Figure {
    /// <summary>
    /// Represents a triangle figure that implements the IFigure interface.
    /// </summary>
    public class Triangle: IFigure {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;
        private readonly List<double> _sideList;

        /// <summary>
        /// Initializes a new instance of the Triangle class with the given side lengths.
        /// </summary>
        /// <param name="firstSide">Length of the first side of the triangle.</param>
        /// <param name="secondSide">Length of the second side of the triangle.</param>
        /// <param name="thirdSide">Length of the third side of the triangle.</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!IsValidTriangle(firstSide, secondSide, thirdSide))
            {
                throw new ArgumentOutOfRangeException(
                    "Invalid triangle sides. The sum of any two sides must be greater than the third side.");
            }

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
            _sideList = new List<double>() { _firstSide, _secondSide, _thirdSide };
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public double GetArea()
        {
            double tempP = GetSemiPerimeter();
            return Math.Sqrt(tempP * (tempP - _firstSide) * (tempP - _secondSide) * (tempP - _thirdSide));
        }

        /// <summary>
        /// Checks if the triangle is a right-angled triangle.
        /// </summary>
        /// <returns>True if the triangle is right-angled, false otherwise.</returns>
        public bool CheckRectangular()
        {
            IEnumerable<double> tempList = GetTempListSides(_sideList.Max());
            return _sideList.Max() * _sideList.Max() == GetSumSquares(tempList);
        }

        /// <summary>
        /// Validates if the given side lengths can form a triangle.
        /// </summary>
        public static bool IsValidTriangle(double a, double b, double c)
        {
            if (a is <= 0 or Double.NaN || Double.IsInfinity(a))
                throw new ArgumentOutOfRangeException(nameof(a));
            if (b is <= 0 or Double.NaN || Double.IsInfinity(b))
                throw new ArgumentOutOfRangeException(nameof(b));
            if (c is <= 0 or Double.NaN || Double.IsInfinity(c))
                throw new ArgumentOutOfRangeException(nameof(c));
            return a + b > c && a + c > b && b + c > a;
        }

        /// <summary>
        /// Returns a list of sides with an element removed.
        /// </summary>
        public IEnumerable<double> GetTempListSides(double deleteElement)
        {
            List<double> outputList = new(_sideList);
            if (!outputList.Remove(deleteElement))
            {
                throw new ArgumentOutOfRangeException("There is no such element to delete.");
            }

            return outputList;
        }

        /// <summary>
        /// Calculates the semi-perimeter of the triangle.
        /// </summary>
        public double GetSemiPerimeter()
        {
            return (_firstSide + _secondSide + _thirdSide) / 2;
        }

        /// <summary>
        /// Calculates the sum of squares of elements in the input list.
        /// </summary>
        public double GetSumSquares(IEnumerable<double> inputList)
        {
            IEnumerable<double> squaredNumbers = inputList.Select(x => x * x);
            return squaredNumbers.Sum();
        }
    }
}
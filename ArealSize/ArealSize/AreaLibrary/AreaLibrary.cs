using ArealSize.Abstractions;
using System;

namespace ArealSize.AreaLibrary
{
    /// <summary>
    /// A static class that provides functionality to calculate the area of a figure.
    /// </summary>
    public static class AreaLibrary<T> where T : IFigure
    {
        private static T? _figure; // The figure instance

        /// <summary>
        /// Initializes the figure instance for area calculation.
        /// </summary>
        /// <param name="inputFigure">The figure to be initialized.</param>
        public static void Initialize(T inputFigure)
        {
            if (inputFigure == null)
            {
                throw new ArgumentNullException(nameof(inputFigure), "Input figure cannot be null.");
            }
            _figure = inputFigure;
        }

        /// <summary>
        /// Calculates the area of the initialized figure.
        /// </summary>
        /// <returns>The area of the figure.</returns>
        public static double CalculateArea()
        {
            if (_figure == null)
            {
                throw new InvalidOperationException("Figure instance is null. Please initialize the figure first.");
            }
            return _figure.GetArea();
        }
    }
}
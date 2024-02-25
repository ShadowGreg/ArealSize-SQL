using ArealSize.Figure;

namespace ArealSize.Tests {
    [TestFixture]
    public class TriangleTests {
        [Theory]
        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(8, 15, 17)]
        public void GetArea_ValidTriangle_ReturnsCorrectArea(
            double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.GetArea();

            // Calculate area using Heron's formula for comparison
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) *
                                            (semiPerimeter - sideC));

            // Assert
            Assert.That(area,
                Is.EqualTo(expectedArea).Within(0.0001)); // Allowing a small tolerance for floating-point comparison
        }

        [Test]
        public void CheckRectangular_RightAngledTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRectangular = triangle.CheckRectangular();

            // Assert
            Assert.That(isRectangular, Is.True);
        }

        [Theory]
        [TestCase(3, 4, 5, true)]
        [TestCase(5, 12, 13, true)]
        [TestCase(8, 15, 17, true)]
        [TestCase(3, 4, 6, false)]
        [TestCase(5, 12, 14, false)]
        [TestCase(8, 15, 18, false)]
        public void Triangle_rightness_checking_is_correct(
            double sideA, double sideB, double sideC, bool expected)
        {
            //Arrange 
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool actualRectangular = triangle.CheckRectangular();

            //& Assert
            Assert.That(actualRectangular, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(double.NaN, 4, 5)]
        [TestCase(double.PositiveInfinity, 4, 5)]
        [TestCase(1, double.NaN, 5)]
        [TestCase(1, 2, double.NaN)]
        [TestCase(0, 4, 5)]
        [TestCase(-1, 4, 5)]
        public void Triangle_with_negative_size_creating_is_impossible(
            double sideA, double sideB, double sideC)
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}
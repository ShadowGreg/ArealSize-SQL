using ArealSize.Figure;

namespace ArealSize.Tests {
    [TestFixture]
    public class TriangleTests {
        [Test]
        public void GetArea_ValidTriangle_ReturnsCorrectArea() {
            // Arrange
            const double sideA = 3;
            const double sideB = 4;
            const double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.GetArea();

            // Calculate area using Heron's formula for comparison
            const double semiPerimeter = (sideA + sideB + sideC) / 2;
            double expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) *
                                            (semiPerimeter - sideC));

            // Assert
            Assert.That(area,
                Is.EqualTo(expectedArea).Within(0.0001)); // Allowing a small tolerance for floating-point comparison
        }

        [Test]
        public void CheckRectangular_RightAngledTriangle_ReturnsTrue() {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRectangular = triangle.CheckRectangular();

            // Assert
            Assert.IsTrue(isRectangular);
        }

        [Test]
        public void CheckRectangular_NonRightAngledTriangle_ReturnsFalse() {
            // Arrange
            Triangle triangle = new Triangle(2, 3, 4);

            // Act
            bool isRectangular = triangle.CheckRectangular();

            // Assert
            Assert.IsFalse(isRectangular);
        }

        [Test]
        public void IsValidTriangle_ValidTriangle_ReturnsTrue() {
            // Arrange
            const double sideA = 3;
            const double sideB = 4;
            const double sideC = 5;

            // Act
            bool isValid = Triangle.IsValidTriangle(sideA, sideB, sideC);

            // Assert
            Assert.IsTrue(isValid);
        }

        [Test]
        public void IsValidTriangle_InvalidTriangle_ReturnsFalse() {
            // Arrange
            double sideA = 1;
            double sideB = 2;
            double sideC = 10;

            // Act
            bool isValid = Triangle.IsValidTriangle(sideA, sideB, sideC);

            // Assert
            Assert.IsFalse(isValid);
        }
    }
}
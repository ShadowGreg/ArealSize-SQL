using ArealSize.Figure;

namespace ArealSize.Tests {
    [TestFixture]
    public class CircleTests {
        [Test]
        public void GetArea_WithValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.GetArea();

            // Assert
            double expectedArea = Math.PI * radius * radius;
            Assert.That(area,
                Is.EqualTo(expectedArea).Within(0.0001)); // Allowing a small tolerance for floating-point comparison
        }

        [Theory]
        [TestCase(Double.NaN)]
        [TestCase(Double.PositiveInfinity)]
        [TestCase(Double.NegativeInfinity)]
        [TestCase(0)]
        [TestCase(-1)]
        public void Constructor_WithNegativeRadius_ThrowsArgumentException(double radius)
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Theory]
        [TestCase(1, Math.PI)]
        [TestCase(5.5, 95.033177771091232d)]
        public void Area_calculation_is_correct(double radius, double expectedArea)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            var actualArea = circle.GetArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }
    }
}
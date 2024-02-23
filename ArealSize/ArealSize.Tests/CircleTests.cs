using ArealSize.Figure;

namespace ArealSize.Tests
{
    [TestFixture]
    public class CircleTests
    {
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
            Assert.That(area, Is.EqualTo(expectedArea).Within(0.0001)); // Allowing a small tolerance for floating-point comparison
        }

        [Test]
        public void Constructor_WithNegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = -5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Test]
        public void Constructor_WithZeroRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
using ArealSize.Abstractions;
using ArealSize.AreaLibrary;
using Moq;

namespace ArealSize.Tests {
    [TestFixture]
    public class AreaLibraryTests {
        [Test]
        public void CalculateArea_WithInitializedFigure_ReturnsCorrectArea() {
            // Arrange
            var mockFigure = new Mock<IFigure>();
            mockFigure.Setup(f => f.GetArea()).Returns(10.0);

            AreaLibrary<IFigure>.Initialize(mockFigure.Object);

            // Act
            double area = AreaLibrary<IFigure>.CalculateArea();

            // Assert
            Assert.That(area, Is.EqualTo(10.0));
        }

        [Test]
        public void CalculateArea_WithUninitializedFigure_ThrowsException() {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => AreaLibrary<IFigure>.Initialize(null!));
        }

        [Test]
        public void CalculateArea_WithCustomTestFigure_ReturnsCorrectArea() {
            // Arrange
            var testFigure = new TestFigure(15.0);

            AreaLibrary<TestFigure>.Initialize(testFigure);

            // Act
            double area = AreaLibrary<TestFigure>.CalculateArea();

            // Assert
            Assert.That(area, Is.EqualTo(15.0));
        }
    }
}
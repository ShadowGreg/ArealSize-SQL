using ArealSize.Figure;

namespace ArealSize.Tests;

public class ClassTest {
    [Test]
    public void Triangle_and_circle_are_figure()
    {
        // Arrange
        var triangle = new Triangle(firstSide: 3, secondSide: 4, thirdSide: 5);
        var circle = new Circle(1);

        // Act
        var triangleInterface = triangle.GetType().GetInterface("IFigure");
        var circleInterface = circle.GetType().GetInterface("IFigure");
        
        //Assert
        Assert.That(triangleInterface, Is.Not.Null);
        Assert.That(circleInterface, Is.Not.Null);
    }
}
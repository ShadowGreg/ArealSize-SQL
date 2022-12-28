using ArealSize.Figure;
using ArealSize.UnifiedInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArealSizeTests;

[TestClass()]
public class GetAreaCommandTest
{
    const double RADIUS      = 1;
    const double FIRST_SIDE  = 1;
    const double SECOND_SIDE = 1;
    const double THIRD_SIDE  = 1;
    [TestMethod()]
    public void Create_Circle_Test()
    {
        IFigure testCircle = new Circle(RADIUS);
        IFigure testTriangle = new Triangle(FIRST_SIDE, SECOND_SIDE, THIRD_SIDE);
        var testCircleCommand = new GetAreaCommand(testCircle);
        var testTriangleCommand = new GetAreaCommand(testTriangle);
        
        
        Assert.IsNotNull(testCircleCommand.Execute());
        Assert.IsNotNull(testTriangleCommand.Execute());
    }
    
}
using ArealSize.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArealSizeTests;

[TestClass()]
public class CircleTes
{
    const double RADIUS = 1;
    
    [TestMethod()]
    public void Create_Circle_Test()
    {
        IFigure testCircle = new Circle(RADIUS);
        
        Assert.IsNotNull(testCircle);
    }
    
    [TestMethod()]
    public void GetArea_Circle_Test()
    {
        IFigure testCircle = new Circle(RADIUS);

        const double expectedArea = Math.PI * RADIUS * RADIUS;
        
        Assert.AreEqual(expectedArea,testCircle.GetArea());
    }
}
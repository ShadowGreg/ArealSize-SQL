using ArealSize.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArealSizeTests;

[TestClass()]
public class TriangleTest
{
    const double FIRST_SIDE  = 1;
    const double SECOND_SIDE = 1;
    const double THIRD_SIDE  = 2;

    [TestMethod()]
    public void Create_Triangle_Test()
    {
        IFigure testTriangle = new Triangle(FIRST_SIDE, SECOND_SIDE, THIRD_SIDE);

        Assert.IsNotNull(testTriangle);
    }
    
    [TestMethod()]
    public void GetArea_Triangle_Test()
    {
        IFigure testTriangle = new Triangle(FIRST_SIDE, SECOND_SIDE, THIRD_SIDE);

        const double expectedArea = 0.4330127018922193;

        Assert.AreEqual(expectedArea, testTriangle.GetArea());
    }
    
}
namespace ArealSize.Figure;

public class Circle: IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI*_radius*_radius;
    }
}
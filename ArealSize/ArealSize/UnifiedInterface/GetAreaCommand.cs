using ArealSize.Figure;

namespace ArealSize.UnifiedInterface;

public class GetAreaCommand
{
    private readonly IFigure _figure;

    public GetAreaCommand(IFigure inputFigure)
    {
        _figure = inputFigure;
    }

    public double Execute()
    {
        return _figure.GetArea();
    }
}
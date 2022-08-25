namespace ArealSize;

public class CalculationAlgorithm
{
    private readonly List<Coordinates> _coordinatesList = new List<Coordinates>();
    private double _area = 0;

    public CalculationAlgorithm(IReadOnlyList<double>? inDoubleCoordinates)
    {
        if (inDoubleCoordinates != null)
        {
            var length = inDoubleCoordinates.Count;

            for (int i = 0; i < length; i = i + 2)
            {
                _coordinatesList.Add(new Coordinates(inDoubleCoordinates[i], inDoubleCoordinates[i + 1]));
            }
        }
    }

    public double AreaCalculation()
    {
        {
            var length = _coordinatesList.Count;
            if (CheckingStraightLine(_coordinatesList) == true)
            {
                Console.WriteLine("The points are located on a straight line");
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (i != length - 1)
                    {
                        _area = Math.Abs(_coordinatesList[i].x * _coordinatesList[i + 1].y - _coordinatesList[i + 1].x * _coordinatesList[i].y);
                    }
                    else
                    {
                        _area = Math.Abs(_coordinatesList[i].x * _coordinatesList[0].y - _coordinatesList[0].x * _coordinatesList[i].y);
                    }
                }
            }

        }

        _area = 0.5 * _area;
        return _area;
    }

    private bool CheckingStraightLine(List<Coordinates> coordinatesList)
    {
        bool answer= false;
        var length = _coordinatesList.Count-2;
        for (int i = 0; i < length; i++)
        {
            if (((coordinatesList[i+2].x - coordinatesList[i].x) / (coordinatesList[i+1].x - coordinatesList[i].x)) == ((coordinatesList[i+2].y - coordinatesList[i].y) / (coordinatesList[i + 1].y - coordinatesList[i].y)))
            {
                if (answer == false)
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                }
            }
        }
        return answer;
    }
}

internal class Coordinates
{
    public double x { get; }
    public double y { get; }

    public Coordinates(double inX, double inY)
    {
        x = inX;
        y = inY;
    }
}
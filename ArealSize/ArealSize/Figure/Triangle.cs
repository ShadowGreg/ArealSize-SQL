namespace ArealSize.Figure;

public class Triangle: IFigure
{
    private readonly double       _firstSide;
    private readonly double       _secondSide;
    private readonly double       _thirdSide;
    private readonly List<double> _sideList;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide < secondSide + thirdSide)
        {
            _firstSide  = firstSide;
            _secondSide = secondSide;
            _thirdSide  = thirdSide;
            _sideList = new List<double>()
                        {
                            _firstSide,
                            _secondSide,
                            _thirdSide
                        };
        }
        else
        {
            throw new Exception(" Class Triangle: triangle cannot create an instance of the class");
        }
    }

    private double GetSemiPerimeter()
    {
        return (_firstSide + _secondSide + _thirdSide) / 2;
    }
    public double GetArea()
    {
        double tempP = GetSemiPerimeter();
        return Math.Sqrt(tempP * (tempP - _firstSide) * (tempP - _secondSide) * (tempP - _thirdSide));
    }

    private IEnumerable<double> GetTempListSides(double deleteElement)
    {
        List<double> outputList = new List<double>(_sideList);
        if (outputList.Remove(deleteElement))
            throw new Exception("Class Triangle: there is no such element to delete");

        return outputList;
    }

    private static double GetSumSquares(IEnumerable<double> inputList)
    {
        IEnumerable<double> squaredNumbers = inputList.Select(x => x * x);
        return squaredNumbers.Sum();
    }


    public bool CheckRectangular()
    {
        IEnumerable<double> tempList = GetTempListSides(_sideList.Max());
        return _sideList.Max() * _sideList.Max() == GetSumSquares(tempList);
    }
}
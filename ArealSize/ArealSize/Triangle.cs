namespace ArealSize;

public class Triangle
{
    private readonly double _area = 0;
    private double _climeA, _climeB, _climeC;
    private double semiperimeter;
    private const string MessageRightAngled = "Right angled triangle";
    private const string MessageZero = "The sides of a triangle cannot be less than zero";
    private const string MessageExist = "The triangle does not exist";
    Triangle(double climeA, double climeB, double climeC)
    {
        this._climeA= climeA;
        this._climeB = climeB;
        this._climeC = climeC;
    }

    public double Area()
    {
        if (Math.Pow(_climeA, 2) == Math.Pow(_climeB, 2) + Math.Pow(_climeC, 2) ||
            Math.Pow(_climeB, 2) == Math.Pow(_climeA, 2) + Math.Pow(_climeC, 2) ||
            Math.Pow(_climeC, 2) == Math.Pow(_climeA, 2) + Math.Pow(_climeB, 2))
        {
            Console.WriteLine(MessageRightAngled);
        }
        else if (_climeA < 0 ||
                 _climeB < 0 ||
                 _climeC < 0)
        {
            Console.WriteLine(MessageZero);
        }
        else if (_climeA > (_climeB + _climeC) ||
                 _climeB > (_climeA + _climeC) ||
                 _climeC > (_climeA + _climeB))
        {
            Console.WriteLine(MessageExist);
        }
        else
        {
            semiperimeter = 0.5 * (_climeA + _climeB + _climeC);
            _area = Math.Sqrt(semiperimeter * (semiperimeter - _climeA) * (semiperimeter - _climeB) * (semiperimeter - _climeC));
        }
        return _area;
    }
}
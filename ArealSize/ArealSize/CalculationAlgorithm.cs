﻿using System.Runtime.ExceptionServices;

namespace ArealSize;

class CalculationAlgorithm
{
    private List<Coordinates>? _coordinatesList;
    private double area = 0;

    public CalculationAlgorithm(IReadOnlyList<double>? inDoubleCoordinates)
    {
        if (inDoubleCoordinates != null)
        {
            var lenght = inDoubleCoordinates.Count;

            for (int i = 0; i < lenght; i = i + 2)
            {
                _coordinatesList?.Add(new Coordinates(inDoubleCoordinates[i], inDoubleCoordinates[i+1]));
            }
        }
    }

    public double AreaCalculation()
    {
        if (_coordinatesList != null)
        {
            var length = _coordinatesList.Count;
            for (int i = 0; i < length; i++)
            {
                if (i != length - 1)
                {
                    area = _coordinatesList[i].x * _coordinatesList[i+1].y - _coordinatesList[i+1].x * _coordinatesList[i].y;
                }
                else
                {
                    area = _coordinatesList[i].x * _coordinatesList[0].y - _coordinatesList[0].x* _coordinatesList[i].y;
                }
            }
        }

        area = 0.5 * area;
        return area;
    }
}

class Coordinates
{
    public double x { get; }
    public double y { get; }

    public Coordinates(double inX, double inY)
    {
        x=inX;
        y=inY;
    }
}